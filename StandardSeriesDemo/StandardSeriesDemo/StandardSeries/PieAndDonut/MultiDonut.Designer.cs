namespace StandardSeriesDemo.StandardSeries.PieAndDonut
{
    partial class MultiDonut
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiDonut));
      Steema.TeeChart.Animations.EasingFunctions.BounceEase bounceEase1 = new Steema.TeeChart.Animations.EasingFunctions.BounceEase();
      Steema.TeeChart.Animations.EasingFunctions.CircleEase circleEase1 = new Steema.TeeChart.Animations.EasingFunctions.CircleEase();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tChart4 = new Steema.TeeChart.TChart();
      this.donut4 = new Steema.TeeChart.Styles.Donut();
      this.tChart3 = new Steema.TeeChart.TChart();
      this.donut3 = new Steema.TeeChart.Styles.Donut();
      this.tChart2 = new Steema.TeeChart.TChart();
      this.donut2 = new Steema.TeeChart.Styles.Donut();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.donut1 = new Steema.TeeChart.Styles.Donut();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.tChart5 = new Steema.TeeChart.TChart();
      this.horizBar1 = new Steema.TeeChart.Styles.HorizBar();
      this.chartPartAnimation1 = new Steema.TeeChart.Animations.ChartPartAnimation();
      this.chartPartAnimation2 = new Steema.TeeChart.Animations.ChartPartAnimation();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.tChart4, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.tChart3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.tChart2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.tChart1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.00375F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 267);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tChart4
      // 
      // 
      // 
      // 
      this.tChart4.Aspect.ColorPaletteIndex = 14;
      this.tChart4.Aspect.Elevation = 315;
      this.tChart4.Aspect.ElevationFloat = 315D;
      this.tChart4.Aspect.Orthogonal = false;
      this.tChart4.Aspect.Perspective = 0;
      this.tChart4.Aspect.Rotation = 360;
      this.tChart4.Aspect.RotationFloat = 360D;
      this.tChart4.Aspect.View3D = false;
      this.tChart4.BackColor = System.Drawing.Color.Transparent;
      this.tChart4.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Footer.Font.Bold = true;
      // 
      // 
      // 
      this.tChart4.Footer.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart4.Footer.Lines = new string[] {
        "WHILE SHOPPING"};
      this.tChart4.Footer.Visible = true;
      // 
      // 
      // 
      this.tChart4.Header.Visible = false;
      // 
      // 
      // 
      this.tChart4.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
      // 
      // 
      // 
      this.tChart4.Legend.Font.Bold = true;
      // 
      // 
      // 
      this.tChart4.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.tChart4.Legend.Font.Name = "Segoe UI";
      this.tChart4.Legend.Font.Size = 24;
      this.tChart4.Legend.Font.SizeFloat = 24F;
      this.tChart4.Legend.FontSeriesColor = true;
      this.tChart4.Legend.LegendStyle = Steema.TeeChart.LegendStyles.LastValues;
      // 
      // 
      // 
      this.tChart4.Legend.Symbol.Visible = false;
      this.tChart4.Legend.TopLeftPos = 5;
      this.tChart4.Legend.Transparent = true;
      this.tChart4.Legend.VertSpacing = -10;
      this.tChart4.Location = new System.Drawing.Point(633, 3);
      this.tChart4.Name = "tChart4";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart4.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart4.Panel.Brush.Gradient.Visible = false;
      this.tChart4.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
      this.tChart4.Panel.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
      this.tChart4.Panel.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
      this.tChart4.Panel.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
      this.tChart4.Panel.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
      this.tChart4.Panel.MarginBottom = 2D;
      this.tChart4.Series.Add(this.donut4);
      this.tChart4.Size = new System.Drawing.Size(205, 261);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.SubFooter.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart4.TabIndex = 3;
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
      this.tChart4.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.White;
      // 
      // donut4
      // 
      this.donut4.AutoPenColor = false;
      // 
      // 
      // 
      this.donut4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(93)))));
      this.donut4.Circled = true;
      this.donut4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.donut4.DonutPercent = 60;
      // 
      // 
      // 
      this.donut4.Frame.Circled = true;
      this.donut4.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      // 
      // 
      // 
      // 
      // 
      // 
      this.donut4.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut4.Frame.Width = 4;
      this.donut4.LabelMember = "Labels";
      // 
      // 
      // 
      this.donut4.Marks.Visible = false;
      // 
      // 
      // 
      this.donut4.MarksPie.LegSize = 0;
      this.donut4.MarksPie.VertCenter = false;
      this.donut4.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      this.donut4.OriginalCursor = null;
      // 
      // 
      // 
      this.donut4.OtherSlice.Color = System.Drawing.Color.Empty;
      this.donut4.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      this.donut4.OtherSlice.Text = "";
      this.donut4.OtherSlice.Value = 0D;
      // 
      // 
      // 
      this.donut4.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut4.Pen.Width = 3;
      this.donut4.RotationAngle = 91;
      this.donut4.Title = "donut1";
      this.donut4.UniqueCustomRadius = true;
      // 
      // 
      // 
      this.donut4.XValues.DataMember = "Angle";
      this.donut4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.donut4.YValues.DataMember = "Pie";
      // 
      // tChart3
      // 
      // 
      // 
      // 
      this.tChart3.Aspect.ColorPaletteIndex = 14;
      this.tChart3.Aspect.Elevation = 315;
      this.tChart3.Aspect.ElevationFloat = 315D;
      this.tChart3.Aspect.Orthogonal = false;
      this.tChart3.Aspect.Perspective = 0;
      this.tChart3.Aspect.Rotation = 360;
      this.tChart3.Aspect.RotationFloat = 360D;
      this.tChart3.Aspect.View3D = false;
      this.tChart3.BackColor = System.Drawing.Color.Transparent;
      this.tChart3.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Footer.Font.Bold = true;
      // 
      // 
      // 
      this.tChart3.Footer.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart3.Footer.Lines = new string[] {
        "WHILE HAVING DINNER"};
      this.tChart3.Footer.Visible = true;
      // 
      // 
      // 
      this.tChart3.Header.Visible = false;
      // 
      // 
      // 
      this.tChart3.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
      // 
      // 
      // 
      this.tChart3.Legend.Font.Bold = true;
      // 
      // 
      // 
      this.tChart3.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.tChart3.Legend.Font.Name = "Segoe UI";
      this.tChart3.Legend.Font.Size = 24;
      this.tChart3.Legend.Font.SizeFloat = 24F;
      this.tChart3.Legend.FontSeriesColor = true;
      this.tChart3.Legend.LegendStyle = Steema.TeeChart.LegendStyles.LastValues;
      // 
      // 
      // 
      this.tChart3.Legend.Symbol.Visible = false;
      this.tChart3.Legend.TopLeftPos = 5;
      this.tChart3.Legend.Transparent = true;
      this.tChart3.Legend.VertSpacing = -10;
      this.tChart3.Location = new System.Drawing.Point(423, 3);
      this.tChart3.Name = "tChart3";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart3.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart3.Panel.Brush.Gradient.Visible = false;
      this.tChart3.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
      this.tChart3.Panel.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
      this.tChart3.Panel.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
      this.tChart3.Panel.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
      this.tChart3.Panel.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
      this.tChart3.Panel.MarginBottom = 2D;
      this.tChart3.Series.Add(this.donut3);
      this.tChart3.Size = new System.Drawing.Size(204, 261);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.SubFooter.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart3.TabIndex = 2;
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
      // 
      // donut3
      // 
      this.donut3.AutoPenColor = false;
      // 
      // 
      // 
      this.donut3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(93)))));
      this.donut3.Circled = true;
      this.donut3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.donut3.DonutPercent = 60;
      // 
      // 
      // 
      this.donut3.Frame.Circled = true;
      this.donut3.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      // 
      // 
      // 
      // 
      // 
      // 
      this.donut3.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut3.Frame.Width = 4;
      this.donut3.LabelMember = "Labels";
      // 
      // 
      // 
      this.donut3.Marks.Visible = false;
      // 
      // 
      // 
      this.donut3.MarksPie.LegSize = 0;
      this.donut3.MarksPie.VertCenter = false;
      this.donut3.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      this.donut3.OriginalCursor = null;
      // 
      // 
      // 
      this.donut3.OtherSlice.Color = System.Drawing.Color.Empty;
      this.donut3.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      this.donut3.OtherSlice.Text = "";
      this.donut3.OtherSlice.Value = 0D;
      // 
      // 
      // 
      this.donut3.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut3.Pen.Width = 3;
      this.donut3.RotationAngle = 91;
      this.donut3.Title = "donut1";
      this.donut3.UniqueCustomRadius = true;
      // 
      // 
      // 
      this.donut3.XValues.DataMember = "Angle";
      this.donut3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.donut3.YValues.DataMember = "Pie";
      // 
      // tChart2
      // 
      // 
      // 
      // 
      this.tChart2.Aspect.ColorPaletteIndex = 14;
      this.tChart2.Aspect.Elevation = 315;
      this.tChart2.Aspect.ElevationFloat = 315D;
      this.tChart2.Aspect.Orthogonal = false;
      this.tChart2.Aspect.Perspective = 0;
      this.tChart2.Aspect.Rotation = 360;
      this.tChart2.Aspect.RotationFloat = 360D;
      this.tChart2.Aspect.View3D = false;
      this.tChart2.BackColor = System.Drawing.Color.Transparent;
      this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Footer.Font.Bold = true;
      // 
      // 
      // 
      this.tChart2.Footer.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart2.Footer.Lines = new string[] {
        "WHILE COMMUTING"};
      this.tChart2.Footer.Visible = true;
      // 
      // 
      // 
      this.tChart2.Header.Visible = false;
      // 
      // 
      // 
      this.tChart2.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
      // 
      // 
      // 
      this.tChart2.Legend.Font.Bold = true;
      // 
      // 
      // 
      this.tChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.tChart2.Legend.Font.Name = "Segoe UI";
      this.tChart2.Legend.Font.Size = 24;
      this.tChart2.Legend.Font.SizeFloat = 24F;
      this.tChart2.Legend.FontSeriesColor = true;
      this.tChart2.Legend.LegendStyle = Steema.TeeChart.LegendStyles.LastValues;
      // 
      // 
      // 
      this.tChart2.Legend.Symbol.Visible = false;
      this.tChart2.Legend.TopLeftPos = 5;
      this.tChart2.Legend.Transparent = true;
      this.tChart2.Legend.VertSpacing = -10;
      this.tChart2.Location = new System.Drawing.Point(213, 3);
      this.tChart2.Name = "tChart2";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart2.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart2.Panel.Brush.Gradient.Visible = false;
      this.tChart2.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
      this.tChart2.Panel.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
      this.tChart2.Panel.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
      this.tChart2.Panel.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
      this.tChart2.Panel.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
      this.tChart2.Panel.MarginBottom = 2D;
      this.tChart2.Series.Add(this.donut2);
      this.tChart2.Size = new System.Drawing.Size(204, 261);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.SubFooter.Font.Brush.Color = System.Drawing.Color.Gray;
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
      // 
      // donut2
      // 
      this.donut2.AutoPenColor = false;
      // 
      // 
      // 
      this.donut2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(93)))));
      this.donut2.Circled = true;
      this.donut2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.donut2.DonutPercent = 60;
      // 
      // 
      // 
      this.donut2.Frame.Circled = true;
      this.donut2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      // 
      // 
      // 
      // 
      // 
      // 
      this.donut2.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut2.Frame.Width = 4;
      this.donut2.LabelMember = "Labels";
      // 
      // 
      // 
      this.donut2.Marks.Visible = false;
      // 
      // 
      // 
      this.donut2.MarksPie.LegSize = 0;
      this.donut2.MarksPie.VertCenter = false;
      this.donut2.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
      this.donut2.OriginalCursor = null;
      // 
      // 
      // 
      this.donut2.OtherSlice.Color = System.Drawing.Color.Empty;
      this.donut2.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
      this.donut2.OtherSlice.Text = "";
      this.donut2.OtherSlice.Value = 0D;
      // 
      // 
      // 
      this.donut2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut2.Pen.Width = 3;
      this.donut2.RotationAngle = 91;
      this.donut2.Title = "donut1";
      this.donut2.UniqueCustomRadius = true;
      // 
      // 
      // 
      this.donut2.XValues.DataMember = "Angle";
      this.donut2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.donut2.YValues.DataMember = "Pie";
      // 
      // tChart1
      // 
      this.tChart1.Animations.Add(this.chartPartAnimation2);
      // 
      // 
      // 
      this.tChart1.Aspect.ColorPaletteIndex = 21;
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
      this.tChart1.Footer.Font.Bold = true;
      // 
      // 
      // 
      this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Footer.Lines = new string[] {
        "LATE AT NIGHT IN BED"};
      this.tChart1.Footer.Visible = true;
      // 
      // 
      // 
      this.tChart1.Header.Visible = false;
      // 
      // 
      // 
      this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
      // 
      // 
      // 
      this.tChart1.Legend.Font.Bold = true;
      // 
      // 
      // 
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.tChart1.Legend.Font.Name = "Segoe UI";
      this.tChart1.Legend.Font.Size = 24;
      this.tChart1.Legend.Font.SizeFloat = 24F;
      this.tChart1.Legend.FontSeriesColor = true;
      this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.LastValues;
      // 
      // 
      // 
      this.tChart1.Legend.Symbol.Visible = false;
      this.tChart1.Legend.TopLeftPos = 5;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Legend.VertSpacing = -10;
      this.tChart1.Location = new System.Drawing.Point(3, 3);
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
      this.tChart1.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
      this.tChart1.Panel.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
      this.tChart1.Panel.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
      this.tChart1.Panel.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
      this.tChart1.Panel.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
      this.tChart1.Panel.MarginBottom = 2D;
      this.tChart1.Series.Add(this.donut1);
      this.tChart1.Size = new System.Drawing.Size(204, 261);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Gray;
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
      // donut1
      // 
      this.donut1.AutoPenColor = false;
      // 
      // 
      // 
      this.donut1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.donut1.Circled = true;
      this.donut1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.donut1.DonutPercent = 60;
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
      this.donut1.Frame.Width = 4;
      this.donut1.LabelMember = "Labels";
      // 
      // 
      // 
      this.donut1.Marks.Visible = false;
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
      // 
      // 
      // 
      this.donut1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut1.Pen.Width = 3;
      this.donut1.RotationAngle = 91;
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
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 518);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(841, 22);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label1.Location = new System.Drawing.Point(0, 6);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.label1.Size = new System.Drawing.Size(145, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ericson consumerLab.   2014";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Controls.Add(this.label2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(841, 30);
      this.panel2.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.label2.Size = new System.Drawing.Size(403, 23);
      this.label2.TabIndex = 0;
      this.label2.Text = "Where do customers watch mobile video content ?";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tChart5
      // 
      this.tChart5.Animations.Add(this.chartPartAnimation1);
      // 
      // 
      // 
      this.tChart5.Aspect.ColorPaletteIndex = 14;
      this.tChart5.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart5.Axes.Bottom.AxisPen.Visible = false;
      // 
      // 
      // 
      this.tChart5.Axes.Bottom.Grid.Visible = false;
      // 
      // 
      // 
      this.tChart5.Axes.Bottom.MinorTicks.Visible = false;
      this.tChart5.Axes.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart5.Axes.Left.AxisPen.Color = System.Drawing.Color.Gray;
      this.tChart5.Axes.Left.AxisPen.Width = 1;
      // 
      // 
      // 
      this.tChart5.Axes.Left.Grid.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart5.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart5.Axes.Left.Labels.Font.Name = "Segoe UI";
      this.tChart5.Axes.Left.Labels.Font.Size = 16;
      this.tChart5.Axes.Left.Labels.Font.SizeFloat = 16F;
      // 
      // 
      // 
      this.tChart5.Axes.Left.MinorTicks.Visible = false;
      this.tChart5.BackColor = System.Drawing.Color.Transparent;
      this.tChart5.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart5.Footer.Font.Brush.Color = System.Drawing.Color.Blue;
      // 
      // 
      // 
      this.tChart5.Header.Visible = false;
      // 
      // 
      // 
      this.tChart5.Legend.Visible = false;
      this.tChart5.Location = new System.Drawing.Point(0, 297);
      this.tChart5.Name = "tChart5";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart5.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart5.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart5.Series.Add(this.horizBar1);
      this.tChart5.Size = new System.Drawing.Size(841, 221);
      this.tChart5.TabIndex = 3;
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
      this.tChart5.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart5.Walls.Back.Visible = false;
      this.tChart5.DoubleClick += new System.EventHandler(this.tChart5_DoubleClick);
      // 
      // horizBar1
      // 
      this.horizBar1.BarHeightPercent = 90;
      this.horizBar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      this.horizBar1.BarStyle = Steema.TeeChart.Styles.BarStyles.RoundRectangle;
      // 
      // 
      // 
      this.horizBar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      // 
      // 
      // 
      this.horizBar1.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
      this.horizBar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.horizBar1.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.horizBar1.Marks.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.horizBar1.Marks.Font.Brush.Color = System.Drawing.Color.Gray;
      this.horizBar1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;
      this.horizBar1.Marks.Transparent = true;
      this.horizBar1.OriginalCursor = null;
      // 
      // 
      // 
      this.horizBar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(140)))), ((int)(((byte)(85)))));
      this.horizBar1.Pen.Visible = false;
      this.horizBar1.Title = "horizBar1";
      this.horizBar1.ValueFormat = "## %";
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
      // chartPartAnimation1
      // 
      this.chartPartAnimation1.Axis = null;
      bounceEase1.EasingMode = Steema.TeeChart.Animations.EasingFunctions.EasingMode.EaseOut;
      this.chartPartAnimation1.EasingFunction = bounceEase1;
      this.chartPartAnimation1.EasingMode = Steema.TeeChart.Animations.EasingFunctions.EasingMode.EaseOut;
      this.chartPartAnimation1.Fade = Steema.TeeChart.Animations.TransformFade.None;
      this.chartPartAnimation1.RotateMax = 0F;
      this.chartPartAnimation1.RotateMin = 0F;
      this.chartPartAnimation1.Series = null;
      this.chartPartAnimation1.Speed = 1000;
      this.chartPartAnimation1.Target = Steema.TeeChart.ChartClickedPartStyle.Series;
      this.chartPartAnimation1.ZoomStyle = Steema.TeeChart.Animations.TransformZoom.None;
      // 
      // chartPartAnimation2
      // 
      this.chartPartAnimation2.Axis = null;
      circleEase1.EasingMode = Steema.TeeChart.Animations.EasingFunctions.EasingMode.EaseIn;
      this.chartPartAnimation2.EasingFunction = circleEase1;
      this.chartPartAnimation2.EasingMode = Steema.TeeChart.Animations.EasingFunctions.EasingMode.EaseIn;
      this.chartPartAnimation2.Fade = Steema.TeeChart.Animations.TransformFade.In;
      this.chartPartAnimation2.RotateMax = 360F;
      this.chartPartAnimation2.RotateMin = 0F;
      this.chartPartAnimation2.Series = null;
      this.chartPartAnimation2.Speed = 1000;
      this.chartPartAnimation2.Target = Steema.TeeChart.ChartClickedPartStyle.Series;
      this.chartPartAnimation2.TranslateStyle = Steema.TeeChart.Animations.TransformTranslate.None;
      this.chartPartAnimation2.ZoomStyle = Steema.TeeChart.Animations.TransformZoom.None;
      // 
      // MultiDonut
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(841, 540);
      this.Controls.Add(this.tChart5);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.panel2);
      this.Name = "MultiDonut";
      this.Text = "MultiDonut";
      this.Load += new System.EventHandler(this.MultiDonut_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Steema.TeeChart.TChart tChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Steema.TeeChart.TChart tChart4;
        private Steema.TeeChart.TChart tChart3;
        private Steema.TeeChart.TChart tChart2;
        private Steema.TeeChart.TChart tChart5;
        private Steema.TeeChart.Styles.Donut donut4;
        private Steema.TeeChart.Styles.Donut donut3;
        private Steema.TeeChart.Styles.Donut donut2;
        private Steema.TeeChart.Styles.Donut donut1;
        private Steema.TeeChart.Styles.HorizBar horizBar1;
        private Steema.TeeChart.Animations.ChartPartAnimation chartPartAnimation2;
        private Steema.TeeChart.Animations.ChartPartAnimation chartPartAnimation1;
    }
}