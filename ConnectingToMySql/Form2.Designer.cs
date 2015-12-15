namespace ConnectingToMySql
{
  partial class Form2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
      this.tChart1 = new Steema.TeeChart.TChart();
      this.map1 = new Steema.TeeChart.Styles.Map();
      this.odbcDataAdapter1 = new System.Data.Odbc.OdbcDataAdapter();
      this.odbcSelectCommand1 = new System.Data.Odbc.OdbcCommand();
      this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataSet1 = new System.Data.DataSet();
      this.chartController1 = new Steema.TeeChart.ChartController();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ColorPaletteIndex = 20;
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
      this.tChart1.Axes.Bottom.Grid.Visible = false;
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
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
      this.tChart1.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
      // 
      // 
      // 
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Ticks.Visible = false;
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.AxisPen.Visible = false;
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
      this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
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
      this.tChart1.Header.Lines = new string[] {
        "TeeChart Example using ESRI format map file and MySQL sourced attributes. The Chart shows population by country"};
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
      // 
      // 
      // 
      this.tChart1.Legend.Pen.Visible = false;
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Legend.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(510, 25);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.map1);
      this.tChart1.Size = new System.Drawing.Size(672, 496);
      this.tChart1.TabIndex = 2;
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
      // map1
      // 
      // 
      // 
      // 
      this.map1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(235)))));
      this.map1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.map1.ColorEach = false;
      // 
      // 
      // 
      this.map1.MapMarks.AutoSize = true;
      this.map1.MapMarks.Centroid = true;
      this.map1.MapMarks.TextStyle = Steema.TeeChart.Styles.MapMarksText.Label;
      this.map1.MapMarks.UpperCase = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.map1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.map1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.map1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.map1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.map1.Marks.Brush.Gradient.UseMiddle = true;
      this.map1.Marks.Clip = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.map1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.map1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
      // 
      // 
      // 
      this.map1.Marks.Shadow.Visible = false;
      this.map1.OriginalCursor = null;
      this.map1.PaletteMin = 0D;
      this.map1.PaletteStep = 0D;
      this.map1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
      this.map1.PointSize = 0.1D;
      this.map1.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
      this.map1.Title = "map1";
      // 
      // 
      // 
      this.map1.ZValues.DataMember = "Z";
      // 
      // odbcDataAdapter1
      // 
      this.odbcDataAdapter1.SelectCommand = this.odbcSelectCommand1;
      this.odbcDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CODE", "CODE"),
                        new System.Data.Common.DataColumnMapping("CNTRY_NAME", "CNTRY_NAME"),
                        new System.Data.Common.DataColumnMapping("POP_CNTRY", "POP_CNTRY"),
                        new System.Data.Common.DataColumnMapping("CURR_TYPE", "CURR_TYPE"),
                        new System.Data.Common.DataColumnMapping("CURR_CODE", "CURR_CODE"),
                        new System.Data.Common.DataColumnMapping("FIPS", "FIPS")})});
      // 
      // odbcSelectCommand1
      // 
      this.odbcSelectCommand1.CommandText = "SELECT        world.*\r\nFROM            world";
      this.odbcSelectCommand1.Connection = this.odbcConnection1;
      // 
      // odbcConnection1
      // 
      this.odbcConnection1.ConnectionString = "Dsn=world_map;uid=flute_16_r;";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
      this.dataGridView1.Location = new System.Drawing.Point(0, 25);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(510, 496);
      this.dataGridView1.TabIndex = 1;
      // 
      // dataSet1
      // 
      this.dataSet1.DataSetName = "MapDataSet";
      // 
      // chartController1
      // 
      this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
      this.chartController1.Chart = this.tChart1;
      this.chartController1.LabelValues = true;
      this.chartController1.Location = new System.Drawing.Point(0, 0);
      this.chartController1.Name = "chartController1";
      this.chartController1.Size = new System.Drawing.Size(1182, 25);
      this.chartController1.TabIndex = 0;
      this.chartController1.Text = "chartController1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1182, 521);
      this.Controls.Add(this.tChart1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.chartController1);
      this.Name = "Form1";
      this.Text = "MySQL&TeeChart";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Steema.TeeChart.ChartController chartController1;
    private Steema.TeeChart.TChart tChart1;
    private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter1;
    private System.Data.Odbc.OdbcCommand odbcSelectCommand1;
    private System.Data.Odbc.OdbcConnection odbcConnection1;
    private System.Windows.Forms.DataGridView dataGridView1;
    
    private Steema.TeeChart.Styles.Map map1;
    private System.Data.DataSet dataSet1;
  }
}

