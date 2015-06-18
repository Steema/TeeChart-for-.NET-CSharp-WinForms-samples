namespace StandardSeriesDemo.StandardSeries.Gantt
{
    partial class ProjectPlanner
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectPlanner));
      this.tChart1 = new Steema.TeeChart.TChart();
      this.gantt1 = new Steema.TeeChart.Styles.Gantt();
      this.ganttTool1 = new Steema.TeeChart.Tools.GanttTool();
      this.SuspendLayout();
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Increment = 30D;
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
      this.tChart1.Axes.Bottom.Labels.Font.Size = 16;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 16F;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Caption = "Time";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Bottom.Title.Font.Name = "Segoe UI";
      this.tChart1.Axes.Bottom.Title.Lines = new string[] {
        "Time"};
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Left.Labels.Font.Size = 13;
      this.tChart1.Axes.Left.Labels.Font.SizeFloat = 13F;
      // 
      // 
      // 
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Caption = "Task";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Left.Title.Font.Name = "Segoe UI";
      this.tChart1.Axes.Left.Title.Lines = new string[] {
        "Task"};
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
      this.tChart1.Header.Font.Size = 21;
      this.tChart1.Header.Font.SizeFloat = 21F;
      this.tChart1.Header.Lines = new string[] {
        "Project Planner"};
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
      this.tChart1.Series.Add(this.gantt1);
      this.tChart1.Size = new System.Drawing.Size(830, 480);
      this.tChart1.TabIndex = 0;
      this.tChart1.Tools.Add(this.ganttTool1);
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
      this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
      this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart1_DoubleClick);
      // 
      // gantt1
      // 
      this.gantt1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.gantt1.ColorEach = true;
      // 
      // 
      // 
      this.gantt1.EndValues.DataMember = "End";
      this.gantt1.EndValues.DateTime = true;
      this.gantt1.LabelMember = "Labels";
      // 
      // 
      // 
      this.gantt1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.gantt1.Marks.Brush.Visible = false;
      this.gantt1.Marks.Transparent = true;
      this.gantt1.Marks.Visible = true;
      this.gantt1.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      this.gantt1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
      // 
      // 
      // 
      this.gantt1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.gantt1.Pointer.Pen.Visible = false;
      this.gantt1.Pointer.SizeDouble = 0D;
      this.gantt1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.gantt1.SeriesData = resources.GetString("gantt1.SeriesData");
      // 
      // 
      // 
      this.gantt1.StartValues.DataMember = "Start";
      this.gantt1.StartValues.DateTime = true;
      this.gantt1.StartValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      this.gantt1.Title = "gantt1";
      // 
      // 
      // 
      this.gantt1.YValues.DataMember = "Y";
      // 
      // ganttTool1
      // 
      this.ganttTool1.Gantt = this.gantt1;
      this.ganttTool1.Series = this.gantt1;
      this.ganttTool1.DragBar += new Steema.TeeChart.Tools.GanttDragEventHandler(this.ganttTool1_DragBar);
      this.ganttTool1.ResizeBar += new Steema.TeeChart.Tools.GanttResizeEventHandler(this.ganttTool1_ResizeBar);
      // 
      // ProjectPlanner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(830, 480);
      this.Controls.Add(this.tChart1);
      this.Name = "ProjectPlanner";
      this.Text = "ProjectPlanner";
      this.Load += new System.EventHandler(this.ProjectPlanner_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Tools.SeriesAnimation seriesAnimation1;
        private Steema.TeeChart.Styles.Gantt gantt1;
        private Steema.TeeChart.Tools.GanttTool ganttTool1;
    }
}