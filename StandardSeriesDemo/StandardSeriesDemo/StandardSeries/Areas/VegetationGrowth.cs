using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StandardSeriesDemo.StandardSeries.Areas
{
    public partial class VegetationGrowth : Form
    {
        public VegetationGrowth()
        {
            InitializeComponent();
        }

        private void VegetationGrowth_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();

            for (int t=0; t< 15; t++)
            {

              area1.Add(rnd1.Next(100));
              area2.Add(rnd1.Next(60));
              area3.Add(rnd1.Next(30));
            }

            area1.Smoothed = true;
            area2.Smoothed = true;
            area3.Smoothed = true;

            //area1.DrawStyle = TeeChart.ECustomSeriesDrawStyle.dsCurve;
            //area2.DrawStyle = TeeChart.ECustomSeriesDrawStyle.dsCurve;
            //area3.DrawStyle = TeeChart.ECustomSeriesDrawStyle.dsCurve;

            tChart1.Axes.Bottom.Increment = 3;
            tChart1.Panel.Gradient.Visible = false;
        }

        private void tChart1_OnDblClick(object sender, EventArgs e)
        {
            tChart1.ShowEditor();
        }
    }
}
