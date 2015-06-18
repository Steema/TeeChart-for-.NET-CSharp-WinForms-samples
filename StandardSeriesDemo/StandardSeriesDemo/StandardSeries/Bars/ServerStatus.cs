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
    public partial class ServerStatus : Form
    {
        public ServerStatus()
        {
            InitializeComponent();
        }

        private void ServerStatus_Load(object sender, EventArgs e)
        {
          tChart1.Panel.Gradient.Visible = false;
          tChart2.Panel.Gradient.Visible = false;
          tChart3.Panel.Gradient.Visible = false;

          double[] h1Vals = new double[] { 100, 100, 100, 100, 100 };
          horizBar1.Add(h1Vals);
          double[] h2Vals = new double[] { 60, 85, 40, 55, 50 };
          horizBar2.Add(h2Vals);

          horizBar3.FillSampleValues(3);
          horizBar4.FillSampleValues(3);
          horizBar5.FillSampleValues(3);
          horizBar3.Labels[0] = "Speed";
          horizBar3.Labels[1] = "Time";
          horizBar3.Labels[2] = "Visitors";

          calendar1.FillSampleValues();
          calendar1.Date = DateTime.Now;
          calendar1.Today.Color = Steema.TeeChart.Themes.LookoutTheme.SeawashPalette[9];
          calendar1.Sunday.Color = Steema.TeeChart.Themes.LookoutTheme.SeawashPalette[10];
          calendar1.Sunday.Font.Color = Color.Black;
        }

        private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
          tChart1.Graphics3D.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(5) - 16, "Memory Usage");
          tChart1.Graphics3D.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(4) - 16, "CPU usage");
          tChart1.Graphics3D.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(3) - 16, "Storage space");
          tChart1.Graphics3D.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(2) - 16, "Apps installed");
          tChart1.Graphics3D.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(1) - 16, "Bandwidth");
        }

        Random rnd1 = new Random();

        private void calendar1_Change(Steema.TeeChart.Styles.Calendar sender, Steema.TeeChart.Styles.Calendar.CalendarChangeEventArgs e)
        {
          Random rnd1 = new Random();
          // Random values for tChart1
          horizBar2.ValuesLists[0].Value[0] = rnd1.Next(100);
          horizBar2.ValuesLists[0].Value[1] = rnd1.Next(100);
          horizBar2.ValuesLists[0].Value[2] = rnd1.Next(100);
          horizBar2.ValuesLists[0].Value[3] = rnd1.Next(100);
          horizBar2.ValuesLists[0].Value[4] = rnd1.Next(100);

          // Random values for tChart3
          horizBar3.ValuesLists[0].Value[0] = rnd1.Next(1000);
          horizBar4.ValuesLists[0].Value[0] = rnd1.Next(1000);
          horizBar5.ValuesLists[0].Value[0] = rnd1.Next(1000);
          horizBar3.ValuesLists[0].Value[1] = rnd1.Next(1000);
          horizBar4.ValuesLists[0].Value[1] = rnd1.Next(1000);
          horizBar5.ValuesLists[0].Value[1] = rnd1.Next(1000);
          horizBar3.ValuesLists[0].Value[2] = rnd1.Next(1000);
          horizBar4.ValuesLists[0].Value[2] = rnd1.Next(1000);
          horizBar5.ValuesLists[0].Value[2] = rnd1.Next(1000);

          horizBar3.ValuesLists[0].Modified = true;
          horizBar4.ValuesLists[0].Modified = true;
          horizBar5.ValuesLists[0].Modified = true;

          tChart1.Refresh();
          tChart3.Refresh();


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
