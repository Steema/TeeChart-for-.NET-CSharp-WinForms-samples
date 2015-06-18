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
    public partial class MultiDonut : Form
    {
        public MultiDonut()
        {
            InitializeComponent();
        }

        private void MultiDonut_Load(object sender, EventArgs e)
        {
            tChart1.Panel.Gradient.Visible = false;
            tChart2.Panel.Gradient.Visible = false;
            tChart3.Panel.Gradient.Visible = false;
            tChart4.Panel.Gradient.Visible = false;
            tChart5.Panel.Gradient.Visible = false;

            initChart();
        }

        private void initChart()
        {
          donut1.Clear();
          donut1.Add(60, Color.FromArgb(215, 215, 215));
          donut1.Add(40, Color.FromArgb(249,205,32));

          donut2.Clear();
          donut2.Add(75, Color.FromArgb(215, 215, 215));
          donut2.Add(25, Color.FromArgb(243, 146, 37));
          
          donut3.Clear();
          donut3.Add(77, Color.FromArgb(215, 215, 215));
          donut3.Add(23, Color.FromArgb(249, 205, 32));
          
          donut4.Clear();
          donut4.Add(80, Color.FromArgb(215, 215, 215));
          donut4.Add(20, Color.FromArgb(243, 146, 37));

          horizBar1.Clear();
          horizBar1.Add(0.4, "Late at night in bed", Color.FromArgb(249, 205, 32));
          horizBar1.Add(0.25, "While commuting", Color.FromArgb(243, 146, 37));
          horizBar1.Add(0.23, "While having dinner", Color.FromArgb(249, 205, 32));
          horizBar1.Add(0.20, "While shopping", Color.FromArgb(243, 146, 37));

          chartPartAnimation1.Play();
          chartPartAnimation2.Play();
        }

        private void tChart1_OnAfterDraw(object sender, EventArgs e)
        {
           // tChart1.Panel.BackImage.Left = tChart1.Width / 2-32;
           // tChart2.Panel.BackImage.Left = tChart2.Width / 2-32;
           // tChart3.Panel.BackImage.Left = tChart3.Width / 2-32;
           // tChart4.Panel.BackImage.Left = tChart4.Width / 2-32;
        }

        private void tChart5_DoubleClick(object sender, EventArgs e)
        {
          (sender as Steema.TeeChart.TChart).Zoom.Active = false;
          (sender as Steema.TeeChart.TChart).ShowEditor();
          (sender as Steema.TeeChart.TChart).Chart.CancelMouse = true;
          (sender as Steema.TeeChart.TChart).Zoom.Active = true;
        }
    }
}
