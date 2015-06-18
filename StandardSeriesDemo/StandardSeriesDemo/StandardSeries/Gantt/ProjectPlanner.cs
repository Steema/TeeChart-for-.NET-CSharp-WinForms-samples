using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StandardSeriesDemo.StandardSeries.Gantt
{
  public partial class ProjectPlanner : Form
  {
    public ProjectPlanner()
    {
      InitializeComponent();
    }

    private void ProjectPlanner_Load(object sender, EventArgs e)
    {
      tChart1.Panel.Gradient.Visible = false;

      gantt1.Add(new DateTime(2014, 6, 7).ToOADate(), new DateTime(2014, 9, 23).ToOADate(), 0, "Production");
      gantt1.Add(new DateTime(2014, 9, 3).ToOADate(), new DateTime(2014, 11, 10).ToOADate(), 1, "Marketing");
      gantt1.Add(new DateTime(2014, 3, 13).ToOADate(), new DateTime(2014, 3, 31).ToOADate(), 2, "Approve");
      gantt1.Add(new DateTime(2014, 5, 7).ToOADate(), new DateTime(2014, 6, 5).ToOADate(), 3, "Prototype");
      gantt1.Add(new DateTime(2014, 10, 11).ToOADate(), new DateTime(2014, 11, 5).ToOADate(), 4, "Evaluation");
      gantt1.Add(new DateTime(2014, 4, 2).ToOADate(), new DateTime(2014, 4, 29).ToOADate(), 5, "Design");

      gantt1.AddMultipleNextTasks(2, 4);
      gantt1.AddMultipleNextTasks(2, 3);

      gantt1.ConnectingPen.Color = Color.FromArgb(49, 44, 59);
      gantt1.ConnectingPen.Width = 2;

      gantt1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      gantt1.Pointer.VertSize = 25;

      Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(tChart1.Chart, 21);
    }

    private void gantt1_GetSeriesMark(Steema.TeeChart.Styles.Series series, Steema.TeeChart.Styles.GetSeriesMarkEventArgs e)
    {
      // Add custom data to display at each gantt bar, for example: "Completion %"
      switch (e.ValueIndex)
      {
        case 0:
          e.MarkText = "20 %";
          break;
        case 1:
          e.MarkText = "40 %";
          break;
        case 2:
          e.MarkText = "10 %";
          break;
        case 3:
          e.MarkText = "75 %";
          break;
        case 4:
          e.MarkText = "55 %";
          break;
        case 5:
          e.MarkText = "60 %";
          break;
        case 6:
          e.MarkText = "25 %";
          break;
      }
    }

    private void tChart1_DoubleClick(object sender, EventArgs e)
    {
      tChart1.Zoom.Active = false;
      tChart1.ShowEditor();
      tChart1.Chart.CancelMouse = true;
      tChart1.Zoom.Active = true;
    }

    int counter = 0;

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      g.TextOut(10, 10, counter.ToString());
    }

    private void tChart1_Click(object sender, EventArgs e)
    {

    }

    private void cancelZoom()
    {
      tChart1.Chart.CancelMouse = true;
    }

    private void ganttTool1_DragBar(object sender, Steema.TeeChart.Tools.GanttDragEventArgs e)
    {
      cancelZoom();
    }

    private void ganttTool1_ResizeBar(object sender, Steema.TeeChart.Tools.GanttResizeEventArgs e)
    {
      cancelZoom();
    }

  }
}

