namespace StandardSeriesDemo.StandardSeries.PieAndDonut
{
    partial class DonutChart
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonutChart));
      this.tChart1 = new Steema.TeeChart.TChart();
      this.donut1 = new Steema.TeeChart.Styles.Donut();
      this.SuspendLayout();
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ColorPaletteIndex = 17;
      this.tChart1.Aspect.Elevation = 315;
      this.tChart1.Aspect.ElevationFloat = 315D;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 0;
      this.tChart1.Aspect.Rotation = 360;
      this.tChart1.Aspect.RotationFloat = 360D;
      this.tChart1.Aspect.View3D = false;
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
      this.tChart1.Header.Font.Size = 21;
      this.tChart1.Header.Font.SizeFloat = 21F;
      this.tChart1.Header.Lines = new string[] {
        "Countries by Area"};
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Name = "Segoe UI";
      this.tChart1.Legend.Font.Size = 19;
      this.tChart1.Legend.Font.SizeFloat = 19F;
      this.tChart1.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.Plain;
      this.tChart1.Legend.Transparent = true;
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
      this.tChart1.Series.Add(this.donut1);
      this.tChart1.Size = new System.Drawing.Size(752, 400);
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
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart1_DoubleClick);
      // 
      // donut1
      // 
      this.donut1.BevelPercent = 6;
      // 
      // 
      // 
      this.donut1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(113)))), ((int)(((byte)(230)))));
      this.donut1.Circled = true;
      this.donut1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(162)))));
      this.donut1.Dark3D = false;
      // 
      // 
      // 
      this.donut1.Frame.Circled = true;
      this.donut1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      // 
      // 
      // 
      // 
      // 
      // 
      this.donut1.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut1.LabelMember = "Labels";
      // 
      // 
      // 
      // 
      // 
      // 
      this.donut1.Marks.Arrow.Color = System.Drawing.Color.Silver;
      this.donut1.Marks.Arrow.Width = 2;
      this.donut1.Marks.ArrowLength = 14;
      // 
      // 
      // 
      this.donut1.Marks.Brush.Visible = false;
      this.donut1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.LabelPercent;
      this.donut1.Marks.Transparent = true;
      // 
      // 
      // 
      this.donut1.MarksPie.LegSize = 0;
      this.donut1.MarksPie.VertCenter = false;
      this.donut1.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      this.donut1.OriginalCursor = null;
      // 
      // 
      // 
      this.donut1.OtherSlice.Color = System.Drawing.Color.Empty;
      this.donut1.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      this.donut1.OtherSlice.Text = "";
      this.donut1.OtherSlice.Value = 0D;
      this.donut1.SeriesData = resources.GetString("donut1.SeriesData");
      this.donut1.Title = "donut1";
      this.donut1.UniqueCustomRadius = true;
      // 
      // 
      // 
      this.donut1.XValues.DataMember = "Angle";
      this.donut1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.donut1.YValues.DataMember = "Pie";
      // 
      // DonutChart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(752, 400);
      this.Controls.Add(this.tChart1);
      this.Name = "DonutChart";
      this.Tag = "DonutChart";
      this.Text = "DonutChart";
      this.Load += new System.EventHandler(this.DonutChart_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Donut donut1;
    }
}