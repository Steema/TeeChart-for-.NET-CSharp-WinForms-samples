using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkingCharts
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

		public ReportForm()
		{
			InitializeComponent();
			this.BackColor = Color.White;
			TeeGrid.Themes.GridThemes.BlueFlat.ApplyTo(this.dataGridView1.Grid);
		}

		private void ReportForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'techProductsLtdDataSet1.___SalesByContinent' table. You can move, or remove it, as needed.
			this.___SalesByContinentTableAdapter.Fill(this.techProductsLtdDataSet1.___SalesByContinent);
			// TODO: This line of code loads data into the 'techProductsLtdDataSet1.___SalesByCountry_2015' table. You can move, or remove it, as needed.
			this.___SalesByCountry_2015TableAdapter.Fill(this.techProductsLtdDataSet1.___SalesByCountry_2015);
			// TODO: This line of code loads data into the 'techProductsLtdDataSet1._____SalesByYear' table. You can move, or remove it, as needed.
			this.____SalesByYearTableAdapter.Fill(this.techProductsLtdDataSet1._____SalesByYear);

			//test fill series
			//tChart1[0].FillSampleValues();
			//tChart2[0].FillSampleValues();
			//tChart3[0].FillSampleValues();

			//this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			this.dataGridView1.Selected.Changed += dataGridView1_Click;


			tChart1[0].CheckDataSource();  //country
			tChart2[0].CheckDataSource();  //continent
			tChart3[0].CheckDataSource();  //region

			tChart1.Panel.Gradient.Visible = true;

			setHighestValueHistory();

			setComments(commentType.global);
		}


		private System.Windows.Forms.BindingSource bindEurope;


		private void refreshCountryYear(string country)
		{

			//setup the data query for the country table to get all available year data to better see trend
			string sqlStr = "SELECT Sum(Fact_Invoices.Invoice_Value)AS SumOfInvoice_Value, Fact_Invoices.Invoice_year AS AYear, Lookup_Country.Country_name";
			sqlStr += " FROM(Lookup_Customers INNER JOIN Fact_Invoices ON Lookup_Customers.Cod_Customer = Fact_Invoices.Cod_Customer)";
			sqlStr += " INNER JOIN Lookup_Country ON Lookup_Customers.Country_code_A2 = Lookup_Country.Country_code_A2";
			sqlStr += " WHERE Lookup_Country.Country_name = @countryParam";
			sqlStr += " GROUP BY Fact_Invoices.Invoice_year, Lookup_Country.Country_name";

			DataSet customer = new DataSet();
			System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"..\\..\\..\\TechProductsLtd.mdb\"");
			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, connection);
			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter("countryParam", country));
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

			activeCountry = country;
			tChart1.Header.Text = activeCountry + ", Sales 2000-2015";

			tChart1.Axes.Bottom.Increment = 1;

			setComments(commentType.country);
		}

		private void setComments(commentType cType)
		{
			//Mockup of an auto-commentary system, add comments from range according to data performance
			bool up201314 = tChart1[0].YValues.Count > 2 ? tChart1[0].YValues.Value[tChart1[0].Count - 2] > tChart1[0].YValues.Value[tChart1[0].Count - 3] : false;
			bool up201415 = tChart1[0].YValues.Count > 2 ? tChart1[0].YValues.Last > tChart1[0].YValues[tChart1[0].Count - 2] : false;

			textBox1.Clear();

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

			textBox1.Lines = comments;

		}


		private void refreshRegionChart(string region)
		{
			activeRegion = region;

			//we won't use the original query as basis, data from 2015
			//string sqlStr = this.___SalesByCountry_2015TableAdapter.Adapter.SelectCommand.CommandText;
			//if (sqlStr.IndexOf("where") == -1)
			//sqlStr += " where Lookup_Continent.continent_name = @contiParam";

			//as it will be useful for all sold-to countries appear in the Pie, even if no sales were made in 2015
			string sqlStr = "SELECT Sum(Fact_Invoices.Invoice_Value) AS SumOfInvoice_Value, Lookup_Country.Country_name, Lookup_Continent.continent_name";
			sqlStr += " FROM((Fact_Invoices INNER JOIN Lookup_Customers ON Fact_Invoices.Cod_Customer = Lookup_Customers.Cod_Customer)";
			sqlStr += " INNER JOIN Lookup_Country ON Lookup_Customers.Country_code_A2 = Lookup_Country.Country_code_A2)";
			sqlStr += " INNER JOIN Lookup_Continent ON Lookup_Country.Continent = Lookup_Continent.continent";
			sqlStr += " where Lookup_Continent.continent_name = @contiParam GROUP BY Lookup_Country.Country_name, Lookup_Continent.continent_name";

			DataSet customers = new DataSet();

			System.Data.OleDb.OleDbDataAdapter myAdapter = new System.Data.OleDb.OleDbDataAdapter(sqlStr, this.___SalesByCountry_2015TableAdapter.Connection);

			//apply region code
			myAdapter.SelectCommand.Parameters.Clear();
			myAdapter.SelectCommand.Parameters.Insert(0, new System.Data.OleDb.OleDbParameter("contiParam", region));
			myAdapter.Fill(customers, "Customers");

			bindEurope = new BindingSource();
			bindEurope.DataSource = customers;
			bindEurope.DataMember = customers.Tables[0].ToString();

			dataGridView1.DataSource = bindEurope;
			dataGridView1.Refresh();

			dataGridView1.Columns[0].Header.Text = "Sales Income";
			dataGridView1.Columns[1].Header.Text = "Country";
			dataGridView1.Columns[2].Header.Text = "Continent";

			tChart3[0].DataSource = bindEurope;
			tChart3[0].YValues.DataMember = "SumOfInvoice_Value";
			tChart3[0].LabelMember = "Country_name";

			tChart3[0].CheckDataSource();

			tChart3.Header.Text = region + ", Sales 2000-2015";
			labelGrid.Text = region + ", Sales 2000-2015";
			refreshCountryYear(tChart3[0].Labels[0]);

			setComments(commentType.regional);
		}

		private void tChart2_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, MouseEventArgs e)
		{
			refreshRegionChart(s.Labels[valueIndex]);
		}

		private void tChart2_ClickAxis(object sender, MouseEventArgs e)
		{
			int idx = tChart2[0].Clicked(e.X, tChart2.Axes.Bottom.Position);

			if (idx != -1)
			{
				refreshRegionChart(tChart2[0].Labels[idx]);
			}
		}

		private void tChart2_Click(object sender, EventArgs e)
		{
			if (((MouseEventArgs)(e)).Y > tChart2.Axes.Bottom.Position)
			{
				int idx = tChart2[0].Clicked(((MouseEventArgs)(e)).X, tChart2.Axes.Bottom.Position);

				if (idx != -1)
				{
					refreshRegionChart(tChart2[0].Labels[idx]);
				}
			}
		}

		private void setHighestValueHistory()
		{
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

		private void setBottomChartIndex(int valueIndex)
		{
			if (valueIndex != -1)
			{
				tChart1[1].Color = tChart3[0].ValueColor(valueIndex);
				refreshCountryYear(tChart3[0].Labels[valueIndex]);

				//dataGridView1.Selected = this.dataGridView1[1, valueIndex];
				dataGridView1.Selected.Row = valueIndex;
			}
		}

		private void tChart3_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, MouseEventArgs e)
		{
			if (valueIndex != -1)
				setBottomChartIndex(valueIndex);
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			int row = dataGridView1.Selected.Row;
			if (row > -1)
				refreshCountryYear(tChart3[0].Labels[row]);
		}
	}
}
