namespace StandardSeriesDemo.StandardSeries.Miscellaneous
{
    partial class ScrollerChart
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
      this.annotation1 = new Steema.TeeChart.Tools.Annotation();
      this.annotation2 = new Steema.TeeChart.Tools.Annotation();
      this.marksTip1 = new Steema.TeeChart.Tools.MarksTip();
      this.scrollPager1 = new Steema.TeeChart.Tools.ScrollPager();
      this.SuspendLayout();
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
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Automatic = false;
      this.tChart1.Axes.Bottom.AutomaticMaximum = false;
      this.tChart1.Axes.Bottom.AutomaticMinimum = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Bottom.AxisPen.Width = 1;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Grid.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "HH:mm";
      this.tChart1.Axes.Bottom.Maximum = 0D;
      this.tChart1.Axes.Bottom.Minimum = 0D;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Caption = "Bottom Axis";
      this.tChart1.Axes.Bottom.Title.Lines = new string[] {
        "Bottom Axis"};
      this.tChart1.Axes.Bottom.Title.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Automatic = false;
      this.tChart1.Axes.Left.AutomaticMaximum = false;
      this.tChart1.Axes.Left.AutomaticMinimum = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Left.AxisPen.Width = 1;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Separation = 100;
      this.tChart1.Axes.Left.Maximum = 1.41D;
      this.tChart1.Axes.Left.Minimum = 1.2D;
      // 
      // 
      // 
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Caption = "$ 000s";
      this.tChart1.Axes.Left.Title.Lines = new string[] {
        "$ 000s"};
      this.tChart1.Axes.Left.Title.Visible = false;
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
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Header.Font.Size = 16;
      this.tChart1.Header.Font.SizeFloat = 16F;
      this.tChart1.Header.Lines = new string[] {
        "Sales figures"};
      this.tChart1.Header.Visible = false;
      // 
      // 
      // 
      this.tChart1.Legend.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Panel.MarginTop = 12D;
      // 
      // 
      // 
      this.tChart1.Panning.Allow = Steema.TeeChart.ScrollModes.Horizontal;
      this.tChart1.Series.Add(this.line1);
      this.tChart1.Size = new System.Drawing.Size(734, 422);
      this.tChart1.TabIndex = 0;
      this.tChart1.Tools.Add(this.annotation1);
      this.tChart1.Tools.Add(this.annotation2);
      this.tChart1.Tools.Add(this.marksTip1);
      this.tChart1.Tools.Add(this.scrollPager1);
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
      this.tChart1.Walls.Back.Visible = false;
      // 
      // 
      // 
      this.tChart1.Zoom.Direction = Steema.TeeChart.ZoomDirections.None;
      this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart1_DoubleClick);
      // 
      // line1
      // 
      // 
      // 
      // 
      this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.line1.ColorEach = false;
      // 
      // 
      // 
      this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(55)))), ((int)(((byte)(3)))));
      this.line1.LinePen.Width = 2;
      this.line1.OriginalCursor = null;
      // 
      // 
      // 
      this.line1.Pointer.SizeDouble = 0D;
      this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line1.Title = "USD to Euro";
      // 
      // 
      // 
      this.line1.XValues.DateTime = true;
      this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // annotation1
      // 
      this.annotation1.AutoSize = true;
      // 
      // 
      // 
      this.annotation1.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.annotation1.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.annotation1.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.annotation1.Callout.Brush.Color = System.Drawing.Color.Black;
      this.annotation1.Callout.Distance = 0;
      this.annotation1.Callout.Draw3D = false;
      this.annotation1.Callout.SizeDouble = 0D;
      this.annotation1.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.annotation1.Callout.XPosition = 0;
      this.annotation1.Callout.YPosition = 0;
      this.annotation1.Callout.ZPosition = 0;
      this.annotation1.Cursor = System.Windows.Forms.Cursors.Default;
      this.annotation1.Left = 61;
      // 
      // 
      // 
      this.annotation1.Shape.Bottom = 45;
      this.annotation1.Shape.CustomPosition = true;
      // 
      // 
      // 
      this.annotation1.Shape.Font.Size = 18;
      this.annotation1.Shape.Font.SizeFloat = 18F;
      this.annotation1.Shape.Left = 61;
      this.annotation1.Shape.Right = 408;
      this.annotation1.Shape.Top = 8;
      this.annotation1.Shape.Transparent = true;
      this.annotation1.Text = "US Dollar against the Euro";
      this.annotation1.Top = 8;
      // 
      // annotation2
      // 
      this.annotation2.AutoSize = true;
      // 
      // 
      // 
      this.annotation2.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.annotation2.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.annotation2.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.annotation2.Callout.Brush.Color = System.Drawing.Color.Black;
      this.annotation2.Callout.Distance = 0;
      this.annotation2.Callout.Draw3D = false;
      this.annotation2.Callout.SizeDouble = 0D;
      this.annotation2.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.annotation2.Callout.XPosition = 0;
      this.annotation2.Callout.YPosition = 0;
      this.annotation2.Callout.ZPosition = 0;
      this.annotation2.Cursor = System.Windows.Forms.Cursors.Default;
      this.annotation2.Left = 56;
      // 
      // 
      // 
      this.annotation2.Shape.Bottom = 62;
      this.annotation2.Shape.CustomPosition = true;
      this.annotation2.Shape.Left = 56;
      this.annotation2.Shape.Right = 308;
      this.annotation2.Shape.Top = 43;
      this.annotation2.Shape.Transparent = true;
      this.annotation2.Shape.Font.Color = System.Drawing.Color.DarkBlue;
      this.annotation2.Text = "  2012 - 2013 Source: Steema Software SL";
      this.annotation2.Top = 43;
      // 
      // scrollPager1
      // 
      this.scrollPager1.DivisionRatio = 8D;
      // 
      // ScrollerChart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 422);
      this.Controls.Add(this.tChart1);
      this.Name = "ScrollerChart";
      this.Text = "ScrollerChart";
      this.Load += new System.EventHandler(this.ScrollerChart_Load);
      this.Resize += new System.EventHandler(this.ScrollerChart_Resize);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Tools.Annotation annotation1;
        private Steema.TeeChart.Tools.Annotation annotation2;
        private Steema.TeeChart.Tools.MarksTip marksTip1;
        private Steema.TeeChart.Tools.ScrollPager scrollPager1;
    }
}