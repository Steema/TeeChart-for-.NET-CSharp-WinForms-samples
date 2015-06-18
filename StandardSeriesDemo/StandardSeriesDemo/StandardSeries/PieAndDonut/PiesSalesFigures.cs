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
    public partial class PiesSalesFigures : Form
    {
        public PiesSalesFigures()
        {
            InitializeComponent();
        }

        private void PiesSalesFigures_Load(object sender, EventArgs e)
        {
          pie1.Add(19, "Facebook");
          pie1.Add(14, "Tencent");
          pie1.Add(9, "WhatsApp");
          pie1.Add(5, "LinkedIn");
          pie1.Add(4, "Twitter");

          pie1.MarksPie.LegSize = 20;
          pie1.Marks.FontSeriesColor = true;

          tChart2.Panel.Gradient.Visible = false;
          tChart3.Panel.Gradient.Visible = false;

          //numericGauges
          setGauge(numericGauge1);
          numericGauge1.Markers[1].Text = "Highest";
          numericGauge1.Markers[2].Text = "Facebook";

          setGauge(numericGauge2);
          numericGauge2.Markers[1].Text = "Lowest";
          numericGauge2.Markers[2].Text = "Twitter";

        }

        private void setGauge(Steema.TeeChart.Styles.NumericGauge nGauge)
        {

          nGauge.FaceBrush.Transparency = 100;

          foreach (Steema.TeeChart.Tools.Marker mark in nGauge.Markers)
          {
            mark.UsePalette = false;
            mark.Shape.Font.Name = "Segoe UI";
          }

          nGauge.Markers[0].Shape.Font.Color = Color.White;
          nGauge.Markers[0].Shape.Transparent = true;
          nGauge.Markers[0].Shape.Font.Bold = false;
          nGauge.Markers[0].Shape.Font.Size = 55;
          nGauge.Markers[0].Left = 35;
          nGauge.Markers[0].Top = 5;

          nGauge.Markers[1].Shape.Font.Color = Color.FromArgb(255, 70, 95, 152);
          nGauge.Markers[1].Shape.Font.Bold = false;
          nGauge.Markers[1].Shape.Font.Size = 11;
          nGauge.Markers[1].Left = 5;
          nGauge.Markers[1].Top = 5;

          nGauge.Markers[2].Shape.Color = Color.White;
          nGauge.Markers[2].Shape.Font.Color = Color.White;
          nGauge.Markers[2].Shape.Font.Brush.Color = Color.White;
          nGauge.Markers[2].Shape.Transparent = true;
          nGauge.Markers[2].Shape.Font.Size = 16;
          nGauge.Markers[2].Left = 186;
          nGauge.Markers[2].Top = 80;
        }

        private void tChart1_OnAfterDraw(object sender, EventArgs e)
        {
            tChart2.Left = tChart1.Width - 300;
            tChart3.Left = tChart1.Width - 300;
        }

        private void PiesSalesFigures_Resize(object sender, EventArgs e)
        {
          tChart2.Left = this.Width - tChart1.Left - tChart2.Width - 5;
          tChart3.Left = this.Width - tChart1.Left - tChart2.Width - 5;
        }

        private void Chart_DoubleClick(object sender, EventArgs e)
        {
          (sender as Steema.TeeChart.TChart).Zoom.Active = false;
          (sender as Steema.TeeChart.TChart).ShowEditor();
          (sender as Steema.TeeChart.TChart).Chart.CancelMouse = true;
          (sender as Steema.TeeChart.TChart).Zoom.Active = true;
        }
    }
}
