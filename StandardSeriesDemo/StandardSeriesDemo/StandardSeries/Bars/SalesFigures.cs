using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StandardSeriesDemo.StandardSeries.Bars
{
    public partial class SalesFigures : Form
    {
        public SalesFigures()
        {
            InitializeComponent();
        }

        private void tChart1_OnAfterDraw(object sender, EventArgs e)
        {

        }

        private void SalesFigures_Load(object sender, EventArgs e)
        {
          tChart1.Panel.Gradient.Visible = false;

          //add series and data
          bar1.Title = "Apples";
          bar1.Clear();
          bar1.Add(5, "jan");
          bar1.Add(2, "feb");
          bar1.Add(1, "mar");
          bar1.Add(4, "apr");
          bar1.Add(10, "may");
          bar1.Add(11, "jun");
          bar1.Add(15, "jul");

          bar2.Title = "Pears";
          bar2.Clear();
          bar2.Add(7);
          bar2.Add(5);
          bar2.Add(1);
          bar2.Add(6);
          bar2.Add(2);
          bar2.Add(11);
          bar2.Add(5);

          tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Text;
          tChart1.Axes.Left.Increment = 3;

          tChart1.Axes.Left.SetMinMax(0, 15);

          chartPartAnimation1.Play();
        }

        private void tChart1_DoubleClick(object sender, EventArgs e)
        {
          tChart1.Zoom.Active = false;
          tChart1.ShowEditor();
          tChart1.Chart.CancelMouse = true;
          tChart1.Zoom.Active = true;
        }
    }
}
