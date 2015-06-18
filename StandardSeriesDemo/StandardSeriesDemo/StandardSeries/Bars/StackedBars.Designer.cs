namespace StandardSeriesDemo.StandardSeries.Bars
{
    partial class StackedBars
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
      this.bar1 = new Steema.TeeChart.Styles.Bar();
      this.bar2 = new Steema.TeeChart.Styles.Bar();
      this.bar3 = new Steema.TeeChart.Styles.Bar();
      this.seriesAnimation1 = new Steema.TeeChart.Tools.SeriesAnimation();
      this.SuspendLayout();
      // 
      // tChart1
      // 
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
      this.tChart1.Axes.Right.Increment = 5D;
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
      this.tChart1.Axes.Right.Title.Caption = "Billions";
      this.tChart1.Axes.Right.Title.Lines = new string[] {
        "Billions"};
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
      this.tChart1.Footer.Alignment = System.Drawing.StringAlignment.Near;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Black;
      this.tChart1.Footer.Font.Italic = true;
      this.tChart1.Footer.Font.Name = "Segoe UI";
      this.tChart1.Footer.Lines = new string[] {
        "Source : BI Intelligence estimates, Interactive Advertising Bureau"};
      this.tChart1.Footer.Visible = true;
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
        "Native Advertising Revenue"};
      // 
      // 
      // 
      this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
      this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      this.tChart1.Panel.Bevel.Width = 2;
      this.tChart1.Panel.BevelWidth = 2;
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
      this.tChart1.Series.Add(this.bar3);
      this.tChart1.Size = new System.Drawing.Size(657, 372);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
      this.tChart1.SubHeader.Lines = new string[] {
        "Desktop and Mobile"};
      this.tChart1.SubHeader.Visible = true;
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
      this.tChart1.GetAxisLabel += new Steema.TeeChart.GetAxisLabelEventHandler(this.tChart1_GetAxisLabel);
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart1_DoubleClick);
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
      this.bar1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.Marks.FollowSeriesColor = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar1.Marks.Font.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.bar1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.bar1.Marks.Shadow.Visible = false;
      this.bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
      this.bar1.OriginalCursor = null;
      // 
      // 
      // 
      this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.bar1.Title = "Native-Style Display";
      this.bar1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
      // 
      // 
      // 
      this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      this.bar1.GetSeriesMark += new Steema.TeeChart.Styles.Series.GetSeriesMarkEventHandler(this.bar1_GetSeriesMark);
      // 
      // bar2
      // 
      this.bar2.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.bar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.bar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
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
      this.bar2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.bar2.Marks.FollowSeriesColor = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar2.Marks.Font.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.bar2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      // 
      // 
      // 
      this.bar2.Marks.Shadow.Visible = false;
      this.bar2.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
      this.bar2.OriginalCursor = null;
      // 
      // 
      // 
      this.bar2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.bar2.Title = "Sponsorship";
      this.bar2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
      // 
      // 
      // 
      this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // bar3
      // 
      this.bar3.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.bar3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.bar3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.bar3.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar3.Marks.Arrow.Visible = false;
      this.bar3.Marks.ArrowLength = 8;
      // 
      // 
      // 
      this.bar3.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.bar3.Marks.FollowSeriesColor = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.bar3.Marks.Font.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.bar3.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      // 
      // 
      // 
      this.bar3.Marks.Shadow.Visible = false;
      this.bar3.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
      this.bar3.OriginalCursor = null;
      // 
      // 
      // 
      this.bar3.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
      this.bar3.Title = "Social";
      this.bar3.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
      // 
      // 
      // 
      this.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // seriesAnimation1
      // 
      this.seriesAnimation1.StartValue = 0D;
      // 
      // StackedBars
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(657, 372);
      this.Controls.Add(this.tChart1);
      this.Name = "StackedBars";
      this.Tag = "StackedBars";
      this.Text = "StackedBars";
      this.Load += new System.EventHandler(this.StackedBars_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Bar bar1;
        private Steema.TeeChart.Styles.Bar bar2;
        private Steema.TeeChart.Styles.Bar bar3;
        private Steema.TeeChart.Tools.SeriesAnimation seriesAnimation1;
    }
}