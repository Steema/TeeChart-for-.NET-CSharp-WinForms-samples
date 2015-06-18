namespace StandardSeriesDemo.StandardSeries.Points
{
    partial class ProductShipments
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
      this.points1 = new Steema.TeeChart.Styles.Points();
      this.points2 = new Steema.TeeChart.Styles.Points();
      this.line1 = new Steema.TeeChart.Styles.Line();
      this.average1 = new Steema.TeeChart.Functions.Average();
      this.smoothing1 = new Steema.TeeChart.Functions.Smoothing();
      this.line2 = new Steema.TeeChart.Styles.Line();
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
      this.tChart1.Axes.Bottom.AxisPen.Visible = false;
      this.tChart1.Axes.Bottom.AxisPen.Width = 0;
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
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Bottom.Labels.Font.Size = 24;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 24F;
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
      // 
      // 
      // 
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Left.Labels.Font.Size = 24;
      this.tChart1.Axes.Left.Labels.Font.SizeFloat = 24F;
      this.tChart1.Axes.Left.MinimumOffset = 10;
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
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Header.Font.Shadow.SmoothBlur = 2;
      this.tChart1.Header.Font.Size = 33;
      this.tChart1.Header.Font.SizeFloat = 33F;
      this.tChart1.Header.Lines = new string[] {
        "Product shipments"};
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Size = 19;
      this.tChart1.Legend.Font.SizeFloat = 19F;
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
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.points1);
      this.tChart1.Series.Add(this.points2);
      this.tChart1.Series.Add(this.line1);
      this.tChart1.Series.Add(this.line2);
      this.tChart1.Size = new System.Drawing.Size(1221, 511);
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
      this.tChart1.Walls.Visible = false;
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart1_DoubleClick);
      // 
      // points1
      // 
      this.points1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.points1.ColorEach = false;
      // 
      // 
      // 
      this.points1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.points1.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.points1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.points1.Pointer.SizeDouble = 0D;
      this.points1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.points1.Title = "points1";
      // 
      // 
      // 
      this.points1.XValues.DataMember = "X";
      this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.points1.YValues.DataMember = "Y";
      // 
      // points2
      // 
      this.points2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.points2.ColorEach = false;
      // 
      // 
      // 
      this.points2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.points2.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.points2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      // 
      // 
      // 
      this.points2.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.points2.Pointer.SizeDouble = 0D;
      this.points2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.points2.Title = "points2";
      // 
      // 
      // 
      this.points2.XValues.DataMember = "X";
      this.points2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.points2.YValues.DataMember = "Y";
      // 
      // line1
      // 
      // 
      // 
      // 
      this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.line1.ColorEach = false;
      this.line1.DataSource = new object[] {
        ((object)(this.points1)),
        ((object)(this.points2))};
      this.line1.Function = this.average1;
      // 
      // 
      // 
      this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
      this.line1.OriginalCursor = null;
      // 
      // 
      // 
      this.line1.Pointer.SizeDouble = 0D;
      this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line1.Title = "line1";
      // 
      // 
      // 
      this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // average1
      // 
      this.average1.Period = 2D;
      // 
      // smoothing1
      // 
      this.smoothing1.Factor = 8;
      this.smoothing1.Period = 1D;
      // 
      // line2
      // 
      // 
      // 
      // 
      this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
      this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
      this.line2.ColorEach = false;
      // 
      // 
      // 
      this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
      this.line2.LinePen.Width = 2;
      this.line2.OriginalCursor = null;
      // 
      // 
      // 
      this.line2.Pointer.SizeDouble = 0D;
      this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line2.Title = "line2";
      // 
      // 
      // 
      this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // ProductShipments
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1221, 511);
      this.Controls.Add(this.tChart1);
      this.Name = "ProductShipments";
      this.Text = "ProductShipments";
      this.Load += new System.EventHandler(this.ProductShipments_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Points points1;
        private Steema.TeeChart.Styles.Points points2;
        private Steema.TeeChart.Functions.Smoothing smoothing1;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Functions.Average average1;
        private Steema.TeeChart.Styles.Line line2;
    }
}