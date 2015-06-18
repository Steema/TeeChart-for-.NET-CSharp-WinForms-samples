namespace StandardSeriesDemo.StandardSeries.Lines
{
    partial class StockMonitoring
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
      this.tChart1 = new Steema.TeeChart.TChart();
      this.line1 = new Steema.TeeChart.Styles.Line();
      this.line2 = new Steema.TeeChart.Styles.Line();
      this.line3 = new Steema.TeeChart.Styles.Line();
      this.marksTip1 = new Steema.TeeChart.Tools.MarksTip();
      this.SuspendLayout();
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.Elevation = 350;
      this.tChart1.Aspect.ElevationFloat = 350D;
      this.tChart1.Aspect.Perspective = 55;
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
      this.tChart1.Axes.Bottom.AxisPen.Width = 0;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
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
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Bottom.Labels.Font.Name = "Segoe UI";
      this.tChart1.Axes.Bottom.Labels.Font.Size = 16;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 16F;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Name = "Roboto";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Name = "Roboto";
      this.tChart1.Axes.Depth.Title.Font.Size = 13;
      this.tChart1.Axes.Depth.Title.Font.SizeFloat = 13F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Name = "Roboto";
      this.tChart1.Axes.DepthTop.Title.Font.Size = 13;
      this.tChart1.Axes.DepthTop.Title.Font.SizeFloat = 13F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      this.tChart1.Axes.Left.AxisPen.Width = 0;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
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
      this.tChart1.Axes.Left.Labels.Font.Name = "Segoe UI";
      this.tChart1.Axes.Left.Labels.Font.Size = 16;
      this.tChart1.Axes.Left.Labels.Font.SizeFloat = 16F;
      // 
      // 
      // 
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Ticks.Length = 7;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Caption = "Quote";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Left.Title.Font.Name = "Segoe UI";
      this.tChart1.Axes.Left.Title.Lines = new string[] {
        "Quote"};
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.AxisPen.Width = 0;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Grid.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Right.Labels.Font.Name = "Roboto";
      this.tChart1.Axes.Right.Labels.Font.Size = 31;
      this.tChart1.Axes.Right.Labels.Font.SizeFloat = 31F;
      // 
      // 
      // 
      this.tChart1.Axes.Right.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Ticks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Font.Name = "Roboto";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Name = "Roboto";
      this.tChart1.BackColor = System.Drawing.Color.Transparent;
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
      this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Blue;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Bold = true;
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
      this.tChart1.Header.Font.Name = "Roboto Lt";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Header.Font.Shadow.SmoothBlur = 2;
      this.tChart1.Header.Font.Shadow.Visible = true;
      this.tChart1.Header.Font.Size = 14;
      this.tChart1.Header.Font.SizeFloat = 14F;
      this.tChart1.Header.Lines = new string[] {
        "Stock Monitoring"};
      // 
      // 
      // 
      this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Legend.Font.Name = "Segoe UI";
      this.tChart1.Legend.Font.Size = 13;
      this.tChart1.Legend.Font.SizeFloat = 13F;
      // 
      // 
      // 
      this.tChart1.Legend.Pen.Visible = false;
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      this.tChart1.Panel.Bevel.Width = 2;
      this.tChart1.Panel.BevelWidth = 2;
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart1.Series.Add(this.line1);
      this.tChart1.Series.Add(this.line2);
      this.tChart1.Series.Add(this.line3);
      this.tChart1.Size = new System.Drawing.Size(748, 361);
      this.tChart1.TabIndex = 0;
      this.tChart1.Tools.Add(this.marksTip1);
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
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart1.Walls.Back.Pen.Visible = false;
      this.tChart1.Walls.Back.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.Silver;
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.Gray;
      this.tChart1.Walls.Bottom.Brush.Gradient.Visible = true;
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.Gray;
      this.tChart1.Walls.Bottom.Transparent = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.Silver;
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.Gray;
      this.tChart1.Walls.Left.Brush.Gradient.Visible = true;
      // 
      // 
      // 
      this.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.Gray;
      this.tChart1.Walls.Left.Transparent = true;
      // 
      // 
      // 
      this.tChart1.Walls.Right.Transparent = true;
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart1_DoubleClick);
      // 
      // line1
      // 
      // 
      // 
      // 
      this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      this.line1.ColorEach = false;
      // 
      // 
      // 
      this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.line1.LinePen.Width = 3;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Marks.Arrow.Visible = false;
      this.line1.Marks.ArrowLength = 0;
      // 
      // 
      // 
      this.line1.Marks.Font.Name = "Roboto";
      this.line1.Marks.Font.Size = 24;
      this.line1.Marks.Font.SizeFloat = 24F;
      this.line1.Marks.Transparent = true;
      this.line1.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.line1.Pointer.Brush.Gradient.Transparency = 2;
      this.line1.Pointer.HorizSize = 6;
      // 
      // 
      // 
      this.line1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
      this.line1.Pointer.Pen.Width = 3;
      this.line1.Pointer.SizeDouble = 0D;
      this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
      this.line1.Pointer.VertSize = 6;
      this.line1.Pointer.Visible = true;
      this.line1.Title = "Portfolio 1";
      this.line1.ValueFormat = "#.##0,###";
      // 
      // 
      // 
      this.line1.XValues.DateTime = true;
      this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // line2
      // 
      // 
      // 
      // 
      this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.line2.Gradient.Transparency = 2;
      this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.line2.ColorEach = false;
      // 
      // 
      // 
      this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.line2.LinePen.Transparency = 2;
      this.line2.LinePen.Width = 3;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Marks.Arrow.Transparency = 2;
      this.line2.Marks.Arrow.Visible = false;
      this.line2.Marks.ArrowLength = 0;
      // 
      // 
      // 
      this.line2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
      // 
      // 
      // 
      this.line2.Marks.Brush.Gradient.Transparency = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.line2.Marks.Font.Brush.Gradient.Transparency = 2;
      this.line2.Marks.Font.Name = "Roboto";
      this.line2.Marks.Font.Size = 24;
      this.line2.Marks.Font.SizeFloat = 24F;
      // 
      // 
      // 
      this.line2.Marks.Pen.Transparency = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      this.line2.Marks.Shadow.Brush.Gradient.Transparency = 2;
      this.line2.Marks.Transparent = true;
      this.line2.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.line2.Pointer.Brush.Gradient.Transparency = 2;
      this.line2.Pointer.HorizSize = 6;
      // 
      // 
      // 
      this.line2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.line2.Pointer.Pen.Transparency = 2;
      this.line2.Pointer.Pen.Width = 3;
      this.line2.Pointer.SizeDouble = 0D;
      this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
      this.line2.Pointer.VertSize = 6;
      this.line2.Pointer.Visible = true;
      this.line2.Title = "Portfolio 2";
      this.line2.Transparency = 2;
      this.line2.ValueFormat = "#.##0,###";
      // 
      // 
      // 
      this.line2.XValues.DateTime = true;
      this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // line3
      // 
      // 
      // 
      // 
      this.line3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.line3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.line3.ColorEach = false;
      // 
      // 
      // 
      this.line3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.line3.LinePen.Width = 3;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line3.Marks.Arrow.Visible = false;
      this.line3.Marks.ArrowLength = 0;
      // 
      // 
      // 
      this.line3.Marks.Font.Name = "Roboto";
      this.line3.Marks.Font.Size = 24;
      this.line3.Marks.Font.SizeFloat = 24F;
      this.line3.Marks.Transparent = true;
      this.line3.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.line3.Pointer.Brush.Gradient.Transparency = 2;
      this.line3.Pointer.HorizSize = 6;
      // 
      // 
      // 
      this.line3.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.line3.Pointer.Pen.Width = 3;
      this.line3.Pointer.SizeDouble = 0D;
      this.line3.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
      this.line3.Pointer.VertSize = 6;
      this.line3.Pointer.Visible = true;
      this.line3.Title = "Portfolio 3";
      this.line3.ValueFormat = "#.##0,###";
      // 
      // 
      // 
      this.line3.XValues.DateTime = true;
      this.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // StockMonitoring
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(748, 361);
      this.Controls.Add(this.tChart1);
      this.Name = "StockMonitoring";
      this.Text = "StockMonitoring";
      this.Load += new System.EventHandler(this.StockMonitoring_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Styles.Line line2;
        private Steema.TeeChart.Styles.Line line3;
        private Steema.TeeChart.Tools.MarksTip marksTip1;
    }
}