namespace StandardSeriesDemo.StandardSeries.Bars
{
    partial class ServerStatus
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerStatus));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.horizBar1 = new Steema.TeeChart.Styles.HorizBar();
      this.horizBar2 = new Steema.TeeChart.Styles.HorizBar();
      this.tChart2 = new Steema.TeeChart.TChart();
      this.calendar1 = new Steema.TeeChart.Styles.Calendar();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tChart3 = new Steema.TeeChart.TChart();
      this.horizBar3 = new Steema.TeeChart.Styles.HorizBar();
      this.horizBar4 = new Steema.TeeChart.Styles.HorizBar();
      this.horizBar5 = new Steema.TeeChart.Styles.HorizBar();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.44845F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.55155F));
      this.tableLayoutPanel1.Controls.Add(this.tChart1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tChart2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.35971F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.64029F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 417);
      this.tableLayoutPanel1.TabIndex = 0;
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
      this.tChart1.Axes.Visible = false;
      this.tChart1.BackColor = System.Drawing.Color.Transparent;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.tChart1.Header.AdjustFrame = false;
      // 
      // 
      // 
      this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Header.Font.Name = "Segoe UI";
      this.tChart1.Header.Font.Size = 18;
      this.tChart1.Header.Font.SizeFloat = 18F;
      this.tChart1.Header.Lines = new string[] {
        "Server Status"};
      // 
      // 
      // 
      this.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.tChart1.Header.Transparent = false;
      // 
      // 
      // 
      this.tChart1.Legend.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(3, 3);
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
      this.tChart1.Series.Add(this.horizBar1);
      this.tChart1.Series.Add(this.horizBar2);
      this.tChart1.Size = new System.Drawing.Size(400, 203);
      this.tChart1.TabIndex = 0;
      // 
      // 
      // 
      this.tChart1.Walls.Visible = false;
      this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart_DoubleClick);
      // 
      // horizBar1
      // 
      this.horizBar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.horizBar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.horizBar1.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
      this.horizBar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.horizBar1.ColorEach = false;
      // 
      // 
      // 
      this.horizBar1.Marks.Visible = false;
      this.horizBar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
      this.horizBar1.OriginalCursor = null;
      // 
      // 
      // 
      this.horizBar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.horizBar1.Title = "horizBar1";
      // 
      // 
      // 
      this.horizBar1.XValues.DataMember = "X";
      // 
      // 
      // 
      this.horizBar1.YValues.DataMember = "Bar";
      this.horizBar1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // horizBar2
      // 
      this.horizBar2.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.horizBar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      // 
      // 
      // 
      this.horizBar2.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
      this.horizBar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.horizBar2.ColorEach = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.horizBar2.Marks.Arrow.Visible = false;
      this.horizBar2.Marks.ArrowLength = -34;
      // 
      // 
      // 
      this.horizBar2.Marks.Brush.Visible = false;
      // 
      // 
      // 
      this.horizBar2.Marks.Font.Bold = true;
      // 
      // 
      // 
      this.horizBar2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.horizBar2.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Percent;
      this.horizBar2.Marks.Transparent = true;
      this.horizBar2.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
      this.horizBar2.OriginalCursor = null;
      // 
      // 
      // 
      this.horizBar2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.horizBar2.Title = "horizBar2";
      // 
      // 
      // 
      this.horizBar2.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // tChart2
      // 
      // 
      // 
      // 
      this.tChart2.Aspect.ColorPaletteIndex = 21;
      this.tChart2.BackColor = System.Drawing.Color.Transparent;
      this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Footer.Font.Brush.Color = System.Drawing.Color.Blue;
      // 
      // 
      // 
      this.tChart2.Header.Visible = false;
      // 
      // 
      // 
      this.tChart2.Legend.Visible = false;
      this.tChart2.Location = new System.Drawing.Point(409, 3);
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
      this.tChart2.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart2.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart2.Series.Add(this.calendar1);
      this.tChart2.Size = new System.Drawing.Size(364, 203);
      this.tChart2.TabIndex = 1;
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
      this.tChart2.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart2.DoubleClick += new System.EventHandler(this.tChart_DoubleClick);
      // 
      // calendar1
      // 
      this.calendar1.Color = System.Drawing.Color.Empty;
      this.calendar1.ColorEach = false;
      this.calendar1.ColorMember = "Colors";
      this.calendar1.Colors = ((Steema.TeeChart.Styles.ColorList)(resources.GetObject("calendar1.Colors")));
      this.calendar1.Date = new System.DateTime(2015, 3, 9, 0, 0, 0, 0);
      this.calendar1.DayOneColumn = 7;
      this.calendar1.DayOneRow = 3;
      // 
      // 
      // 
      this.calendar1.Legend.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.calendar1.Marks.Brush.Color = System.Drawing.Color.Gold;
      this.calendar1.OriginalCursor = null;
      // 
      // 
      // 
      this.calendar1.Pen.Visible = false;
      this.calendar1.Title = "calendar1";
      // 
      // 
      // 
      this.calendar1.XValues.DataMember = "X";
      this.calendar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.calendar1.YValues.DataMember = "Y";
      this.calendar1.Change += new Steema.TeeChart.Styles.Calendar.CalendarChangeEventHandler(this.calendar1_Change);
      // 
      // panel1
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
      this.panel1.Controls.Add(this.tChart3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 212);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(770, 202);
      this.panel1.TabIndex = 2;
      // 
      // tChart3
      // 
      // 
      // 
      // 
      this.tChart3.Aspect.ColorPaletteIndex = 21;
      this.tChart3.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Bottom.AxisPen.Width = 1;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart3.Axes.Bottom.Labels.Font.Name = "Segoe UI";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Left.AxisPen.Visible = false;
      // 
      // 
      // 
      this.tChart3.Axes.Left.Grid.Visible = false;
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
      this.tChart3.Axes.Left.Labels.Font.Name = "Segoe UI";
      // 
      // 
      // 
      this.tChart3.Axes.Left.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart3.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart3.BackColor = System.Drawing.Color.Transparent;
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
      this.tChart3.Footer.Font.Brush.Color = System.Drawing.Color.Blue;
      // 
      // 
      // 
      this.tChart3.Header.Alignment = System.Drawing.StringAlignment.Near;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart3.Header.Font.Size = 16;
      this.tChart3.Header.Font.SizeFloat = 16F;
      this.tChart3.Header.Lines = new string[] {
        "Active Servers"};
      // 
      // 
      // 
      this.tChart3.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
      this.tChart3.Legend.Transparent = true;
      this.tChart3.Location = new System.Drawing.Point(0, 0);
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
      this.tChart3.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart3.Panel.Brush.Gradient.Visible = false;
      this.tChart3.Panel.MarginBottom = 1D;
      this.tChart3.Panel.MarginLeft = 2D;
      this.tChart3.Panel.MarginRight = 2D;
      this.tChart3.Panel.MarginTop = 2D;
      this.tChart3.Series.Add(this.horizBar3);
      this.tChart3.Series.Add(this.horizBar4);
      this.tChart3.Series.Add(this.horizBar5);
      this.tChart3.Size = new System.Drawing.Size(770, 202);
      this.tChart3.TabIndex = 0;
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
      this.tChart3.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart3.Walls.Back.Visible = false;
      this.tChart3.DoubleClick += new System.EventHandler(this.tChart_DoubleClick);
      // 
      // horizBar3
      // 
      this.horizBar3.BarHeightPercent = 100;
      this.horizBar3.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.horizBar3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      // 
      // 
      // 
      this.horizBar3.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
      this.horizBar3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.horizBar3.ColorEach = false;
      // 
      // 
      // 
      this.horizBar3.Marks.Visible = false;
      this.horizBar3.OriginalCursor = null;
      // 
      // 
      // 
      this.horizBar3.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(55)))), ((int)(((byte)(3)))));
      this.horizBar3.Title = "Server 1";
      // 
      // 
      // 
      this.horizBar3.XValues.DataMember = "X";
      // 
      // 
      // 
      this.horizBar3.YValues.DataMember = "Bar";
      this.horizBar3.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // horizBar4
      // 
      this.horizBar4.BarHeightPercent = 100;
      this.horizBar4.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.horizBar4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.horizBar4.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
      this.horizBar4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.horizBar4.ColorEach = false;
      // 
      // 
      // 
      this.horizBar4.Marks.Visible = false;
      this.horizBar4.OriginalCursor = null;
      // 
      // 
      // 
      this.horizBar4.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
      this.horizBar4.Title = "Server 2";
      // 
      // 
      // 
      this.horizBar4.XValues.DataMember = "X";
      // 
      // 
      // 
      this.horizBar4.YValues.DataMember = "Bar";
      this.horizBar4.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // horizBar5
      // 
      this.horizBar5.BarHeightPercent = 100;
      this.horizBar5.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.horizBar5.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(197)))), ((int)(((byte)(184)))));
      // 
      // 
      // 
      this.horizBar5.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
      this.horizBar5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(197)))), ((int)(((byte)(184)))));
      this.horizBar5.ColorEach = false;
      // 
      // 
      // 
      this.horizBar5.Marks.Visible = false;
      this.horizBar5.OriginalCursor = null;
      // 
      // 
      // 
      this.horizBar5.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
      this.horizBar5.Title = "Server 3";
      // 
      // 
      // 
      this.horizBar5.XValues.DataMember = "X";
      // 
      // 
      // 
      this.horizBar5.YValues.DataMember = "Bar";
      this.horizBar5.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // ServerStatus
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(776, 417);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ServerStatus";
      this.Tag = "ServerStatus";
      this.Text = "ServerStatus";
      this.Load += new System.EventHandler(this.ServerStatus_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.TChart tChart2;
        private System.Windows.Forms.Panel panel1;
        private Steema.TeeChart.TChart tChart3;
        private Steema.TeeChart.Styles.Calendar calendar1;
        private Steema.TeeChart.Styles.HorizBar horizBar3;
        private Steema.TeeChart.Styles.HorizBar horizBar4;
        private Steema.TeeChart.Styles.HorizBar horizBar5;
        private Steema.TeeChart.Styles.HorizBar horizBar1;
        private Steema.TeeChart.Styles.HorizBar horizBar2;

    }
}