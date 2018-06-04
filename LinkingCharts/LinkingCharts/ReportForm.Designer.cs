namespace LinkingCharts
{
  partial class ReportForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.techProductsLtdDataSet1 = new LinkingCharts.TechProductsLtdDataSet();
      this.____SalesByYearTableAdapter = new LinkingCharts.TechProductsLtdDataSetTableAdapters.____SalesByYearTableAdapter();
      this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.___SalesByCountry_2015TableAdapter = new LinkingCharts.TechProductsLtdDataSetTableAdapters.@__SalesByCountry_2015TableAdapter();
      this.dataGridView1 = new Steema.TeeGrid.WinForm.TGrid();
      this.sumOfInvoiceValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.countrynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.continentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
      this.___SalesByContinentTableAdapter = new LinkingCharts.TechProductsLtdDataSetTableAdapters.@__SalesByContinentTableAdapter();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.labelNews = new System.Windows.Forms.Label();
      this.labelGrid = new System.Windows.Forms.Label();
      this.tChart6 = new Steema.TeeChart.TChart();
      this.tChart4 = new Steema.TeeChart.TChart();
      this.biPanel1 = new LinkingCharts.BasePanel();
      this.tChart3 = new Steema.TeeChart.TChart();
      this.pie1 = new Steema.TeeChart.Styles.Pie();
      this.tChart2 = new Steema.TeeChart.TChart();
      this.bar2 = new Steema.TeeChart.Styles.Bar();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.line1 = new Steema.TeeChart.Styles.Line();
      this.line2 = new Steema.TeeChart.Styles.Line();
      this.smoothing1 = new Steema.TeeChart.Functions.Smoothing();
      this.chartController1 = new Steema.TeeChart.ChartController();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.techProductsLtdDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.biPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // bindingSource1
      // 
      this.bindingSource1.DataMember = "$_€_SalesByYear";
      this.bindingSource1.DataSource = this.techProductsLtdDataSet1;
      // 
      // techProductsLtdDataSet1
      // 
      this.techProductsLtdDataSet1.DataSetName = "TechProductsLtdDataSet";
      this.techProductsLtdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // ____SalesByYearTableAdapter
      // 
      this.____SalesByYearTableAdapter.ClearBeforeFill = true;
      // 
      // bindingSource2
      // 
      this.bindingSource2.DataMember = "$_SalesByCountry_2015";
      this.bindingSource2.DataSource = this.techProductsLtdDataSet1;
      // 
      // ___SalesByCountry_2015TableAdapter
      // 
      this.___SalesByCountry_2015TableAdapter.ClearBeforeFill = true;
      // 
      // dataGridView1
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
      //this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      //this.dataGridView1.AutoGenerateColumns = false;
      //this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
      //this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      //this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
      //      this.sumOfInvoiceValueDataGridViewTextBoxColumn,
      //      this.countrynameDataGridViewTextBoxColumn,
      //      this.continentnameDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.bindingSource2;
      //this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.Location = new System.Drawing.Point(1109, 79);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(347, 460);
      this.dataGridView1.TabIndex = 10;
      // 
      // sumOfInvoiceValueDataGridViewTextBoxColumn
      // 
      this.sumOfInvoiceValueDataGridViewTextBoxColumn.DataPropertyName = "SumOfInvoice_Value";
      this.sumOfInvoiceValueDataGridViewTextBoxColumn.HeaderText = "SumOfInvoice_Value";
      this.sumOfInvoiceValueDataGridViewTextBoxColumn.Name = "sumOfInvoiceValueDataGridViewTextBoxColumn";
      // 
      // countrynameDataGridViewTextBoxColumn
      // 
      this.countrynameDataGridViewTextBoxColumn.DataPropertyName = "Country_name";
      this.countrynameDataGridViewTextBoxColumn.HeaderText = "Country_name";
      this.countrynameDataGridViewTextBoxColumn.Name = "countrynameDataGridViewTextBoxColumn";
      // 
      // continentnameDataGridViewTextBoxColumn
      // 
      this.continentnameDataGridViewTextBoxColumn.DataPropertyName = "continent_name";
      this.continentnameDataGridViewTextBoxColumn.HeaderText = "continent_name";
      this.continentnameDataGridViewTextBoxColumn.Name = "continentnameDataGridViewTextBoxColumn";
      // 
      // bindingSource3
      // 
      this.bindingSource3.DataMember = "$_SalesByContinent";
      this.bindingSource3.DataSource = this.techProductsLtdDataSet1;
      // 
      // ___SalesByContinentTableAdapter
      // 
      this.___SalesByContinentTableAdapter.ClearBeforeFill = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1456, 47);
      this.panel1.TabIndex = 12;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
      this.label2.Location = new System.Drawing.Point(301, 5);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(304, 30);
      this.label2.TabIndex = 2;
      this.label2.Text = "Sales Performance by Country";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.InitialImage = null;
      this.pictureBox1.Location = new System.Drawing.Point(240, 8);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(25, 25);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(103)))), ((int)(((byte)(135)))));
      this.label1.Location = new System.Drawing.Point(12, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(233, 37);
      this.label1.TabIndex = 0;
      this.label1.Text = "TechProduct Ltd.";
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(1109, 583);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(347, 190);
      this.textBox1.TabIndex = 13;
      // 
      // labelNews
      // 
      this.labelNews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelNews.BackColor = System.Drawing.Color.Silver;
      this.labelNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNews.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.labelNews.Location = new System.Drawing.Point(1108, 554);
      this.labelNews.Name = "labelNews";
      this.labelNews.Size = new System.Drawing.Size(348, 29);
      this.labelNews.TabIndex = 14;
      this.labelNews.Text = "Commentary";
      // 
      // labelGrid
      // 
      this.labelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelGrid.BackColor = System.Drawing.Color.Silver;
      this.labelGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelGrid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.labelGrid.Location = new System.Drawing.Point(1108, 50);
      this.labelGrid.Name = "labelGrid";
      this.labelGrid.Size = new System.Drawing.Size(348, 29);
      this.labelGrid.TabIndex = 15;
      this.labelGrid.Text = "Sales figures, 2015";
      // 
      // tChart6
      // 
      // 
      // 
      // 
      this.tChart6.Aspect.ColorPaletteIndex = 20;
      this.tChart6.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart6.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Axes.Bottom.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart6.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart6.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart6.Axes.Bottom.Title.Font.Size = 11;
      this.tChart6.Axes.Bottom.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Axes.Left.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart6.Axes.Left.Labels.Font.Size = 9;
      this.tChart6.Axes.Left.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart6.Axes.Left.Title.Font.Size = 11;
      this.tChart6.Axes.Left.Title.Font.SizeFloat = 11F;
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
      this.tChart6.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart6.Axes.Right.Labels.Font.Size = 9;
      this.tChart6.Axes.Right.Labels.Font.SizeFloat = 9F;
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
      this.tChart6.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart6.Axes.Top.Labels.Font.Size = 9;
      this.tChart6.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.tChart6.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart6.Header.Font.Size = 12;
      this.tChart6.Header.Font.SizeFloat = 12F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart6.Legend.Font.Size = 9;
      this.tChart6.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.tChart6.Legend.Shadow.Visible = false;
      this.tChart6.Legend.Transparent = true;
      this.tChart6.Location = new System.Drawing.Point(0, 0);
      this.tChart6.Name = "tChart6";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart6.Panel.Brush.Gradient.Visible = false;
      this.tChart6.Size = new System.Drawing.Size(600, 400);
      this.tChart6.TabIndex = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart6.Walls.Back.Brush.Visible = false;
      this.tChart6.Walls.Back.Transparent = true;
      this.tChart6.Walls.Back.Visible = false;
      // 
      // tChart4
      // 
      // 
      // 
      // 
      this.tChart4.Aspect.ColorPaletteIndex = 20;
      this.tChart4.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart4.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Axes.Bottom.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart4.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart4.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.Axes.Bottom.Title.Font.Size = 11;
      this.tChart4.Axes.Bottom.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Axes.Left.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart4.Axes.Left.Labels.Font.Size = 9;
      this.tChart4.Axes.Left.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.Axes.Left.Title.Font.Size = 11;
      this.tChart4.Axes.Left.Title.Font.SizeFloat = 11F;
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
      this.tChart4.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.Axes.Right.Labels.Font.Size = 9;
      this.tChart4.Axes.Right.Labels.Font.SizeFloat = 9F;
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
      this.tChart4.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.Axes.Top.Labels.Font.Size = 9;
      this.tChart4.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.tChart4.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart4.Header.Font.Size = 12;
      this.tChart4.Header.Font.SizeFloat = 12F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.Legend.Font.Size = 9;
      this.tChart4.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.tChart4.Legend.Shadow.Visible = false;
      this.tChart4.Legend.Transparent = true;
      this.tChart4.Location = new System.Drawing.Point(0, 0);
      this.tChart4.Name = "tChart4";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart4.Panel.Brush.Gradient.Visible = false;
      this.tChart4.Size = new System.Drawing.Size(600, 400);
      this.tChart4.TabIndex = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Walls.Back.Brush.Visible = false;
      this.tChart4.Walls.Back.Transparent = true;
      this.tChart4.Walls.Back.Visible = false;
      // 
      // biPanel1
      // 
      this.biPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.biPanel1.Controls.Add(this.tChart3);
      this.biPanel1.Controls.Add(this.tChart2);
      this.biPanel1.Controls.Add(this.tChart1);
      this.biPanel1.Controls.Add(this.chartController1);
      this.biPanel1.Location = new System.Drawing.Point(0, 47);
      this.biPanel1.Name = "biPanel1";
      this.biPanel1.Size = new System.Drawing.Size(1092, 575);
      this.biPanel1.TabIndex = 9;
      // 
      // tChart3
      // 
      // 
      // 
      // 
      this.tChart3.Aspect.ColorPaletteIndex = 3;
      this.tChart3.Aspect.Elevation = 315;
      this.tChart3.Aspect.ElevationFloat = 315D;
      this.tChart3.Aspect.Orthogonal = false;
      this.tChart3.Aspect.Perspective = 0;
      this.tChart3.Aspect.Rotation = 360;
      this.tChart3.Aspect.RotationFloat = 360D;
      this.tChart3.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart3.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Bottom.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart3.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart3.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.Axes.Bottom.Title.Font.Size = 11;
      this.tChart3.Axes.Bottom.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Left.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart3.Axes.Left.Labels.Font.Size = 9;
      this.tChart3.Axes.Left.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.Axes.Left.Title.Font.Size = 11;
      this.tChart3.Axes.Left.Title.Font.SizeFloat = 11F;
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
      this.tChart3.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.Axes.Right.Labels.Font.Size = 9;
      this.tChart3.Axes.Right.Labels.Font.SizeFloat = 9F;
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
      this.tChart3.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.Axes.Top.Labels.Font.Size = 9;
      this.tChart3.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.tChart3.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      this.tChart3.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart3.Header.Font.Size = 12;
      this.tChart3.Header.Font.SizeFloat = 12F;
      this.tChart3.Header.Lines = new string[] {
        "Countries, Sales 2015"};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.Legend.Font.Size = 9;
      this.tChart3.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.tChart3.Legend.Shadow.Visible = false;
      this.tChart3.Legend.Transparent = true;
      this.tChart3.Legend.Visible = false;
      this.tChart3.Location = new System.Drawing.Point(429, 0);
      this.tChart3.Name = "tChart3";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart3.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart3.Panel.Brush.Gradient.Visible = false;
      this.tChart3.Series.Add(this.pie1);
      this.tChart3.Size = new System.Drawing.Size(663, 348);
      this.tChart3.TabIndex = 8;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Walls.Back.Brush.Visible = false;
      this.tChart3.Walls.Back.Transparent = true;
      this.tChart3.Walls.Back.Visible = false;
      this.tChart3.ClickSeries += new Steema.TeeChart.SeriesEventHandler(this.tChart3_ClickSeries);
      // 
      // pie1
      // 
      // 
      // 
      // 
      this.pie1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(144)))));
      this.pie1.Circled = true;
      this.pie1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.pie1.DataSource = this.bindingSource2;
      // 
      // 
      // 
      this.pie1.Frame.Circled = true;
      this.pie1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      // 
      // 
      // 
      // 
      // 
      // 
      this.pie1.Frame.OuterBand.Gradient.UseMiddle = false;
      this.pie1.LabelMember = "Country_name";
      // 
      // 
      // 
      // 
      // 
      // 
      this.pie1.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.pie1.Marks.ArrowLength = 10;
      // 
      // 
      // 
      this.pie1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.pie1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.pie1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.pie1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.pie1.Marks.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.pie1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.pie1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(124)))), ((int)(((byte)(174)))));
      // 
      // 
      // 
      this.pie1.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.pie1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
      this.pie1.Marks.TailParams.CustomPoint = true;
      this.pie1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
      this.pie1.Marks.TailParams.Margin = 2F;
      this.pie1.Marks.TailParams.PointerHeight = 5D;
      this.pie1.Marks.TailParams.PointerWidth = 8D;
      this.pie1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      // 
      // 
      // 
      this.pie1.MarksPie.InsideSlice = false;
      this.pie1.MarksPie.LegSize = 0;
      this.pie1.MarksPie.Rotated = false;
      this.pie1.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
      this.pie1.MarksPie.VertCenter = false;
      this.pie1.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      this.pie1.OriginalCursor = null;
      // 
      // 
      // 
      this.pie1.OtherSlice.Color = System.Drawing.Color.Empty;
      this.pie1.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.BelowPercent;
      this.pie1.OtherSlice.Text = "Other";
      this.pie1.OtherSlice.Value = 1D;
      this.pie1.Title = "pie1";
      this.pie1.UniqueCustomRadius = true;
      this.pie1.UseExtendedNumRange = false;
      // 
      // 
      // 
      this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.pie1.YValues.DataMember = "SumOfInvoice_Value";
      // 
      // tChart2
      // 
      // 
      // 
      // 
      this.tChart2.Aspect.ColorPaletteIndex = 3;
      this.tChart2.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart2.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Axes.Bottom.Grid.DrawEvery = 2;
      // 
      // 
      // 
      this.tChart2.Axes.Bottom.Labels.Angle = 90;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart2.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.Axes.Bottom.Title.Font.Size = 11;
      this.tChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Axes.Left.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart2.Axes.Left.Labels.Font.Size = 9;
      this.tChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.Axes.Left.Title.Font.Size = 11;
      this.tChart2.Axes.Left.Title.Font.SizeFloat = 11F;
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
      this.tChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.Axes.Right.Labels.Font.Size = 9;
      this.tChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
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
      this.tChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.Axes.Top.Labels.Font.Size = 9;
      this.tChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.tChart2.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      this.tChart2.Dock = System.Windows.Forms.DockStyle.Left;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart2.Header.Font.Size = 12;
      this.tChart2.Header.Font.SizeFloat = 12F;
      this.tChart2.Header.Lines = new string[] {
        "Continents, Sales 2000-2015"};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.Legend.Font.Size = 9;
      this.tChart2.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.tChart2.Legend.Shadow.Visible = false;
      this.tChart2.Legend.Transparent = true;
      this.tChart2.Legend.Visible = false;
      this.tChart2.Location = new System.Drawing.Point(0, 0);
      this.tChart2.Name = "tChart2";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart2.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart2.Panel.Brush.Gradient.Visible = false;
      this.tChart2.Series.Add(this.bar2);
      this.tChart2.Size = new System.Drawing.Size(429, 348);
      this.tChart2.TabIndex = 7;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Walls.Back.Brush.Visible = false;
      this.tChart2.Walls.Back.Transparent = true;
      this.tChart2.Walls.Back.Visible = false;
      this.tChart2.ClickAxis += new System.Windows.Forms.MouseEventHandler(this.tChart2_ClickAxis);
      this.tChart2.ClickSeries += new Steema.TeeChart.SeriesEventHandler(this.tChart2_ClickSeries);
      this.tChart2.Click += new System.EventHandler(this.tChart2_Click);
      // 
      // bar2
      // 
      this.bar2.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.bar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.bar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.bar2.ColorEach = false;
      this.bar2.DataSource = this.bindingSource3;
      this.bar2.LabelMember = "continent_name";
      // 
      // 
      // 
      this.bar2.Marks.ArrowLength = 10;
      // 
      // 
      // 
      this.bar2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.bar2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.bar2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.bar2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.bar2.Marks.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.bar2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
      // 
      // 
      // 
      this.bar2.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.bar2.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
      this.bar2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
      this.bar2.Marks.TailParams.Margin = 0F;
      this.bar2.Marks.TailParams.PointerHeight = 8D;
      this.bar2.Marks.TailParams.PointerWidth = 8D;
      this.bar2.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      this.bar2.Marks.Visible = false;
      this.bar2.OriginalCursor = null;
      // 
      // 
      // 
      this.bar2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.bar2.Title = "bar1";
      this.bar2.UseExtendedNumRange = false;
      // 
      // 
      // 
      this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.bar2.YValues.DataMember = "SumOfInvoice_Value";
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ColorPaletteIndex = 21;
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart1.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      this.tChart1.Axes.Bottom.Labels.ValueFormat = "###0";
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Bottom.Title.Font.Size = 11;
      this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Left.Labels.Font.Size = 9;
      this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Left.Title.Font.Size = 11;
      this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
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
      this.tChart1.Axes.Right.Labels.Font.Size = 9;
      this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
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
      this.tChart1.Axes.Top.Labels.Font.Size = 9;
      this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.tChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Bottom;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Header.Font.Size = 12;
      this.tChart1.Header.Font.SizeFloat = 12F;
      this.tChart1.Header.Lines = new string[] {
        "Country"};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Legend.Font.Size = 6;
      this.tChart1.Legend.Font.SizeFloat = 6F;
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Legend.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(0, 348);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.line1);
      this.tChart1.Series.Add(this.line2);
      this.tChart1.Size = new System.Drawing.Size(1092, 227);
      this.tChart1.TabIndex = 6;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Visible = false;
      this.tChart1.Walls.Back.Transparent = true;
      this.tChart1.Walls.Back.Visible = false;
      // 
      // line1
      // 
      // 
      // 
      // 
      this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.line1.ColorEach = false;
      this.line1.LabelMember = "Country_name";
      // 
      // 
      // 
      this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(55)))), ((int)(((byte)(3)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.line1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.line1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.line1.Marks.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.line1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(83)))), ((int)(((byte)(4)))));
      // 
      // 
      // 
      this.line1.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.line1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
      this.line1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
      this.line1.Marks.TailParams.Margin = 0F;
      this.line1.Marks.TailParams.PointerHeight = 8D;
      this.line1.Marks.TailParams.PointerWidth = 8D;
      this.line1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      this.line1.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.line1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
      this.line1.Pointer.HorizSize = 2;
      // 
      // 
      // 
      this.line1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(122)))));
      this.line1.Pointer.SizeDouble = 0D;
      this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line1.Pointer.VertSize = 2;
      this.line1.Pointer.Visible = true;
      this.line1.Title = "line1";
      this.line1.UseExtendedNumRange = false;
      this.line1.Visible = false;
      // 
      // 
      // 
      this.line1.XValues.DataMember = "X";
      this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line1.YValues.DataMember = "SumOfInvoice_Value";
      // 
      // line2
      // 
      // 
      // 
      // 
      this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.line2.ColorEach = false;
      this.line2.DataSource = this.line1;
      this.line2.Function = this.smoothing1;
      // 
      // 
      // 
      this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
      this.line2.LinePen.Width = 3;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.line2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.line2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.line2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.line2.Marks.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.line2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.line2.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.line2.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
      this.line2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos3")));
      this.line2.Marks.TailParams.Margin = 0F;
      this.line2.Marks.TailParams.PointerHeight = 5D;
      this.line2.Marks.TailParams.PointerWidth = 8D;
      this.line2.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      this.line2.OriginalCursor = null;
      // 
      // 
      // 
      this.line2.Pointer.SizeDouble = 0D;
      this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line2.Title = "line2";
      this.line2.UseExtendedNumRange = false;
      // 
      // 
      // 
      this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line2.YValues.DataMember = "Y";
      // 
      // smoothing1
      // 
      this.smoothing1.Period = 1D;
      // 
      // chartController1
      // 
      this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
      this.chartController1.Chart = this.tChart3;
      this.chartController1.LabelValues = true;
      this.chartController1.Location = new System.Drawing.Point(0, 0);
      this.chartController1.Name = "chartController1";
      this.chartController1.Size = new System.Drawing.Size(936, 25);
      this.chartController1.TabIndex = 5;
      this.chartController1.Text = "chartController1";
      this.chartController1.Visible = false;
      // 
      // ReportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1456, 622);
      this.Controls.Add(this.labelGrid);
      this.Controls.Add(this.labelNews);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.biPanel1);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ReportForm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.ReportForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.techProductsLtdDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.biPanel1.ResumeLayout(false);
      this.biPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private Steema.TeeChart.TChart tChart3;
    private Steema.TeeChart.TChart tChart2;
    private Steema.TeeChart.TChart tChart1;
    private Steema.TeeChart.ChartController chartController1;
    private Steema.TeeChart.TChart tChart6;
    private Steema.TeeChart.TChart tChart4;
    private System.Windows.Forms.BindingSource bindingSource1;
    private TechProductsLtdDataSet techProductsLtdDataSet1;
    private TechProductsLtdDataSetTableAdapters.____SalesByYearTableAdapter ____SalesByYearTableAdapter;
    private BasePanel biPanel1;
    private System.Windows.Forms.BindingSource bindingSource2;
    private TechProductsLtdDataSetTableAdapters.__SalesByCountry_2015TableAdapter ___SalesByCountry_2015TableAdapter;
    private Steema.TeeGrid.WinForm.TGrid dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn sumOfInvoiceValueDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn countrynameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn continentnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource bindingSource3;
    private TechProductsLtdDataSetTableAdapters.__SalesByContinentTableAdapter ___SalesByContinentTableAdapter;
    private Steema.TeeChart.Styles.Bar bar2;
    private Steema.TeeChart.Styles.Pie pie1;
    private Steema.TeeChart.Styles.Line line1;
    private Steema.TeeChart.Styles.Line line2;
    private Steema.TeeChart.Functions.Smoothing smoothing1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label labelNews;
    private System.Windows.Forms.Label labelGrid;
  }
}
