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
    public partial class MultiPies : Form
    {
        public MultiPies()
        {
            InitializeComponent();
        }

        private void MultiPies_Load(object sender, EventArgs e)
        {
            tChart1.Panel.Gradient.Visible = false;
            tChart2.Panel.Gradient.Visible = false;
            tChart3.Panel.Gradient.Visible = false;
            tChart4.Panel.Gradient.Visible = false;
            tChart5.Panel.Gradient.Visible = false;
            tChart6.Panel.Gradient.Visible = false;
            tChart7.Panel.Gradient.Visible = false;

            tChart4[0].Marks.FontSeriesColor = true;
            tChart5[0].Marks.FontSeriesColor = true;
            tChart6[0].Marks.FontSeriesColor = true;
        }

        private void tChart_DoubleClick(object sender, EventArgs e)
        {
          (sender as Steema.TeeChart.TChart).Zoom.Active = false;
          (sender as Steema.TeeChart.TChart).ShowEditor();
          (sender as Steema.TeeChart.TChart).Chart.CancelMouse = true;
          (sender as Steema.TeeChart.TChart).Zoom.Active = true;
        }
    }
}
