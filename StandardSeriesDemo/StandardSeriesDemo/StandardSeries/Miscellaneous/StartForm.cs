using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StandardSeriesDemo.StandardSeries.Miscellaneous
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
          Steema.TeeChart.Utils.UseCaches = false;
          tChart3[0].FillSampleValues();
          
          world1.Pen.Color = tChart1.Panel.Gradient.StartColor;
          tChart1.Footer.CustomPosition = true;
          tChart1.Footer.Left = 10;
          tChart1.Footer.Top = tChart1.Height - 30;

          //pie
          pie1.Circled = true;
          pie1.Add(476, "Tables", Color.White);
          pie1.Add(883, "Chairs", Color.FromArgb(242, 242, 242));
          pie1.Add(537, "Sofas", Color.FromArgb(223, 223, 223));
          pie1.Add(364, "Cupboards", Color.FromArgb(215, 215, 215));

          pie1.AutoPenColor = false;

          //donut
          donut1.Add(476, "Tables", Color.White);
          donut1.Add(883, "Chairs", Color.FromArgb(242, 242, 242));
          donut1.Add(537, "Sofas", Color.FromArgb(223, 223, 223));
          donut1.Add(364, "Cupboards", Color.FromArgb(215, 215, 215));

          donut1.AutoPenColor = false;
          donut1.MarksPie.LegSize = 10;

          //circulargauge
          circularGauge1.FaceBrush.Visible = false;

          //calendar
          calendar1.FillSampleValues();
          calendar1.Date = DateTime.Now;

          //barline chart
          bar1.Clear();
          bar1.Add(20);
          bar1.Add(50);
          bar1.Add(10);
          bar1.Add(70);
          bar1.Add(46);

          line1.Clear();
          line1.Add(0, 45);
          line1.Add(0.444444444444444, 55);
          line1.Add(0.888888888888889, 75);
          line1.Add(1.33333333333333, 65);
          line1.Add(1.77777777777778, 45);
          line1.Add(2.22222222222222, 80);
          line1.Add(2.66666666666667, 85);
          line1.Add(3.11111111111111, 98);
          line1.Add(3.55555555555556, 75);
          line1.Add(4, 68);

          //areas
          Random rnd1 = new Random();
          for (int i = 0; i < 40; i++)
          {
            area1.Add(rnd1.Next(100));
            area2.Add(rnd1.Next(70));
          }

          //bubble
          for (int i = 0; i < 5; i++)
          {
            bubble1.Add(i, rnd1.Next(50), rnd1.Next(50));
          }

          Steema.TeeChart.Drawing.ChartBrush cBrush = new Steema.TeeChart.Drawing.ChartBrush();
          cBrush.Gradient.Visible = true;
          cBrush.Gradient.StartColor = Color.Transparent;
          cBrush.Gradient.EndColor = Color.White;

          tChart8.Axes.Bottom.Grid.Fill = cBrush;
        }

        private void chartdoubleclick(object sender, EventArgs e)
        {
          (sender as Steema.TeeChart.TChart).Zoom.Active = false;
          (sender as Steema.TeeChart.TChart).ShowEditor();
          (sender as Steema.TeeChart.TChart).Chart.CancelMouse = true;
          (sender as Steema.TeeChart.TChart).Zoom.Active = true;
        }
    }
}
