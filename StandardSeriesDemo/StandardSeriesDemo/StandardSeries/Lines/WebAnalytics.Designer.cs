namespace StandardSeriesDemo.StandardSeries.Lines
{
    partial class WebAnalytics
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebAnalytics));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tChart3 = new Steema.TeeChart.TChart();
      this.donut3 = new Steema.TeeChart.Styles.Donut();
      this.annotation3 = new Steema.TeeChart.Tools.Annotation();
      this.tChart2 = new Steema.TeeChart.TChart();
      this.donut2 = new Steema.TeeChart.Styles.Donut();
      this.annotation2 = new Steema.TeeChart.Tools.Annotation();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tChart4 = new Steema.TeeChart.TChart();
      this.line1 = new Steema.TeeChart.Styles.Line();
      this.line2 = new Steema.TeeChart.Styles.Line();
      this.line3 = new Steema.TeeChart.Styles.Line();
      this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
      this.annotation4 = new Steema.TeeChart.Tools.Annotation();
      this.cursorTool2 = new Steema.TeeChart.Tools.CursorTool();
      this.annotation6 = new Steema.TeeChart.Tools.Annotation();
      this.cursorTool3 = new Steema.TeeChart.Tools.CursorTool();
      this.annotation8 = new Steema.TeeChart.Tools.Annotation();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.donut1 = new Steema.TeeChart.Styles.Donut();
      this.annotation1 = new Steema.TeeChart.Tools.Annotation();
      this.textSource1 = new Steema.TeeChart.Data.TextSource();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Controls.Add(this.tChart3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.tChart2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tChart1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.1733F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.8267F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 427);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tChart3
      // 
      // 
      // 
      // 
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
      // 
      // 
      // 
      this.tChart3.Footer.Font.Brush.Color = System.Drawing.Color.Gray;
      // 
      // 
      // 
      this.tChart3.Header.Visible = false;
      // 
      // 
      // 
      this.tChart3.Legend.Visible = false;
      this.tChart3.Location = new System.Drawing.Point(525, 3);
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
      this.tChart3.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart3.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart3.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart3.Series.Add(this.donut3);
      this.tChart3.Size = new System.Drawing.Size(257, 156);
      this.tChart3.TabIndex = 3;
      this.tChart3.Tools.Add(this.annotation3);
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
      this.tChart3.DoubleClick += new System.EventHandler(this.chartdoubleclick);
      // 
      // donut3
      // 
      // 
      // 
      // 
      this.donut3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.donut3.Circled = true;
      this.donut3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.donut3.DonutPercent = 95;
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
      this.donut3.RotationAngle = 180;
      this.donut3.SeriesData = resources.GetString("donut3.SeriesData");
      // 
      // 
      // 
      this.donut3.Shadow.Height = 3;
      this.donut3.Shadow.Width = 3;
      this.donut3.Title = "Series0";
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
      // annotation3
      // 
      this.annotation3.AutoSize = true;
      // 
      // 
      // 
      this.annotation3.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.annotation3.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.annotation3.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.annotation3.Callout.Brush.Color = System.Drawing.Color.Black;
      this.annotation3.Callout.Distance = 0;
      this.annotation3.Callout.Draw3D = false;
      this.annotation3.Callout.SizeDouble = 0D;
      this.annotation3.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.annotation3.Callout.XPosition = 0;
      this.annotation3.Callout.YPosition = 0;
      this.annotation3.Callout.ZPosition = 0;
      this.annotation3.Cursor = System.Windows.Forms.Cursors.Default;
      this.annotation3.Position = Steema.TeeChart.Tools.AnnotationPositions.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.annotation3.Shape.Font.Name = "Segoe UI";
      this.annotation3.Shape.Font.Size = 29;
      this.annotation3.Shape.Font.SizeFloat = 29F;
      this.annotation3.Shape.Lines = new string[] {
        "$1500"};
      this.annotation3.Shape.Transparent = true;
      this.annotation3.Text = "$1500";
      // 
      // tChart2
      // 
      // 
      // 
      // 
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
      // 
      // 
      // 
      this.tChart2.Footer.Font.Brush.Color = System.Drawing.Color.Gray;
      // 
      // 
      // 
      this.tChart2.Header.Visible = false;
      // 
      // 
      // 
      this.tChart2.Legend.Visible = false;
      this.tChart2.Location = new System.Drawing.Point(264, 3);
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
      this.tChart2.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart2.Series.Add(this.donut2);
      this.tChart2.Size = new System.Drawing.Size(255, 156);
      this.tChart2.TabIndex = 2;
      this.tChart2.Tools.Add(this.annotation2);
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
      this.tChart2.DoubleClick += new System.EventHandler(this.chartdoubleclick);
      // 
      // donut2
      // 
      // 
      // 
      // 
      this.donut2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.donut2.Circled = true;
      this.donut2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.donut2.DonutPercent = 95;
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
      this.donut2.RotationAngle = 247;
      this.donut2.SeriesData = resources.GetString("donut2.SeriesData");
      // 
      // 
      // 
      this.donut2.Shadow.Height = 3;
      this.donut2.Shadow.Width = 3;
      this.donut2.Title = "Series0";
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
      this.annotation2.Position = Steema.TeeChart.Tools.AnnotationPositions.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.annotation2.Shape.Font.Name = "Segoe UI";
      this.annotation2.Shape.Font.Size = 29;
      this.annotation2.Shape.Font.SizeFloat = 29F;
      this.annotation2.Shape.Lines = new string[] {
        "3390"};
      this.annotation2.Shape.Transparent = true;
      this.annotation2.Text = "3390";
      // 
      // panel1
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
      this.panel1.Controls.Add(this.tChart4);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 165);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(779, 259);
      this.panel1.TabIndex = 0;
      // 
      // tChart4
      // 
      // 
      // 
      // 
      this.tChart4.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Axes.Bottom.MinorTicks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Axes.Left.Grid.Visible = false;
      this.tChart4.Axes.Left.Increment = 20D;
      // 
      // 
      // 
      this.tChart4.Axes.Left.MinorTicks.Visible = false;
      this.tChart4.BackColor = System.Drawing.Color.Transparent;
      this.tChart4.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Footer.Font.Brush.Color = System.Drawing.Color.Blue;
      // 
      // 
      // 
      this.tChart4.Header.Visible = false;
      // 
      // 
      // 
      this.tChart4.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
      this.tChart4.Legend.Transparent = true;
      this.tChart4.Location = new System.Drawing.Point(0, 0);
      this.tChart4.Name = "tChart4";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart4.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart4.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart4.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart4.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart4.Series.Add(this.line1);
      this.tChart4.Series.Add(this.line2);
      this.tChart4.Series.Add(this.line3);
      this.tChart4.Size = new System.Drawing.Size(779, 259);
      this.tChart4.TabIndex = 0;
      this.tChart4.Tools.Add(this.cursorTool1);
      this.tChart4.Tools.Add(this.annotation4);
      this.tChart4.Tools.Add(this.cursorTool2);
      this.tChart4.Tools.Add(this.annotation6);
      this.tChart4.Tools.Add(this.cursorTool3);
      this.tChart4.Tools.Add(this.annotation8);
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
      this.tChart4.Walls.Back.Visible = false;
      this.tChart4.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart4_AfterDraw);
      this.tChart4.DoubleClick += new System.EventHandler(this.chartdoubleclick);
      // 
      // line1
      // 
      // 
      // 
      // 
      this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.line1.ColorEach = false;
      this.line1.ColorMember = "Colors";
      this.line1.Colors = ((Steema.TeeChart.Styles.ColorList)(resources.GetObject("line1.Colors")));
      // 
      // 
      // 
      this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.line1.LinePen.Width = 4;
      this.line1.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Pointer.Pen.Visible = false;
      this.line1.Pointer.SizeDouble = 0D;
      this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
      this.line1.Title = "Speed";
      // 
      // 
      // 
      this.line1.XValues.DataMember = "X";
      this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line1.YValues.DataMember = "Y";
      // 
      // line2
      // 
      // 
      // 
      // 
      this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
      this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
      this.line2.ColorEach = false;
      // 
      // 
      // 
      this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.line2.LinePen.Width = 4;
      this.line2.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Pointer.Pen.Visible = false;
      this.line2.Pointer.SizeDouble = 0D;
      this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
      this.line2.Title = "Time";
      // 
      // 
      // 
      this.line2.XValues.DataMember = "X";
      this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line2.YValues.DataMember = "Y";
      // 
      // line3
      // 
      // 
      // 
      // 
      this.line3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
      this.line3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
      this.line3.ColorEach = false;
      this.line3.ColorMember = "Colors";
      this.line3.Colors = ((Steema.TeeChart.Styles.ColorList)(resources.GetObject("line3.Colors")));
      // 
      // 
      // 
      this.line3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.line3.LinePen.Width = 4;
      this.line3.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line3.Pointer.Pen.Visible = false;
      this.line3.Pointer.SizeDouble = 0D;
      this.line3.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
      this.line3.Title = "Visitors";
      // 
      // 
      // 
      this.line3.XValues.DataMember = "X";
      this.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line3.YValues.DataMember = "Y";
      // 
      // cursorTool1
      // 
      this.cursorTool1.FollowMouse = true;
      // 
      // 
      // 
      this.cursorTool1.Pen.Color = System.Drawing.Color.Gray;
      this.cursorTool1.Series = this.line1;
      this.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
      this.cursorTool1.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool1_Change);
      // 
      // annotation4
      // 
      this.annotation4.AutoSize = true;
      // 
      // 
      // 
      this.annotation4.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.annotation4.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.annotation4.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.annotation4.Callout.Brush.Color = System.Drawing.Color.Black;
      this.annotation4.Callout.Distance = 0;
      this.annotation4.Callout.Draw3D = false;
      this.annotation4.Callout.SizeDouble = 0D;
      this.annotation4.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.annotation4.Callout.XPosition = 0;
      this.annotation4.Callout.YPosition = 0;
      this.annotation4.Callout.ZPosition = 0;
      this.annotation4.Cursor = System.Windows.Forms.Cursors.Default;
      this.annotation4.Left = 56;
      // 
      // 
      // 
      this.annotation4.Shape.Bottom = 212;
      // 
      // 
      // 
      this.annotation4.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
      this.annotation4.Shape.CustomPosition = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.annotation4.Shape.Font.Brush.Color = System.Drawing.Color.White;
      this.annotation4.Shape.Left = 56;
      this.annotation4.Shape.Lines = new string[] {
        "0"};
      // 
      // 
      // 
      this.annotation4.Shape.Pen.Visible = false;
      this.annotation4.Shape.Right = 75;
      // 
      // 
      // 
      this.annotation4.Shape.Shadow.Visible = false;
      this.annotation4.Shape.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
      this.annotation4.Shape.Top = 194;
      this.annotation4.Shape.Visible = false;
      this.annotation4.Text = "0";
      this.annotation4.TextAlign = System.Drawing.StringAlignment.Center;
      this.annotation4.Top = 194;
      // 
      // cursorTool2
      // 
      this.cursorTool2.FollowMouse = true;
      // 
      // 
      // 
      this.cursorTool2.Pen.Color = System.Drawing.Color.Gray;
      this.cursorTool2.Series = this.line2;
      this.cursorTool2.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
      // 
      // annotation6
      // 
      this.annotation6.AutoSize = true;
      // 
      // 
      // 
      this.annotation6.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.annotation6.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.annotation6.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.annotation6.Callout.Brush.Color = System.Drawing.Color.Black;
      this.annotation6.Callout.Distance = 0;
      this.annotation6.Callout.Draw3D = false;
      this.annotation6.Callout.SizeDouble = 0D;
      this.annotation6.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.annotation6.Callout.XPosition = 0;
      this.annotation6.Callout.YPosition = 0;
      this.annotation6.Callout.ZPosition = 0;
      this.annotation6.Cursor = System.Windows.Forms.Cursors.Default;
      this.annotation6.Left = -19;
      // 
      // 
      // 
      this.annotation6.Shape.Bottom = 212;
      // 
      // 
      // 
      this.annotation6.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
      this.annotation6.Shape.CustomPosition = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.annotation6.Shape.Font.Brush.Color = System.Drawing.Color.White;
      this.annotation6.Shape.Left = -19;
      this.annotation6.Shape.Lines = new string[] {
        "-0,458"};
      // 
      // 
      // 
      this.annotation6.Shape.Pen.Visible = false;
      this.annotation6.Shape.Right = 29;
      // 
      // 
      // 
      this.annotation6.Shape.Shadow.Visible = false;
      this.annotation6.Shape.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
      this.annotation6.Shape.Top = 194;
      this.annotation6.Shape.Visible = false;
      this.annotation6.Text = "-0,458";
      this.annotation6.TextAlign = System.Drawing.StringAlignment.Center;
      this.annotation6.Top = 194;
      // 
      // cursorTool3
      // 
      this.cursorTool3.FollowMouse = true;
      // 
      // 
      // 
      this.cursorTool3.Pen.Color = System.Drawing.Color.Gray;
      this.cursorTool3.Series = this.line3;
      this.cursorTool3.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
      // 
      // annotation8
      // 
      this.annotation8.AutoSize = true;
      // 
      // 
      // 
      this.annotation8.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.annotation8.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.annotation8.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.annotation8.Callout.Brush.Color = System.Drawing.Color.Black;
      this.annotation8.Callout.Distance = 0;
      this.annotation8.Callout.Draw3D = false;
      this.annotation8.Callout.SizeDouble = 0D;
      this.annotation8.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.annotation8.Callout.XPosition = 0;
      this.annotation8.Callout.YPosition = 0;
      this.annotation8.Callout.ZPosition = 0;
      this.annotation8.Cursor = System.Windows.Forms.Cursors.Default;
      this.annotation8.Left = -19;
      // 
      // 
      // 
      this.annotation8.Shape.Bottom = 212;
      // 
      // 
      // 
      this.annotation8.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
      this.annotation8.Shape.CustomPosition = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.annotation8.Shape.Font.Brush.Color = System.Drawing.Color.White;
      this.annotation8.Shape.Left = -19;
      this.annotation8.Shape.Lines = new string[] {
        "-0,458"};
      // 
      // 
      // 
      this.annotation8.Shape.Pen.Visible = false;
      this.annotation8.Shape.Right = 29;
      // 
      // 
      // 
      this.annotation8.Shape.Shadow.Visible = false;
      this.annotation8.Shape.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
      this.annotation8.Shape.Top = 194;
      this.annotation8.Shape.Visible = false;
      this.annotation8.Text = "-0,458";
      this.annotation8.TextAlign = System.Drawing.StringAlignment.Center;
      this.annotation8.Top = 194;
      // 
      // tChart1
      // 
      // 
      // 
      // 
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
      this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Gray;
      // 
      // 
      // 
      this.tChart1.Header.Visible = false;
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
      this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart1.Series.Add(this.donut1);
      this.tChart1.Size = new System.Drawing.Size(255, 156);
      this.tChart1.TabIndex = 1;
      this.tChart1.Tools.Add(this.annotation1);
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
      this.tChart1.DoubleClick += new System.EventHandler(this.chartdoubleclick);
      // 
      // donut1
      // 
      // 
      // 
      // 
      this.donut1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.donut1.Circled = true;
      this.donut1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.donut1.DonutPercent = 95;
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
      this.donut1.RotationAngle = 180;
      this.donut1.SeriesData = resources.GetString("donut1.SeriesData");
      // 
      // 
      // 
      this.donut1.Shadow.Height = 3;
      this.donut1.Shadow.Width = 3;
      this.donut1.Title = "Series0";
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
      this.annotation1.Position = Steema.TeeChart.Tools.AnnotationPositions.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.annotation1.Shape.Font.Name = "Segoe UI";
      this.annotation1.Shape.Font.Size = 29;
      this.annotation1.Shape.Font.SizeFloat = 29F;
      this.annotation1.Shape.Lines = new string[] {
        "$750"};
      this.annotation1.Shape.Transparent = true;
      this.annotation1.Text = "$750";
      // 
      // textSource1
      // 
      this.textSource1.DecimalSeparator = '.';
      this.textSource1.FileName = "D:\\Data\\TCoherence\\TeeChartforNET\\Version 4\\Demos\\StandardSeriesDemo\\tees\\webanal" +
    "yticsdata.txt";
      this.textSource1.Series = null;
      // 
      // WebAnalytics
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(785, 427);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "WebAnalytics";
      this.Text = " ";
      this.Load += new System.EventHandler(this.WebAnalytics_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.TChart tChart3;
        private Steema.TeeChart.TChart tChart2;
        private Steema.TeeChart.TChart tChart4;
        private Steema.TeeChart.Styles.Donut donut3;
        private Steema.TeeChart.Tools.Annotation annotation3;
        private Steema.TeeChart.Styles.Donut donut2;
        private Steema.TeeChart.Tools.Annotation annotation2;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Styles.Line line2;
        private Steema.TeeChart.Styles.Line line3;
        private Steema.TeeChart.Tools.CursorTool cursorTool1;
        private Steema.TeeChart.Tools.Annotation annotation4;
        private Steema.TeeChart.Tools.CursorTool cursorTool2;
        private Steema.TeeChart.Tools.Annotation annotation6;
        private Steema.TeeChart.Tools.CursorTool cursorTool3;
        private Steema.TeeChart.Tools.Annotation annotation8;
        private Steema.TeeChart.Styles.Donut donut1;
        private Steema.TeeChart.Tools.Annotation annotation1;
        private Steema.TeeChart.Data.TextSource textSource1;
    }
}