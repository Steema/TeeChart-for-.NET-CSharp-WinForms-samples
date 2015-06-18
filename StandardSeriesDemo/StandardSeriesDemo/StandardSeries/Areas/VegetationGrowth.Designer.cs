namespace StandardSeriesDemo.StandardSeries.Areas
{
    partial class VegetationGrowth
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
      this.area1 = new Steema.TeeChart.Styles.Area();
      this.area2 = new Steema.TeeChart.Styles.Area();
      this.area3 = new Steema.TeeChart.Styles.Area();
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
      this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.tChart1.Axes.Bottom.Grid.Visible = false;
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
      this.tChart1.Axes.Bottom.Title.Caption = "Days";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Bottom.Title.Font.Name = "Segoe UI";
      this.tChart1.Axes.Bottom.Title.Lines = new string[] {
        "Days"};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Name = "Roboto Th";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Name = "Roboto Th";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
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
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Name = "Roboto Th";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Grid.Visible = false;
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
      this.tChart1.Axes.Right.Title.Font.Name = "Roboto Th";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Name = "Roboto Th";
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
      this.tChart1.Header.Alignment = System.Drawing.StringAlignment.Near;
      // 
      // 
      // 
      this.tChart1.Header.Font.Bold = true;
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
      this.tChart1.Header.Font.Italic = true;
      this.tChart1.Header.Font.Name = "Roboto Lt";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Header.Font.Shadow.SmoothBlur = 2;
      this.tChart1.Header.Font.Size = 14;
      this.tChart1.Header.Font.SizeFloat = 14F;
      this.tChart1.Header.Lines = new string[] {
        "Vegetation growth"};
      // 
      // 
      // 
      this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
      // 
      // 
      // 
      this.tChart1.Legend.Font.Name = "Roboto Th";
      this.tChart1.Legend.Font.Size = 14;
      this.tChart1.Legend.Font.SizeFloat = 14F;
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
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
      this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart1.Series.Add(this.area1);
      this.tChart1.Series.Add(this.area2);
      this.tChart1.Series.Add(this.area3);
      this.tChart1.Size = new System.Drawing.Size(1037, 508);
      this.tChart1.TabIndex = 0;
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
      // 
      // area1
      // 
      // 
      // 
      // 
      this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      // 
      // 
      // 
      this.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.area1.AreaLines.Transparency = 64;
      this.area1.AreaLines.Visible = false;
      // 
      // 
      // 
      this.area1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      // 
      // 
      // 
      this.area1.TopGradient.Transparency = 64;
      this.area1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      this.area1.ColorEach = false;
      // 
      // 
      // 
      this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.area1.LinePen.Transparency = 64;
      this.area1.LinePen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area1.Marks.Arrow.Transparency = 64;
      this.area1.Marks.Arrow.Visible = false;
      this.area1.Marks.ArrowLength = 0;
      // 
      // 
      // 
      this.area1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
      // 
      // 
      // 
      this.area1.Marks.Brush.Gradient.Transparency = 64;
      this.area1.Marks.Clip = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.area1.Marks.Font.Brush.Gradient.Transparency = 64;
      this.area1.Marks.Font.Name = "Roboto Th";
      // 
      // 
      // 
      this.area1.Marks.Pen.Transparency = 64;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area1.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      this.area1.Marks.Shadow.Brush.Gradient.Transparency = 64;
      this.area1.Marks.Transparent = true;
      this.area1.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.area1.Pointer.Brush.Gradient.Transparency = 64;
      // 
      // 
      // 
      this.area1.Pointer.Pen.Transparency = 64;
      this.area1.Pointer.SizeDouble = 0D;
      this.area1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.area1.Title = "With nutrient";
      this.area1.Transparency = 64;
      // 
      // 
      // 
      this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // area2
      // 
      // 
      // 
      // 
      this.area2.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.area2.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.area2.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.area2.AreaLines.Transparency = 70;
      this.area2.AreaLines.Visible = false;
      // 
      // 
      // 
      this.area2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.area2.TopGradient.Transparency = 70;
      this.area2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.area2.ColorEach = false;
      // 
      // 
      // 
      this.area2.LinePen.Color = System.Drawing.Color.Purple;
      this.area2.LinePen.Transparency = 70;
      this.area2.LinePen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area2.Marks.Arrow.Transparency = 70;
      this.area2.Marks.Arrow.Visible = false;
      this.area2.Marks.ArrowLength = 0;
      // 
      // 
      // 
      this.area2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
      // 
      // 
      // 
      this.area2.Marks.Brush.Gradient.Transparency = 70;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.area2.Marks.Font.Brush.Gradient.Transparency = 70;
      this.area2.Marks.Font.Name = "Roboto Th";
      // 
      // 
      // 
      this.area2.Marks.Pen.Transparency = 70;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area2.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      this.area2.Marks.Shadow.Brush.Gradient.Transparency = 70;
      this.area2.Marks.Transparent = true;
      this.area2.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.area2.Pointer.Brush.Gradient.Transparency = 70;
      // 
      // 
      // 
      this.area2.Pointer.Pen.Transparency = 70;
      this.area2.Pointer.SizeDouble = 0D;
      this.area2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.area2.Title = "No added nutrient";
      this.area2.Transparency = 70;
      // 
      // 
      // 
      this.area2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // area3
      // 
      // 
      // 
      // 
      this.area3.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.area3.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.area3.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.area3.AreaLines.Transparency = 47;
      this.area3.AreaLines.Visible = false;
      // 
      // 
      // 
      this.area3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      // 
      // 
      // 
      this.area3.TopGradient.Transparency = 47;
      this.area3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      this.area3.ColorEach = false;
      // 
      // 
      // 
      this.area3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
      this.area3.LinePen.Transparency = 47;
      this.area3.LinePen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area3.Marks.Arrow.Transparency = 47;
      this.area3.Marks.Arrow.Visible = false;
      this.area3.Marks.ArrowLength = 0;
      // 
      // 
      // 
      this.area3.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
      // 
      // 
      // 
      this.area3.Marks.Brush.Gradient.Transparency = 47;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area3.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.area3.Marks.Font.Brush.Gradient.Transparency = 47;
      this.area3.Marks.Font.Name = "Roboto Th";
      // 
      // 
      // 
      this.area3.Marks.Pen.Transparency = 47;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area3.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      this.area3.Marks.Shadow.Brush.Gradient.Transparency = 47;
      this.area3.Marks.Transparent = true;
      this.area3.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.area3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.area3.Pointer.Brush.Gradient.Transparency = 47;
      // 
      // 
      // 
      this.area3.Pointer.Pen.Transparency = 47;
      this.area3.Pointer.SizeDouble = 0D;
      this.area3.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.area3.Title = "Series2";
      this.area3.Transparency = 47;
      this.area3.Visible = false;
      // 
      // 
      // 
      this.area3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // VegetationGrowth
      // 
      this.ClientSize = new System.Drawing.Size(1037, 508);
      this.Controls.Add(this.tChart1);
      this.Name = "VegetationGrowth";
      this.Load += new System.EventHandler(this.VegetationGrowth_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Area area1;
        private Steema.TeeChart.Styles.Area area2;
        private Steema.TeeChart.Styles.Area area3;
    }
}