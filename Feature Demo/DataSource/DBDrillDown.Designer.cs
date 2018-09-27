namespace Steema.TeeChart.Samples
{
	partial class DBDrillDown
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
	  this.components = new System.ComponentModel.Container();
	  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBDrillDown));
	  this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
	  this.techProductsLtdDataSet = new Steema.TeeChart.Samples.TechProductsLtdDataSet();
	  this.___SalesByCountryYearTableAdapter = new Steema.TeeChart.Samples.TechProductsLtdDataSetTableAdapters.@__SalesByCountryYearTableAdapter();
	  this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
	  this.___SalesByYearCountryTableAdapter = new Steema.TeeChart.Samples.TechProductsLtdDataSetTableAdapters.@__SalesByYearCountryTableAdapter();
	  this.bar1 = new Steema.TeeChart.Styles.Bar();
	  this.button1 = new System.Windows.Forms.Button();
	  this.panel1.SuspendLayout();
	  this.chartContainer.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
	  ((System.ComponentModel.ISupportInitialize)(this.techProductsLtdDataSet)).BeginInit();
	  ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
	  this.SuspendLayout();
	  // 
	  // textBox1
	  // 
	  this.textBox1.Text = "Drill-down examples with all data bindings set at DesignTime.\r\nPlease click on th" +
    "e Edit... button to see the data configuration (and resize the form as necessary" +
    ").";
	  // 
	  // panel1
	  // 
	  this.panel1.Controls.Add(this.button1);
	  // 
	  // tChart1
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  this.tChart1.Axes.Bottom.FixedLabelSize = false;
	  // 
	  // 
	  // 
	  this.tChart1.Axes.Bottom.Labels.Angle = 90;
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  this.tChart1.Header.Font.Size = 14;
	  this.tChart1.Header.Font.SizeFloat = 14F;
	  // 
	  // 
	  // 
	  this.tChart1.Legend.Visible = false;
	  this.tChart1.Series.Add(this.bar1);
	  // 
	  // bindingSource1
	  // 
	  this.bindingSource1.DataMember = "$_SalesByCountryYear";
	  this.bindingSource1.DataSource = this.techProductsLtdDataSet;
	  // 
	  // techProductsLtdDataSet
	  // 
	  this.techProductsLtdDataSet.DataSetName = "TechProductsLtdDataSet";
	  this.techProductsLtdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
	  // 
	  // ___SalesByCountryYearTableAdapter
	  // 
	  this.___SalesByCountryYearTableAdapter.ClearBeforeFill = true;
	  // 
	  // bindingSource2
	  // 
	  this.bindingSource2.DataMember = "$_SalesByYearCountry";
	  this.bindingSource2.DataSource = this.techProductsLtdDataSet;
	  // 
	  // ___SalesByYearCountryTableAdapter
	  // 
	  this.___SalesByYearCountryTableAdapter.ClearBeforeFill = true;
	  // 
	  // bar1
	  // 
	  this.bar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
	  // 
	  // 
	  // 
	  this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
	  this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
	  this.bar1.ColorEach = false;
	  this.bar1.DataSource = this.bindingSource1;
	  this.bar1.DrillDown.DataSource = this.bindingSource2;
	  this.bar1.DrillDown.DrillDownMember = "Country_name";
	  this.bar1.DrillDown.Enabled = true;
	  this.bar1.DrillDownLabelMember = "Invoice_year";
	  this.bar1.LabelMember = "Country_name";
	  // 
	  // 
	  // 
	  // 
	  // 
	  // 
	  this.bar1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
	  this.bar1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
	  this.bar1.Marks.TailParams.Margin = 0F;
	  this.bar1.Marks.TailParams.PointerHeight = 8D;
	  this.bar1.Marks.TailParams.PointerWidth = 8D;
	  this.bar1.Marks.Visible = false;
	  this.bar1.OriginalCursor = null;
	  // 
	  // 
	  // 
	  this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
	  this.bar1.Title = "bar1";
	  this.bar1.UseExtendedNumRange = false;
	  // 
	  // 
	  // 
	  this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
	  // 
	  // 
	  // 
	  this.bar1.YValues.DataMember = "SumOfInvoice_Value";
	  this.bar1.YValues.DrillDownMember = "SumOfInvoice_Value";
	  // 
	  // button1
	  // 
	  this.button1.Location = new System.Drawing.Point(13, 7);
	  this.button1.Name = "button1";
	  this.button1.Size = new System.Drawing.Size(75, 23);
	  this.button1.TabIndex = 0;
	  this.button1.Text = "Edit...";
	  this.button1.UseVisualStyleBackColor = true;
	  this.button1.Click += new System.EventHandler(this.button1_Click);
	  // 
	  // DBDrillDown
	  // 
	  this.ClientSize = new System.Drawing.Size(440, 317);
	  this.Name = "DBDrillDown";
	  this.Load += new System.EventHandler(this.DBDrillDown_Load);
	  this.panel1.ResumeLayout(false);
	  this.chartContainer.ResumeLayout(false);
	  ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
	  ((System.ComponentModel.ISupportInitialize)(this.techProductsLtdDataSet)).EndInit();
	  ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
	  this.ResumeLayout(false);
	  this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private TechProductsLtdDataSet techProductsLtdDataSet;
        private TechProductsLtdDataSetTableAdapters.__SalesByCountryYearTableAdapter ___SalesByCountryYearTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private TechProductsLtdDataSetTableAdapters.__SalesByYearCountryTableAdapter ___SalesByYearCountryTableAdapter;
        private Styles.Bar bar1;
	private System.Windows.Forms.Button button1;
  }
}
