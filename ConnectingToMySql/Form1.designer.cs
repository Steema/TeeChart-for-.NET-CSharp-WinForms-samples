namespace ConnectingToMySql
{
    partial class Form1
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
      this.tChart1 = new Steema.TeeChart.TChart();
      this.bar1 = new Steema.TeeChart.Styles.Bar();
      this.odbcDataAdapter1 = new System.Data.Odbc.OdbcDataAdapter();
      this.odbcSelectCommand1 = new System.Data.Odbc.OdbcCommand();
      this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.chartController1 = new Steema.TeeChart.ChartController();
      this.dataSet11 = new ConnectingToMySql.DataSet1();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
      this.SuspendLayout();
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart1.Axes.Automatic = true;
      this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.tChart1.Legend.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(543, 25);
      this.tChart1.Name = "tChart1";
      this.tChart1.Series.Add(this.bar1);
      this.tChart1.Size = new System.Drawing.Size(639, 491);
      this.tChart1.TabIndex = 0;
      this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
      // 
      // bar1
      // 
      this.bar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.ColorEach = false;
      this.bar1.DataSource = this.odbcDataAdapter1;
      this.bar1.LabelMember = "STATE";
      // 
      // 
      // 
      this.bar1.Marks.Visible = false;
      this.bar1.OriginalCursor = System.Windows.Forms.Cursors.Default;
      // 
      // 
      // 
      this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.bar1.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
      this.bar1.Title = "bar1";
      // 
      // 
      // 
      this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.bar1.YValues.DataMember = "PERIMETER";
      // 
      // odbcDataAdapter1
      // 
      this.odbcDataAdapter1.SelectCommand = this.odbcSelectCommand1;
      this.odbcDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("AREA", "AREA"),
                        new System.Data.Common.DataColumnMapping("PERIMETER", "PERIMETER"),
                        new System.Data.Common.DataColumnMapping("STATESP020", "STATESP020"),
                        new System.Data.Common.DataColumnMapping("STATE", "STATE"),
                        new System.Data.Common.DataColumnMapping("STATE_FIPS", "STATE_FIPS")})});
      // 
      // odbcSelectCommand1
      // 
      this.odbcSelectCommand1.CommandText = "SELECT        usastates.*\r\nFROM            usastates";
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
      this.dataGridView1.Size = new System.Drawing.Size(543, 491);
      this.dataGridView1.TabIndex = 1;
      // 
      // chartController1
      // 
      this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
      this.chartController1.Chart = this.tChart1;
      this.chartController1.LabelValues = true;
      this.chartController1.Location = new System.Drawing.Point(0, 0);
      this.chartController1.Name = "chartController1";
      this.chartController1.Size = new System.Drawing.Size(1182, 25);
      this.chartController1.TabIndex = 2;
      this.chartController1.Text = "chartController1";
      this.chartController1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.chartController1_ItemClicked);
      // 
      // dataSet11
      // 
      this.dataSet11.DataSetName = "DataSet1";
      this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1182, 516);
      this.Controls.Add(this.tChart1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.chartController1);
      this.Name = "Form1";
      this.Text = "MySQL&TeeChart";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Bar bar1;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter1;
        private System.Data.Odbc.OdbcCommand odbcSelectCommand1;
        private System.Data.Odbc.OdbcConnection odbcConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Steema.TeeChart.ChartController chartController1;
    private DataSet1 dataSet11;
  }
}

