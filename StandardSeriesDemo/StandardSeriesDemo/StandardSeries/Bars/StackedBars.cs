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
    public partial class StackedBars : Form
    {
        public StackedBars()
        {
            InitializeComponent();
        }

        private void StackedBars_Load(object sender, EventArgs e)
        {
            tChart1.Panel.Gradient.Visible = false;

            bar1.Add(1);
            bar1.Add(1.3);
            bar1.Add(1.9);
            bar1.Add(2.7);
            bar1.Add(3.9);
            bar1.Add(5.7);

            bar2.Add(0.8);
            bar2.Add(1);
            bar2.Add(1.3);
            bar2.Add(2);
            bar2.Add(2.7);
            bar2.Add(3.4);

            bar3.Add(2.9);
            bar3.Add(5.6);
            bar3.Add(7.5);
            bar3.Add(9.2);
            bar3.Add(10.7);
            bar3.Add(11.9);

        }

        private void bar1_GetSeriesMark(Steema.TeeChart.Styles.Series series, Steema.TeeChart.Styles.GetSeriesMarkEventArgs e)
        {
          e.MarkText = e.MarkText + " $";
        }

        private void tChart1_GetAxisLabel(object sender, Steema.TeeChart.GetAxisLabelEventArgs e)
        {
           if  ((((Steema.TeeChart.Axis)(sender)).Horizontal == false) && (((Steema.TeeChart.Axis)(sender)).OtherSide==true))
            e.LabelText = e.LabelText + " $";
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
