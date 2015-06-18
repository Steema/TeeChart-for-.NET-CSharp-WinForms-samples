namespace StandardSeriesDemo.StandardSeries.Bars
{
    partial class SalesFigures
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
      Steema.TeeChart.Animations.EasingFunctions.QuadraticEase quadraticEase1 = new Steema.TeeChart.Animations.EasingFunctions.QuadraticEase();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.bar1 = new Steema.TeeChart.Styles.Bar();
      this.bar2 = new Steema.TeeChart.Styles.Bar();
      this.seriesAnimation1 = new Steema.TeeChart.Tools.SeriesAnimation();
      this.chartPartAnimation1 = new Steema.TeeChart.Animations.ChartPartAnimation();
      this.SuspendLayout();
      // 
      // tChart1
      // 
      this.tChart1.Animations.Add(this.chartPartAnimation1);
      // 
      // 
      // 
      this.tChart1.Aspect.ColorPaletteIndex = 20;
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
      this.tChart1.Axes.Bottom.Grid.DrawEvery = 2;
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
      this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
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
      this.tChart1.Axes.Bottom.Title.Font.Size = 11;
      this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
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
      this.tChart1.Axes.Left.Grid.DrawEvery = 2;
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
      this.tChart1.Axes.Left.Labels.Font.Size = 9;
      this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
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
      this.tChart1.Axes.Left.Title.Caption = "$ 000s";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Left.Title.Font.Size = 11;
      this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
      this.tChart1.Axes.Left.Title.Lines = new string[] {
        "$ 000s"};
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
      this.tChart1.Axes.Right.Labels.Font.Size = 9;
      this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
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
      this.tChart1.Axes.Top.Labels.Font.Size = 9;
      this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.tChart1.BackColor = System.Drawing.Color.Transparent;
      this.tChart1.CurrentTheme = Steema.TeeChart.ThemeType.Lookout;
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
      this.tChart1.Header.Font.Size = 12;
      this.tChart1.Header.Font.SizeFloat = 12F;
      this.tChart1.Header.Lines = new string[] {
        "Sales Figures"};
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
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Legend.Font.Size = 9;
      this.tChart1.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.tChart1.Legend.Pen.Visible = false;
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
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
      this.tChart1.Series.Add(this.bar1);
      this.tChart1.Series.Add(this.bar2);
      this.tChart1.Size = new System.Drawing.Size(1266, 600);
      this.tChart1.TabIndex = 0;
      this.tChart1.Tools.Add(this.seriesAnimation1);
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
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart1_DoubleClick);
      // 
      // bar1
      // 
      this.bar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      this.bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.RoundRectangle;
      this.bar1.BarWidthPercent = 80;
      // 
      // 
      // 
      this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.bar1.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar1.Marks.Arrow.Visible = false;
      this.bar1.Marks.ArrowLength = 8;
      // 
      // 
      // 
      this.bar1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.bar1.Marks.FollowSeriesColor = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar1.Marks.Font.Brush.Color = System.Drawing.Color.White;
      this.bar1.Marks.Font.Name = "Segoe UI";
      // 
      // 
      // 
      this.bar1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.bar1.Marks.Pen.Visible = false;
      // 
      // 
      // 
      this.bar1.Marks.Shadow.Visible = false;
      this.bar1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.LabelValue;
      this.bar1.OffsetPercent = -10;
      this.bar1.OriginalCursor = null;
      // 
      // 
      // 
      this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(55)))), ((int)(((byte)(3)))));
      this.bar1.Pen.Visible = false;
      this.bar1.Title = "Series0";
      // 
      // 
      // 
      this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.bar1.YValues.DataMember = "Bar";
      // 
      // bar2
      // 
      this.bar2.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      this.bar2.BarStyle = Steema.TeeChart.Styles.BarStyles.RoundRectangle;
      this.bar2.BarWidthPercent = 80;
      // 
      // 
      // 
      this.bar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.bar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.bar2.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar2.Marks.Arrow.Visible = false;
      this.bar2.Marks.ArrowLength = 8;
      // 
      // 
      // 
      this.bar2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.bar2.Marks.FollowSeriesColor = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar2.Marks.Font.Brush.Color = System.Drawing.Color.White;
      this.bar2.Marks.Font.Name = "Segoe UI";
      // 
      // 
      // 
      this.bar2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.bar2.Marks.Pen.Visible = false;
      // 
      // 
      // 
      this.bar2.Marks.Shadow.Visible = false;
      this.bar2.Marks.Style = Steema.TeeChart.Styles.MarksStyles.LabelValue;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar2.Marks.Symbol.Shadow.Visible = false;
      this.bar2.OffsetPercent = 10;
      this.bar2.OriginalCursor = null;
      // 
      // 
      // 
      this.bar2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
      this.bar2.Pen.Visible = false;
      this.bar2.Title = "Series1";
      // 
      // 
      // 
      this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.bar2.YValues.DataMember = "Bar";
      // 
      // seriesAnimation1
      // 
      this.seriesAnimation1.StartValue = 0D;
      // 
      // chartPartAnimation1
      // 
      this.chartPartAnimation1.Axis = null;
      quadraticEase1.EasingMode = Steema.TeeChart.Animations.EasingFunctions.EasingMode.EaseIn;
      this.chartPartAnimation1.EasingFunction = quadraticEase1;
      this.chartPartAnimation1.EasingMode = Steema.TeeChart.Animations.EasingFunctions.EasingMode.EaseOut;
      this.chartPartAnimation1.Fade = Steema.TeeChart.Animations.TransformFade.In;
      this.chartPartAnimation1.RotateMax = 0F;
      this.chartPartAnimation1.RotateMin = 0F;
      this.chartPartAnimation1.Series = this.bar1;
      this.chartPartAnimation1.Speed = 1000;
      this.chartPartAnimation1.Target = Steema.TeeChart.ChartClickedPartStyle.Series;
      this.chartPartAnimation1.TranslateStyle = Steema.TeeChart.Animations.TransformTranslate.None;
      this.chartPartAnimation1.ZoomStyle = Steema.TeeChart.Animations.TransformZoom.None;
      // 
      // SalesFigures
      // 
      this.ClientSize = new System.Drawing.Size(1266, 600);
      this.Controls.Add(this.tChart1);
      this.Name = "SalesFigures";
      this.Load += new System.EventHandler(this.SalesFigures_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Bar bar1;
        private Steema.TeeChart.Styles.Bar bar2;
        private Steema.TeeChart.Tools.SeriesAnimation seriesAnimation1;
        private Steema.TeeChart.Animations.ChartPartAnimation chartPartAnimation1;
    }
}