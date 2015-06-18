using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StandardSeriesDemo.StandardSeries.PieAndDonut
{
    public partial class DonutChart : Form
    {
        public DonutChart()
        {
            InitializeComponent();
        }

        private void DonutChart_Load(object sender, EventArgs e)
        {
          tChart1.Panel.Gradient.Visible = false;
          tChart1.Legend.Transparent = true;
          donut1.MarksPie.LegSize = 24;
          donut1.Marks.Callout.Distance = 10;
        }
          
        

        private void tChart1_DoubleClick(object sender, EventArgs e)
        {
          (sender as Steema.TeeChart.TChart).Zoom.Active = false;
          (sender as Steema.TeeChart.TChart).ShowEditor();
          (sender as Steema.TeeChart.TChart).Chart.CancelMouse = true;
          (sender as Steema.TeeChart.TChart).Zoom.Active = true;
        }
    }
}
