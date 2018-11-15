using Steema.TeeChart;
using Steema.TeeChart.Export;
using Steema.TeeGrid.Bands;
using Steema.TeeGrid.Html;
using Steema.TeeGrid.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Serialization;

namespace DashBoard
{

	public enum commentType
	{
		global = 0,
		regional = 1,
		country = 2
	}
	public partial class ReportForm : Form
	{
		string activeCountry = "";
		string activeRegion = "";

		private Color[] BlueFlatPalette;
		private Steema.TeeChart.Tools.ScrollPager scrollPager1;
		private Steema.TeeChart.Animations.ChartPartAnimation BarAnimation;
		Steema.TeeChart.Styles.Area SmoothingArea;
		Steema.TeeChart.Functions.Smoothing SmoothingFunc;
		int ValueIndexCountry;
		int startYr = 0;
		int endYr = 0;
		bool DoScroll;
		int IndexBarClicked;
    int gStartYear;
		int gEndYear;
		Steema.TeeChart.Styles.Series BarSeriesClicked;
		bool tChart1Loaded = false;
		bool first;
		DataTable CountryCodeTable;



		public ReportForm()
		{
			InitializeComponent();
			//Create BluFlatPaletee
			BlueFlatPalette = new Color[]
			{

				ColorTranslator.FromHtml("#D6E1FA"),
				ColorTranslator.FromHtml("#7797D1"),
				ColorTranslator.FromHtml("#728CC0"),
				ColorTranslator.FromHtml("#5D80C9"),
				ColorTranslator.FromHtml("#4466A3"),
				ColorTranslator.FromHtml("#3B548C"),
				ColorTranslator.FromHtml("#1C2A47"),
				ColorTranslator.FromHtml("#203A6B"),
				ColorTranslator.FromHtml("#08193F")
			};

		}

		private System.Globalization.NumberFormatInfo nfi;
		private void ReportForm_Load(object sender, EventArgs e)
		{
			nfi = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.ToString(), false).NumberFormat;
			nfi.CurrencyDecimalDigits = 0;

			// TODO: This line of code loads data into the 'techProductsLtdDataSet1.Lookup_Continent' table. You can move, or remove it, as needed.
			this.lookup_ContinentTableAdapter.Fill(this.techProductsLtdDataSet1.Lookup_Continent);
			// TODO: This line of code loads data into the 'techProductsLtdDataSet1.Fact_Orders' table. You can move, or remove it, as needed.
			this.fact_OrdersTableAdapter.Fill(this.techProductsLtdDataSet1.Fact_Orders); //TeeGrid

			this.___SalesByYearContinentTableAdapter.Fill(this.techProductsLtdDataSet1.___SalesByYearContinent);//TChart2
			this.___SalesByContinentTableAdapter.Fill(this.techProductsLtdDataSet1.___SalesByContinent);//Tchart2
			this.___SalesByCountry_2015TableAdapter.Fill(this.techProductsLtdDataSet1.___SalesByCountry_2015);


			tChart1[0].CheckDataSource();  //country
			tChart3[0].CheckDataSource();  //region

			ReportInit();

			setHighestValueHistory();
			tChart1.Axes.Bottom.SetMinMax(2005, 2010);
			IndexBarClicked = -1;
			BarSeriesClicked = null;
			tChart1.Draw();
			setComments(commentType.global);

		}

		private void ReportInit()
		{
			GetTotalSales();
			GetTotalItemsSold();

			//-----------TChart1 (AreaSeries) Init-----------//
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(tChart1.Chart, BlueFlatPalette);

			tChart1.Axes.Bottom.Labels.Font.Name = "Tahoma";
			tChart1.Axes.Left.Labels.Font.Name = "Tahoma";
			tChart1.Axes.Left.Labels.Font.Size = 8;
			tChart1.Axes.Bottom.Labels.Font.Size = 8;
			//Margins
			tChart1.Panel.MarginUnits = Steema.TeeChart.PanelMarginUnits.Percent;
			tChart1.Panel.MarginLeft = 5;

			////---ScrollPager---//
			tChart1.Tools.Add(scrollPager1 = new Steema.TeeChart.Tools.ScrollPager());

			//-----------CursorTool and Annotation Tool for AreaChart Init-----------//
			vertCursorTool.Pen.Color = ColorTranslator.FromHtml("#8F8F8F");
			vertCursorTool.Pen.Width = 2; 
			horizCursorTool.Pen.Color = ColorTranslator.FromHtml("#8F8F8F");
			horizCursorTool.Pen.Width = 2;
			vertCursorTool.FollowMouse = true;
			horizCursorTool.FollowMouse = true;
			
			annVert.Shape.Shadow.Visible = false;
			annVert.Shape.Pen.Visible = false;
			annVert.Shape.Color = ColorTranslator.FromHtml("#8F8F8F");
			annVert.Shape.Font.Color = Color.WhiteSmoke;
			annVert.Shape.Font.Name= "Tahoma";
			annVert.Shape.Font.Size = 8;

			annHoriz.Shape.Shadow.Visible = false;
			annHoriz.Shape.Pen.Visible = false;
			annHoriz.Shape.Color = ColorTranslator.FromHtml("#8F8F8F");
			annHoriz.Shape.Font.Color = Color.WhiteSmoke;
			annHoriz.Shape.Font.Name = "Tahoma";
			annHoriz.Shape.Font.Size = 8;

			
			vertCursorTool.Change += VertCursorTool_Change;
			horizCursorTool.Change += HorizCursorTool_Change;

			scrollPager1.Chart = tChart1.Chart;
			ConfigureSmoothing();
			tChart1.Draw();

			Steema.TeeChart.TChart ch = scrollPager1.SubChartTChart;
			scrollPager1.SubChartTChart.Panel.Pen.Visible = false;
			scrollPager1.ColorBandTool.DrawBehind = false;
			scrollPager1.ColorBandTool.Pen.Visible = false;


			ch.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
			ch.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			ch.Axes.Bottom.Labels.Font.Name = "Tahoma";
			ch.Axes.Left.Labels.Font.Name = "Tahoma";
			ch.Axes.Left.Labels.Font.Size = 8;
			ch.Axes.Bottom.Labels.Font.Size = 8;
			ch.Panel.MarginUnits = Steema.TeeChart.PanelMarginUnits.Percent;
			ch.Panel.MarginLeft = 5;

			tChart1.MouseDown += TChart1_MouseDown;
			tChart1.MouseUp += TChart1_MouseUp;
			tChart1.MouseMove += TChart1_MouseMove;
			tChart1.Axes.Automatic = true;
			
			tChart1.Draw();
			ch.Draw();

			//-----------TChart2 (BarSeries) Init-----------//
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(tChart2.Chart, BlueFlatPalette);
			tChart2.Axes.Bottom.Labels.Font.Name = "Tahoma";
			tChart2.Axes.Left.Labels.Font.Name = "Tahoma";

			tChart2.Axes.Left.Labels.Font.Size = 8;
			tChart2.Axes.Bottom.Labels.Font.Size = 8;

			//Margins
			tChart2.Panel.MarginUnits = Steema.TeeChart.PanelMarginUnits.Percent;
			tChart2.Panel.MarginLeft = 5;
			startYr = 2000;
			endYr = 2015;
			refreshContinentYearRange("2005", "2010");

			tChart2.ClickSeries += TChart2_ClickSeries;
			(tChart2[0] as Steema.TeeChart.Styles.Bar).GetBarStyle += bar1_GetBarStyle;
			(tChart2[1] as Steema.TeeChart.Styles.Bar).GetBarStyle += bar2_GetBarStyle;

			tChart2.Draw();

			//-----------TChart3 (DonutSeries) Init-----------//
			donut1.Brush.Solid = true;
			tChart3.ClickSeries += TChart3_ClickSeries;
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(tChart3.Chart, BlueFlatPalette);
			donut1.AutoPenColor = false;
			donut1.Pen.Color = Color.White;
			donut1.Pen.Width = 3;
			donut1.Marks.Transparent = true;
			donut1.Marks.Font.Bold = true;
			donut1.Marks.FontSeriesColor = true;

			donut1.Marks.Arrow.DrawingPen.Color = Color.Black;
			refreshRegionChart("AS");
			tChart3.Draw();

			//-----------TChart4 MapWorld Init-----------//
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(tChart4.Chart, BlueFlatPalette);
			world1.UsePalette = true;
			world1.UseColorRange = false;
			first = true;

			//-----------Create Country ID Table-----------//
			CountryCodeTable = new DataTable();
			DataColumn Sales = new DataColumn("ValueSales", typeof(double));
			DataColumn ID = new DataColumn("ID", typeof(string));
			CountryCodeTable.Columns.Add(Sales);
			CountryCodeTable.Columns.Add(ID);

			FillMapValues();
			FillMapCountryData();

			world1.Color = BlueFlatPalette[3];
			world1.Click += World1_Click;
			tChart4.AfterDraw += TChart4_AfterDraw;
			tChart4.Resize += TChart4_Resize;
		
			tChart4.Refresh();
			tChart4.Refresh();
			tChart4.Refresh();

			gStartYear = (int)(tChart2.Axes.Bottom.Minimum);
			gEndYear = (int)(tChart2.Axes.Bottom.Maximum);
			
			//-----------TeeGrid Init-----------//
			Steema.TeeGrid.Themes.GridThemes.BlueFlat.ApplyTo(this.TeeGrid1.Grid);
			TeeGrid1.Rows.Alternate.Visible = false;
			RefreshGrid("2005", "2010");


			//-----------Creat Animations-----------//
			CreateAnimations();

		}

	
		private void World1_Click(object sender, MouseEventArgs e)
		{

			int idx = world1.Clicked(e.X, e.Y);
			if (idx != -1)
			{
				this.Text = world1.Labels[idx];
				this.Text = world1.Shapes[idx].Index.ToString();
				string ContName = GetContinentFromCountry(world1.Labels[idx]);
				if (ContName == "AN")
				{
					ContName = "SA";
				}
		

				refreshRegionChart(ContName);
				(tChart3[0] as Steema.TeeChart.Styles.Donut).AngleSize = 0;
				setBottomChartIndex(ValueIndexCountry);
				DonutTimer.Enabled = true;
				DonutTimer.Start();
			}

		
		}

		//Configuration Smoothing
		private void ConfigureSmoothing()
		{
			tChart1.Draw();
			SmoothingArea = new Steema.TeeChart.Styles.Area(tChart1.Chart);
			SmoothingFunc = new Steema.TeeChart.Functions.Smoothing();
			SmoothingArea.DataSource = area1;
			SmoothingArea.Function = SmoothingFunc;
			SmoothingArea.Color = area1.Color;
			SmoothingArea.AreaLines.Visible = false;
			SmoothingArea.LinePen.Visible = false;
			scrollPager1.Series = SmoothingArea;
			scrollPager1.Series.Color = BlueFlatPalette[0];
			area1.Visible = false;


		}
		//Get Total Sales
		private void GetTotalSales()
		{

			string sqlStr = "SELECT Sum(Fact_Invoices.Invoice_Value) AS SumOfInvoice_Value";
			sqlStr += " FROM((Lookup_Continent INNER JOIN Lookup_Country ON Lookup_Continent.continent = Lookup_Country.Continent) INNER JOIN Lookup_Customers ON Lookup_Country.Country_code_A2 = Lookup_Customers.Country_code_A2) INNER JOIN Fact_Invoices ON Lookup_Customers.Cod_Customer = Fact_Invoices.Cod_Customer";

			DataSet TotalSalesData = new DataSet();

			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.___SalesByCountryTableAdapter.Connection);
			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter());
			myAdapter.Fill(TotalSalesData, "TotalSales");

			DataTable TotalSalesTable = TotalSalesData.Tables[0].Columns["SumOfInvoice_Value"].Table;
			LBTotalSales.Text = Convert.ToDouble(TotalSalesTable.Rows[0][0]).ToString("C", nfi);
		}
		//Get Total  Items Sold
		private void GetTotalItemsSold()
		{
			string sqlStr = "SELECT Sum(Lookup_ProductPacks.Pack_Qty) AS SumOfPack_Qty";
			sqlStr += " FROM Lookup_ProductPacks INNER JOIN(Lookup_Dates INNER JOIN Fact_Orders ON Lookup_Dates.adate = Fact_Orders.Orderdate) ON Lookup_ProductPacks.Pack_code = Fact_Orders.Pack_code";


			DataSet TotalItemsSoldData = new DataSet();

			System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"..\\..\\..\\TechProductsLtd.mdb\"");
			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, connection);
			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter());
			myAdapter.Fill(TotalItemsSoldData, "TotalItemsSold");


			DataTable TotalSalesTable = TotalItemsSoldData.Tables[0].Columns["SumOfPack_Qty"].Table;
			LBTotalItemsSold.Text = Convert.ToDouble(TotalSalesTable.Rows[0][0]).ToString("C", nfi);

		}
		//Get Total Sales By Country Bentween Years
		private double GetTotalSalesByCountryBetween(string Acountry, string startYear, string endYear)
		{
			activeCountry = Acountry;
			string sqlStr = "SELECT Sum(Fact_Invoices.Invoice_Value) AS SumOfInvoice_Value";
			sqlStr += " FROM((Lookup_Continent INNER JOIN Lookup_Country ON Lookup_Continent.continent = Lookup_Country.Continent) INNER JOIN Lookup_Customers ON Lookup_Country.Country_code_A2 = Lookup_Customers.Country_code_A2) INNER JOIN Fact_Invoices ON Lookup_Customers.Cod_Customer = Fact_Invoices.Cod_Customer";
			sqlStr += " WHERE(((Fact_Invoices.Invoice_year) >= 2010 And(Fact_Invoices.Invoice_year) <= 2015))";
			sqlStr += " GROUP BY Lookup_Country.Country_name";
			sqlStr += " HAVING Lookup_Country.Country_name = @Acountry;";


			DataSet countrySalesBtwData = new DataSet();

			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.___SalesByCountryTableAdapter.Connection);

			//apply region code
			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter("Acountry", activeCountry));
			myAdapter.SelectCommand.Parameters.Insert(1, new System.Data.OleDb.OleDbParameter("startYear", startYr));
			myAdapter.SelectCommand.Parameters.Insert(2, new System.Data.OleDb.OleDbParameter("endYear", endYr));
			myAdapter.Fill(countrySalesBtwData, "countrySalesBtwD");


			DataTable countrySalesBtwD = countrySalesBtwData.Tables[0].Columns["SumOfInvoice_Value"].Table;
			if (countrySalesBtwD.Rows.Count != 0)
			{
				return Convert.ToDouble(countrySalesBtwD.Rows[0][0]);
			}
			return 0;
		
		}
		//Update Total Sales By country Between Labels
		private void UpdateTotalSalesByCountryBetweenLabels(String Acountry, string AStart, string AEnd)
		{
			LBTotalSalesCountryBT.Text = "Total Sales in" + "\n" + Acountry;
			LBBetween.Text = "between " + AStart + " and " + AEnd;
			LBTotalSalesCountryBTValue.Text = GetTotalSalesByCountryBetween(Acountry, AStart, AEnd).ToString("C", nfi);
		}

		private void RefreshGrid(string startYear, string endYear)
		{

			string sqlStr = "SELECT Fact_Orders.ID, Fact_Orders.Cod_Customer, Fact_Orders.Orderdate, Fact_Orders.Invoice_year, Fact_Orders.Invoice_num, Fact_Orders.Product_code, Fact_Orders.Pack_code";
			sqlStr += " FROM Fact_Invoices INNER JOIN Fact_Orders ON(Fact_Invoices.Invoice_num = Fact_Orders.Invoice_num) AND(Fact_Invoices.Invoice_year = Fact_Orders.Invoice_year)";
			sqlStr += " WHERE(((Fact_Invoices.Invoice_year)>=@startYear And (Fact_Invoices.Invoice_year)<= @endYear))";
			sqlStr += " GROUP BY Fact_Orders.ID, Fact_Orders.Cod_Customer, Fact_Orders.Orderdate, Fact_Orders.Invoice_year, Fact_Orders.Invoice_num, Fact_Orders.Product_code, Fact_Orders.Pack_code";


			DataSet Invoice_yearsData = new DataSet();

			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.fact_OrdersTableAdapter.Connection);

			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter("startYear", startYr));
			myAdapter.SelectCommand.Parameters.Insert(1, new System.Data.OleDb.OleDbParameter("endYear", endYr));
			myAdapter.Fill(Invoice_yearsData, "years");

			System.Windows.Forms.BindingSource bindFactYears;

			bindFactYears = new BindingSource();
			bindFactYears.DataSource = Invoice_yearsData;
			bindFactYears.DataMember = Invoice_yearsData.Tables[0].ToString();


			TeeGrid1.DataSource = bindFactYears;
			TeeGrid1.Refresh();

			TeeGrid1.Columns[0].Header.Text = "ID";
			TeeGrid1.Columns[1].Header.Text = "Cod_Customer";
			TeeGrid1.Columns[2].Header.Text = "Orderdate";
			TeeGrid1.Columns[3].Header.Text = "Invoice_year";
			TeeGrid1.Columns[4].Header.Text = "Invoice_num";
			TeeGrid1.Columns[5].Header.Text = "Product_code";
			TeeGrid1.Columns[6].Header.Text = "Pack_code";



		}
		private string GetContinentFromCountry(string Acountry)
		{
			if (Acountry != null)
			{
				activeCountry = Acountry;
				//as it will be useful for all sold-to countries appear in the Pie, even if no sales were made in 2015
				//	string sqlStr = "SELECT Lookup_Country.Country_name, Lookup_Continent.continent FROM Lookup_Continent INNER JOIN Lookup_Country ON Lookup_Continent.continent = Lookup_Country.Continent";
				string sqlStr = "SELECT Lookup_Country.Continent";
				sqlStr += " FROM Lookup_Country";
				sqlStr += " WHERE (((Lookup_Country.Country_name) = @Acountry));";

				DataSet continentIDData = new DataSet();
				System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.lookup_CountryTableAdapter.Connection);

				myAdapter.SelectCommand.Parameters.Clear();
				myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter("Acountry", activeCountry));
				myAdapter.Fill(continentIDData, "continentID");

				DataTable continentsID = continentIDData.Tables[0].Columns["continent"].Table;

				
				if (continentsID.Rows.Count == 0)
				{
					if (Acountry.ToUpper() == "VIETNAM" || Acountry.ToUpper() == "LAOS" || Acountry.ToUpper() == "BURMA" || Acountry.ToUpper() == "NORTH KOREA" || Acountry.ToUpper() == "SOUTH KOREA" || Acountry.ToUpper() == "IRAN" ||
						Acountry.ToUpper() == "IRAK" || Acountry.ToUpper() == "SYRIA" || Acountry.ToUpper() == "BUTHAN" || Acountry.ToUpper() == "TAIWAN")
					{
						return "AS";
					}
					else if (Acountry.ToUpper() == "YUGOSLAVIA" || Acountry.ToUpper() == "MACEDONIA" || Acountry.ToUpper() == "MOLDOVA")
					{
						return "EU";
					}
					else if (Acountry.ToUpper() == "ZAIRE" || Acountry.ToUpper() == "TANZANIA" || Acountry.ToUpper() == "CENTRAL AFRICA REPUBLIC" || Acountry.ToUpper() == "LYBIA" || Acountry.ToUpper() == "SIERRA LEONA" || Acountry.ToUpper() == "IVORY COAST")
					{
						return "AF";
					}
					else if (Acountry.ToUpper() == "GREENLAND (DENMARK)")
					{
						return "NA";
					}
					else if ((Acountry.ToUpper() == "RUSSIA") || (Acountry.ToUpper() == "UK"))
					{
						return "EU";
					}
					else if (Acountry.ToUpper() == "")
					{
						return "EU";
					}
					else //other country (?)
						return "EU";
				}

				return continentsID.Rows[0]["continent"].ToString();
			}
			return "UE";
		}

		private void refreshContinentYearRange(string startYear, string endYear)
		{

			//as it will be useful for all sold-to countries appear in the Pie, even if no sales were made in 2015
			string sqlStr = "SELECT Sum(Fact_Invoices.Invoice_Value) AS SumOfInvoice_Value, Lookup_Continent.continent_name AS continame";
			sqlStr += " FROM ((Lookup_Continent INNER JOIN Lookup_Country ON Lookup_Continent.continent = Lookup_Country.Continent)";
			sqlStr += " INNER JOIN Lookup_Customers ON Lookup_Country.Country_code_A2 = Lookup_Customers.Country_code_A2)";
			sqlStr += " INNER JOIN Fact_Invoices ON Lookup_Customers.Cod_Customer = Fact_Invoices.Cod_Customer";
			sqlStr += " WHERE (Fact_Invoices.Invoice_year >= @startYear) and (Fact_Invoices.Invoice_year <= @endYear)";
			sqlStr += " GROUP BY Lookup_Continent.continent_name;";


			DataSet continentyears = new DataSet();

			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.___SalesByCountry_2015TableAdapter.Connection);

			//apply region code
			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter("startYear", startYear));
			myAdapter.SelectCommand.Parameters.Insert(1, new System.Data.OleDb.OleDbParameter("endYear", endYear));
			myAdapter.Fill(continentyears, "contiyrs");

			System.Windows.Forms.BindingSource bindContYears;

			bindContYears = new BindingSource();
			bindContYears.DataSource = continentyears;
			bindContYears.DataMember = continentyears.Tables[0].ToString();

			tChart2[1].DataSource = bindContYears;
			tChart2[1].YValues.DataMember = "SumOfInvoice_Value";
			tChart2[1].LabelMember = "continame";

			tChart2[0].CheckDataSource();
			tChart2[1].CheckDataSource();
		}


		private void refreshCountryYear(string country)
		{
			activeCountry = country;
			//setup the data query for the country table to get all available year data to better see trend
			string sqlStr = "SELECT Sum(Fact_Invoices.Invoice_Value)AS SumOfInvoice_Value, Fact_Invoices.Invoice_year AS AYear, Lookup_Country.Country_name";
			sqlStr += " FROM(Lookup_Customers INNER JOIN Fact_Invoices ON Lookup_Customers.Cod_Customer = Fact_Invoices.Cod_Customer)";
			sqlStr += " INNER JOIN Lookup_Country ON Lookup_Customers.Country_code_A2 = Lookup_Country.Country_code_A2";
			sqlStr += " WHERE Lookup_Country.Country_name = @country";
			sqlStr += " GROUP BY Fact_Invoices.Invoice_year, Lookup_Country.Country_name";

			DataSet customer = new DataSet();

			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.___SalesByCountry_2015TableAdapter.Connection);

			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter("country", activeCountry));
			myAdapter.Fill(customer, "spec_customer");

			System.Windows.Forms.BindingSource bindCountryYear;

			bindCountryYear = new BindingSource();
			bindCountryYear.DataSource = customer;
			bindCountryYear.DataMember = customer.Tables[0].ToString();

			//set Series data source
			tChart1[0].DataSource = bindCountryYear;
			tChart1[0].YValues.DataMember = "SumOfInvoice_Value";
			tChart1[0].XValues.DataMember = "AYear";
			tChart1[0].XValues.Modified = true;

			tChart1[0].CheckDataSource();
			tChart1[1].CheckDataSource();
			scrollPager1.SubChartTChart.Chart[0].CheckDataSource();

			tChart1.Axes.Bottom.Increment = 1;
			scrollPager1.SubChartTChart.Axes.Bottom.Increment = 1;

			setComments(commentType.country);
		}

		private void setComments(commentType cType)
		{
			//Mockup of an auto-commentary system, add comments from range according to data performance
			bool up201314 = tChart1[0].YValues.Count > 2 ? tChart1[0].YValues.Value[tChart1[0].Count - 2] > tChart1[0].YValues.Value[tChart1[0].Count - 3] : false;
			bool up201415 = tChart1[0].YValues.Count > 2 ? tChart1[0].YValues.Last > tChart1[0].YValues[tChart1[0].Count - 2] : false;

			//textBox1.Clear();

			string[] comments = new string[10];

			int offset = 0;
			bool aboutCountry = false;

			switch (cType)
			{
				case commentType.global:
					comments[0] = "Overall situation";
					comments[1] = "";
					comments[2] = "Total sales summed are $" + tChart2[0].YValues.TotalABS.ToString("{0,0}");
					break;
				case commentType.regional:
					comments[0] = "From " + activeRegion;
					aboutCountry = true;
					offset = 3;
					break;
				case commentType.country:
					aboutCountry = true;
					break;
			}

			if ((aboutCountry) && (activeCountry.ToLower() != "other"))
			{
				comments[0 + offset] = "Results for " + activeCountry;
				if ((up201314) && (!up201415))
				{
					comments[2 + offset] = "Despite an upturn in 2014 results were disappointing as 2014 moved into 2015.";
					comments[3 + offset] = "";
				}
				else if ((!up201314) && (up201415))
				{
					comments[2 + offset] = "Last year's results were very encouraging as the downward trend of 2014 was turned-around for a positive beginning to 2015";
					comments[3 + offset] = "";
				}
				else if ((up201314) && (up201415))
				{
					comments[2 + offset] = "Good progress in 2014 was consolidated for for a positive beginning to 2015.";
					comments[3 + offset] = "";
				}
				else if ((!up201314) && (!up201415))
				{
					comments[2 + offset] = "The slide for " + activeCountry + " hasn't been corrected yet; work is being done to bring the market into line for the current year";
					comments[3 + offset] = "";
				}
			}

			comments[4 + offset] = "";

			comments[5 + offset] = "";
			if (cType == commentType.global)
				comments[6 + offset] = "Dollar has strengthened, supporting return currency conversion.";
		}


		private void refreshRegionChart(string region)
		{
			activeRegion = region;

			//as it will be useful for all sold-to countries appear in the Pie, even if no sales were made in 2015
			string sqlStr = "SELECT Sum(Fact_Invoices.Invoice_Value) AS SumOfInvoice_Value, Lookup_Country.Country_name AS country_name, Lookup_Continent.continent_name, Lookup_Continent.continent";
			sqlStr += " FROM(Lookup_Continent INNER JOIN(Lookup_Country INNER JOIN Lookup_Customers ON Lookup_Country.Country_code_A2 = Lookup_Customers.Country_code_A2) ON Lookup_Continent.continent = Lookup_Country.Continent)";
			sqlStr += " INNER JOIN Fact_Invoices ON Lookup_Customers.Cod_Customer = Fact_Invoices.Cod_Customer";
			sqlStr += " WHERE Lookup_Continent.continent = @region";
			sqlStr += " GROUP BY Lookup_Country.Country_name, Lookup_Continent.continent_name, Lookup_Continent.continent";

			DataSet customers = new DataSet();

			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.___SalesByCountry_2015TableAdapter.Connection);

			//apply region code
			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter("region", activeRegion));
			myAdapter.Fill(customers, "Customers");

			System.Windows.Forms.BindingSource bindContinent = new BindingSource();

			bindContinent.DataSource = customers;
			bindContinent.DataMember = customers.Tables[0].ToString();

			tChart3[0].DataSource = bindContinent;

			tChart3[0].YValues.DataMember = "SumOfInvoice_Value";
			tChart3[0].LabelMember = "country_name";

			tChart3[0].CheckDataSource();
			setHighestValueHistory();
		}
		
			private void FillMapCountryData()
		{
			Double Svalue;
			string countryName;
			//as it will be useful for all sold-to countries appear in the Pie, even if no sales were made in 2015
			string sqlStr = "SELECT Sum(Fact_Invoices.Invoice_Value) AS SumOfInvoice_Value, Lookup_Country.Country_name, Lookup_Continent.continent_name, Lookup_Country.Country_code_A2";
			sqlStr += " FROM ((Lookup_Continent INNER JOIN Lookup_Country ON Lookup_Continent.continent = Lookup_Country.Continent) INNER JOIN Lookup_Customers ON Lookup_Country.Country_code_A2 = Lookup_Customers.Country_code_A2)";
			sqlStr += " INNER JOIN Fact_Invoices ON Lookup_Customers.Cod_Customer = Fact_Invoices.Cod_Customer";
			sqlStr += " GROUP BY Lookup_Country.Country_name, Lookup_Continent.continent_name, Lookup_Country.Country_code_A2";


			DataSet country = new DataSet();

			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.___SalesByCountryTableAdapter.Connection);


			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter());
			myAdapter.Fill(country, "countrySales");

			DataTable countryBySalesName = country.Tables[0];
			
			int idx = 0;
			while (idx <= countryBySalesName.Rows.Count - 1)
			{
				Svalue = Convert.ToDouble(countryBySalesName.Rows[idx]["SumOfInvoice_Value"].ToString());
				countryName = countryBySalesName.Rows[idx]["Country_Name"].ToString();
				if (countryName == "United Kingdom")
				{
					countryName = "UK";
				}
				else if (countryName == "Korea, Republic of")
				{
					countryName = "South Korea";
				}
				//-----------Save the Country Code-----------//
				DataRow newRow = CountryCodeTable.NewRow();
				newRow["ValueSales"] = Convert.ToDouble(countryBySalesName.Rows[idx]["SumOfInvoice_Value"].ToString());
				newRow["ID"] = countryBySalesName.Rows[idx]["Country_code_A2"].ToString();
				CountryCodeTable.Rows.Add(newRow);

				for (int i = 0; i < world1.Count; ++i)
				{
					if (world1.Labels[i].ToUpper() == countryName.ToUpper())
					{
						world1.ZValues[i] = Svalue;
					}
				}
				idx++;
			}
		}

		private void FillMapValues()
		{
			// var
			int r;
			string country, continentPref;

			string sqlStr = "SELECT Lookup_Country.Country_name, Lookup_Country.Continent";
			sqlStr += " FROM Lookup_Country";
			sqlStr += " GROUP BY Lookup_Country.Country_name, Lookup_Country.Continent;";

			DataSet countryNameData = new DataSet("countryName");
			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.lookup_CountryTableAdapter.Connection);

			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter());
			myAdapter.Fill(countryNameData, "countryname");


			DataTable countryName = countryNameData.Tables[0].Columns["Country_name"].Table;
			DataTable continents = countryNameData.Tables[0].Columns["continent"].Table;

			r = 0;
			while (r <= continents.Rows.Count - 1)
			{
				country = countryName.Rows[r]["Country_name"].ToString();
				continentPref = continents.Rows[r]["continent"].ToString();
				if (country == "Russian Federation")
				{
					country = "Russia";
				}
				else if (country == "United Kingdom")
				{
					country = "UK";
				}

				for (int i = 0; i < world1.Shapes.Count; i++)
				{
					if (world1.Labels[i].ToUpper() == country.ToUpper() || world1.Labels[i].Contains(country))
					{
						switch (continentPref)
						{
							case "AF":
								world1.Colors[i] = BlueFlatPalette[0];
								break;
							case "AN":
								world1.Colors[i] = BlueFlatPalette[1];
								break;
							case "AS":
								world1.Colors[i] = BlueFlatPalette[2];
								break;
							case "EU":
								world1.Colors[i] = BlueFlatPalette[3];
								break;
							case "NA":
								world1.Colors[i] = BlueFlatPalette[4];
								break;
							case "OC":
								world1.Colors[i] = BlueFlatPalette[5];
								break;
							case "SA":
								world1.Colors[i] = BlueFlatPalette[6];
								break;
						}
					}
					else
					{
						if(world1.Labels[i].ToUpper()== "LAOS" || world1.Labels[i].ToUpper()== "BURMA" || world1.Labels[i].ToUpper() == "VIETNAM" || world1.Labels[i].ToUpper()== "NORTH KOREA" || world1.Labels[i].ToUpper() == "SOUTH KOREA"|| world1.Labels[i].ToUpper()== "IRAN" ||
							world1.Labels[i].ToUpper() == "IRAK" || world1.Labels[i].ToUpper()== "SYRIA" || world1.Labels[i].ToUpper() == "BUTHAN" || world1.Labels[i].ToUpper() == "TAIWAN" )
						{
							//ASIA 
							world1.Colors[i] = BlueFlatPalette[2];
						}
						else if(world1.Labels[i].ToUpper()== "YUGOSLAVIA" || world1.Labels[i].ToUpper() == "MACEDONIA" || world1.Labels[i].ToUpper() == "MOLDOVA")
						{
							//EUROPE
							world1.Colors[i] = BlueFlatPalette[3];
						}
						else if(world1.Labels[i].ToUpper() == "ZAIRE" || world1.Labels[i].ToUpper() == "TANZANIA" || world1.Labels[i].ToUpper() == "CENTRAL AFRICA REPUBLIC" || world1.Labels[i].ToUpper() == "LYBIA" || 
							world1.Labels[i].ToUpper()== "SIERRA LEONA" || world1.Labels[i].ToUpper() =="IVORY COAST")
						{
							//AFRICA
							world1.Colors[i] = BlueFlatPalette[0];
						}
						else if (world1.Shapes[i].Index == 74)
						{
							//ANTARCTICA
							world1.Colors[i] = BlueFlatPalette[7];
							world1.Labels[i] = "ANTARCTICA"; 
						}
						else if (world1.Labels[i]== "")
						{
							world1.Colors[i] = BlueFlatPalette[0];
						}
					}
				}
				r++;
			}
		}
		//Create Animations Init
		private void CreateAnimations()
		{
			// Bar Chart Animation
			BarAnimation = new Steema.TeeChart.Animations.ChartPartAnimation(tChart2.Chart);
		  BarAnimation.EasingFunction = new Steema.TeeChart.Animations.EasingFunctions.Linear();
			BarAnimation.EasingMode = Steema.TeeChart.Animations.EasingFunctions.EasingMode.EaseIn;
			BarAnimation.Target = Steema.TeeChart.ChartClickedPartStyle.Series;
		  BarAnimation.TranslateStyle = Steema.TeeChart.Animations.TransformTranslate.FromBottom;

			// Donut Chart Animation
			DonutTimer.Tick += DonutTimer_Tick;
			DonutTimer.Interval = 5;
			DonutTimer.Enabled = false;
			DonutTimer.Stop();

		}

		private void DonutTimer_Tick(object sender, EventArgs e)
		{
			if ((tChart3[0] as Steema.TeeChart.Styles.Donut).AngleSize <= 360)
			{
				(tChart3[0] as Steema.TeeChart.Styles.Donut).AngleSize = (tChart3[0] as Steema.TeeChart.Styles.Donut).AngleSize + 5;
			}
			else
			{
				DonutTimer.Stop();
				DonutTimer.Enabled = false;
				AnimateBarChart();
			}
		}

		private void AnimateBarChart()
		{
				BarAnimation.Play();
		}

		private void TChart1_MouseUp(object sender, MouseEventArgs e)
		{
			if (DoScroll)
			{
				{
					startYr = (int)Math.Round(tChart1.Axes.Bottom.Minimum);
					endYr = (int)Math.Round(tChart1.Axes.Bottom.Maximum);

					if ((startYr != gStartYear) || (endYr != gEndYear))
					{

						refreshContinentYearRange(startYr.ToString(), endYr.ToString()); //BarChart
						RefreshGrid(startYr.ToString(), endYr.ToString());//TeeGrid
						//-----Update Country BetweenLabels------//
						UpdateTotalSalesByCountryBetweenLabels(tChart3[0].Labels[ValueIndexCountry], startYr.ToString(), endYr.ToString());

						gStartYear = startYr;
						gEndYear = endYr;
					}
				}
			}

			DoScroll = false;
		}

		private void TChart1_MouseDown(object sender, MouseEventArgs e)
		{
			DoScroll = true;
		}

		//Enable or disable cursor and annotation tools. 
		private void TChart1_MouseMove(object sender, MouseEventArgs e)
		{
			if (scrollPager1.ColorBandTool.Clicked(e.X, e.Y))
			{
				annHoriz.Active = false;
				annVert.Active = false;
				vertCursorTool.Active = false;
				horizCursorTool.Active = false;
			}
			else
			{
				annHoriz.Active = true;
				annVert.Active = true;
				vertCursorTool.Active = true;
				horizCursorTool.Active = true;
			}
		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
		{
			if (!tChart1Loaded)
			{
				if (scrollPager1 != null)
				{
					scrollPager1.ColorBandTool.Start = 2005;
					scrollPager1.ColorBandTool.End = 2010;
				}
				tChart1Loaded = true;
			
			}
		}
		private void VertCursorTool_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
		{
			annVert.PositionUnits = Steema.TeeChart.PositionUnits.Pixels;
			annVert.Left = tChart1.Axes.Bottom.CalcXPosValue(e.XValue) - e.XValue.ToString("##.###").Length;
			annVert.Top = tChart1.Axes.Bottom.Position;
			annVert.Text = e.XValue.ToString("##.###");
		}

		private void HorizCursorTool_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
		{
			annHoriz.PositionUnits = Steema.TeeChart.PositionUnits.Pixels;
			annHoriz.Left = tChart1.Axes.Left.Position;
			annHoriz.Top = tChart1.Axes.Left.CalcYPosValue(e.YValue) - e.YValue.ToString("##.###").Length;
			annHoriz.Text = e.YValue.ToString("##.###");
		}

		private void TChart2_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, MouseEventArgs e)
		{
			IndexBarClicked = valueIndex;
			BarSeriesClicked = s;
			tChart2.Refresh();
		}

		private void bar1_GetBarStyle(Steema.TeeChart.Styles.CustomBar sender, Steema.TeeChart.Styles.CustomBar.GetBarStyleEventArgs e)
		{
			Color oldcolor = sender.Color;
			if ((e.ValueIndex == IndexBarClicked) && (BarSeriesClicked == sender))
			{
				e.Style = Steema.TeeChart.Styles.BarStyles.Bevel;
				sender[e.ValueIndex].Color = BlueFlatPalette[5];
			}
			else
			{
				e.Style = Steema.TeeChart.Styles.BarStyles.Rectangle;// := TBarStyle.bsRectangle;
				sender[e.ValueIndex].Color = oldcolor;
			}
		}

		private void bar2_GetBarStyle(Steema.TeeChart.Styles.CustomBar sender, Steema.TeeChart.Styles.CustomBar.GetBarStyleEventArgs e)
		{

			Color oldcolor = sender.Color;
			if ((e.ValueIndex == IndexBarClicked) && (BarSeriesClicked == sender))
			{
				e.Style = Steema.TeeChart.Styles.BarStyles.Bevel;
				sender[e.ValueIndex].Color = BlueFlatPalette[5];
			}
			else
			{
				e.Style = Steema.TeeChart.Styles.BarStyles.Rectangle;// := TBarStyle.bsRectangle;
				sender[e.ValueIndex].Color = oldcolor;
			}
		}

		private void TChart3_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, MouseEventArgs e)
		{
			if (valueIndex != -1)
				setBottomChartIndex(valueIndex);
		}


		private void TChart4_Resize(object sender, EventArgs e)
		{
			tChart4.Refresh();
			tChart4.Refresh();
		}

		private void TChart4_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
		{
			tChart4[0].IsoHorizAxes = true;
		}

		private void setHighestValueHistory()
		{
			//tChart3 -> DonutChart
			int maxIdx = 0;
			for (int i = 0; i < tChart3[0].Count; i++)
			{
				if (tChart3[0].MaxYValue() == tChart3[0].YValues[i])
				{
					maxIdx = i;
					break;
				}
			}
			setBottomChartIndex(maxIdx);
		}

		// Fill specific Data to Area Chart by using the Country selected on Donut Series---//
		private void setBottomChartIndex(int valueIndex)
		{
			//TChart1->AreaChart and TChart3->DonutChart
			if (valueIndex != -1)
			{
				tChart1[0].Color = tChart3[0].ValueColor(valueIndex);
				tChart1[1].Color = tChart3[0].ValueColor(valueIndex);

				scrollPager1.Series.Color = tChart3[0].ValueColor(valueIndex);
				refreshCountryYear(tChart3[0].Labels[valueIndex]);
				ValueIndexCountry = valueIndex;
				//----Set Total Sales Values---///

				// Change the Area Chart title
				tChart1.Header.Text = "Sales by Country : " + tChart3[0].Labels[valueIndex];

				label4.Text = "Total Sales in" + "\n" + tChart3[0].Labels[valueIndex].ToString();
				LBTotalSalesCountryValue.Text = tChart3[0].YValues[valueIndex].ToString("C", nfi);
				UpdateTotalSalesByCountryBetweenLabels(tChart3[0].Labels[valueIndex], startYr.ToString(), endYr.ToString());

				TeeGrid1.Selected.Row = valueIndex;
				vertCursorTool.XValue = tChart3[0].XValues[valueIndex];
				horizCursorTool.YValue = tChart3[0].YValues[valueIndex];
			}
		}

    private void Export_Click(object sender, EventArgs e)
    {
      XmlDashBoard ImportFromXML(string path)
      {
        XmlDashBoard dashBoard = null;
        XmlSerializer serializer = new XmlSerializer(typeof(XmlDashBoard));
        using (XmlTextReader reader = new XmlTextReader(path))
        {
          dashBoard = serializer.Deserialize(reader) as XmlDashBoard;
        }
        return dashBoard;
      }

      string xmlPath = @"..\..\web\dashboard\dashboard.xml";
      ExportToXML(xmlPath);

      XmlDashBoard dash = ImportFromXML(xmlPath);

      DashExportWeb dashWeb = new DashExportWeb(dash);
      dashWeb.Save(@"..\..\web\dashboard");
    }

    public void ExportToXML(string path)
    {
      XmlDashBoard dashBoard = new XmlDashBoard();

      string GetChartContent(TChart chart)
      {
        JavascriptFormat jsformat = chart.Export.Image.JScript;
        jsformat.DoFullPage = false;
        jsformat.CanvasName = chart.Name;
        string result = null;
        using (MemoryStream stream = new MemoryStream())
        {
          jsformat.Save(stream);
          stream.Position = 0;
          using (StreamReader reader = new StreamReader(stream))
          {
            result = reader.ReadToEnd();
          }
        }

        result = result.Replace("cha  chart1", "chart1");
        return result;
      }

      string GetGridContent(TGrid grid)
      {
        HtmlExport htmlformat = grid.Export.Html;
        string result = null;
        using (MemoryStream stream = new MemoryStream())
        {
          htmlformat.Save(stream);
          stream.Position = 0;
          using (StreamReader reader = new StreamReader(stream))
          {
            result = reader.ReadToEnd();
          }
        }

        return result;
      }

      dashBoard.AddCell(tChart1.Name, 0, 1, 0, 2, CellType.Chart, GetChartContent(tChart1));
      dashBoard.AddCell(tChart2.Name, 0, 1, 2, 2, CellType.Chart, GetChartContent(tChart1));
      dashBoard.AddCell(tChart3.Name, 0, 1, 4, 2, CellType.Chart, GetChartContent(tChart1));

      dashBoard.AddCell(tChart4.Name, 1, 1, 3, 3, CellType.Chart, GetChartContent(tChart1));
      dashBoard.AddCell(TeeGrid1.Name, 1, 1, 0, 3, CellType.Grid, GetGridContent(TeeGrid1));

      dashBoard.Title = "My First Title";

      XmlSerializer serializer = new XmlSerializer(typeof(XmlDashBoard));
      using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
      {
        serializer.Serialize(writer, dashBoard);
      }
    }

  /*
  private void Export_Click(object sender, EventArgs e)
  {
    string data = Steema.TeeGrid.JSON.JSONData.From(TeeGrid1.Grid, true, null, true);

    string rootpath = @"..\..\web\dashboard\data";

    using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(rootpath + @"\TeeGrid.JSON"))
    {
      outputFile.WriteLine(data);
    }

    tChart1.Export.Data.JSON.IncludeColors = false;
    tChart2.Export.Data.JSON.IncludeColors = false;
    tChart3.Export.Data.JSON.IncludeColors = false;
    tChart4.Export.Data.JSON.IncludeColors = false;

    //MapChart
    ExportMapSeries(rootpath + @"\MapChart.JSON");
  //	tChart4.Export.Data.JSON.Save(rootpath + @"\MapChart.JSON");
    //AreaChart
    //tChart1.Export.Data.JSON.
    tChart1.Export.Data.JSON.Save(rootpath + @"\AreaChart.JSON");
    //BarChart
    tChart2.Export.Data.JSON.Save(rootpath + @"\BarChart.JSON");
    //DonutChart
    tChart3.Export.Data.JSON.Save(rootpath + @"\DonutChart.JSON");
    //Export Variables
    ExportIndicatorsData(rootpath + @"\Variables.js");
  }


  private void ExportIndicatorsData(string FileName)
  {
    using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName, false))
    {
      file.WriteLine("var aTotalsales = \""+LBTotalSales.Text + "\";");
      file.WriteLine("var aTotalitemssold = \""+ LBTotalItemsSold.Text + "\";");
      file.WriteLine("var aTotalsalesin = \"" + LBTotalSalesCountryValue.Text+"\";");
      file.WriteLine("var aTotalsalesinbetween = \"" + LBTotalSalesCountryBTValue.Text + "\";");
      file.WriteLine("var aCountry = \"" + activeCountry +"\";");
      file.WriteLine("var aStartyear = \"" + startYr.ToString()+"\";");
      file.WriteLine("var aEndyear = \"" + endYr.ToString()+"\";");
      file.Flush();
      file.Close();
    }  

    System.Diagnostics.Process.Start(@"http://localhost/dashboard/reports/index.html");
  }

  private void ExportMapSeries(string FileName)
  {
    //Var 
    double Zval;
    string CountryCode, oldCountry;
    CountryCode = "";
    oldCountry = ".";
    using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName, false, Encoding.ASCII))
    {
      file.WriteLine(" { \"" + "chart" + "\": [");
      file.WriteLine("  {");
      file.WriteLine("   \"" + "series" + "\":  {");
      file.WriteLine("   \"" + "name" + "\" :" + "\"" + "MapSeries" + "\",");
      file.WriteLine("   \"" + "color" + "\":" + "\"" + "#FFCCFFFF" + "\",");
      file.WriteLine("   \"" + "point" + "\": [");

      for (int i = 0; i < world1.Count; ++i)
      {
        Zval = world1.ZValues[i];

        if (Zval != 0)
        {

          if (oldCountry != world1.Labels[i])
          {
            oldCountry = world1.Labels[i];
            for (int idx = 0; idx < CountryCodeTable.Rows.Count; ++idx)
            {
              if (Zval == Convert.ToDouble(CountryCodeTable.Rows[idx]["ValueSales"]))
              {
                CountryCode = CountryCodeTable.Rows[idx]["ID"].ToString();
              }
            }

            if (first)
            {
              first = false;
            }
            else
            {
              file.WriteLine(",");
            }

            file.WriteLine("     { \"" + "value" + "\":" + world1.ZValues[i].ToString() + ", \"" + "x" + "\" :0, \"" + "name" + "\":\"" + world1.Labels[i] + "\" , \"" + "id" + "\":\"" + CountryCode + "\" }");
          }

        }
      }
      file.WriteLine("   ]");
      file.WriteLine("   }");
      file.WriteLine("  }");
      file.WriteLine(" ]");
      file.WriteLine("}");
      file.Flush();
      file.Close();
      first = true;
    }
  }

  */
  private void tChart2_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tChart2.ShowEditor();
		}
		private void tChart1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tChart1.ShowEditor();
		}

		private void tChart3_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tChart3.ShowEditor();
		}

		private void tChart4_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tChart4.ShowEditor();
		}
  }
}
