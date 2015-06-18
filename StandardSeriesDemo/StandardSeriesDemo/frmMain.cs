using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StandardSeriesDemo.StandardSeries.Lines;
using StandardSeriesDemo.StandardSeries.Bars;
using StandardSeriesDemo.StandardSeries.Areas;
using StandardSeriesDemo.StandardSeries.PieAndDonut;
using StandardSeriesDemo.StandardSeries.Points;
using StandardSeriesDemo.StandardSeries.Gantt;
using StandardSeriesDemo.StandardSeries.Miscellaneous;
using StandardSeriesDemo.StandardSeries.Bubbles;


namespace StandardSeriesDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Left = Top = 0;

            //pnlMenuGroup1.Height = 34;
            pnlMenuGroup2.Height = 34;
            pnlMenuGroup3.Height = 34;
            pnlMenuGroup4.Height = 34;
            pnlMenuGroup5.Height = 34;
            pnlMenuGroup6.Height = 34;
            pnlMenuGroup7.Height = 34;
            pnlMenuGroup8.Height = 34;

            btnMenuGroup1.Image = Properties.Resources.up;
            btnMenuGroup2.Image = Properties.Resources.down;
            btnMenuGroup3.Image = Properties.Resources.down;
            btnMenuGroup4.Image = Properties.Resources.down;
            btnMenuGroup5.Image = Properties.Resources.down;
            btnMenuGroup6.Image = Properties.Resources.down;
            btnMenuGroup7.Image = Properties.Resources.down;
            btnMenuGroup8.Image = Properties.Resources.down;

            lblMenu_Click(lblMenu, e);
        }

        private void btnMenuGroup1_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup1.Height == 34)
            {
                pnlMenuGroup1.Height = (32 *3) + 2;
                btnMenuGroup1.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup1.Height = 34;
                btnMenuGroup1.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup2_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup2.Height == 34)
            {
                pnlMenuGroup2.Height = (32 * 4) + 2;
                btnMenuGroup2.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup2.Height = 34;
                btnMenuGroup2.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup3_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup3.Height == 34)
            {
                pnlMenuGroup3.Height = (32 * 2) + 2;
                btnMenuGroup3.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup3.Height = 34;
                btnMenuGroup3.Image = Properties.Resources.down;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuGroup4_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup4.Height == 34)
            {
                pnlMenuGroup4.Height = (32 * 5) + 2;
                btnMenuGroup4.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup4.Height = 34;
                btnMenuGroup4.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup5_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup5.Height == 34)
            {
                pnlMenuGroup5.Height = (32 * 2) + 2;
                btnMenuGroup5.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup5.Height = 34;
                btnMenuGroup5.Image = Properties.Resources.down;
            }
        }

        static public void InsertForm(Form f, Control c)
        {
            if (c != null)
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.MaximizeBox = false;
                f.MinimizeBox = false;
                f.ControlBox = false;

                c.Controls.Add(f);
                //f.Parent=c;
                f.Show();
            }
        }

        static public void RemoveForm(Form f, Control c)
        {
            if (c != null)
            {
                f.TopLevel = false;
                f.Dock = DockStyle.None;
                f.FormBorderStyle = FormBorderStyle.None;
                f.MaximizeBox = false;
                f.MinimizeBox = false;
                f.ControlBox = false;

                c.Controls.Remove(f);
                //f.Parent=c;
                f = null;
            }
        }

        string oldChart = "";
        Form chart = null;

        private void buttons_Click(object sender, EventArgs e)
        {

            if ((string)(sender as Button).Tag != oldChart)
            {
                if (chart !=null)
                    chart.Dispose();                

                switch ((string)(sender as Button).Tag)
                {
                    case "PopularLanguages":
                        chart = new PopularLanguages();
                        break;
                    case "StackedBars":
                        chart = new StackedBars();
                        break;
                    case "ServerStatus":
                        chart = new ServerStatus();
                        break;
                    case "StockMonitoring":
                        chart = new StockMonitoring();
                        break;
                    case "WebAnalytics":
                        chart = new WebAnalytics();
                        break;
                    case "SalesFigures":
                        chart = new SalesFigures();
                        break;
                    case "PieSalesFigures":
                        chart = new PiesSalesFigures();
                        break;
                    case "ProductShipments":
                        chart = new ProductShipments();
                        break;
                    case "VegetationGrowth":
                        chart = new VegetationGrowth();
                        break;
                    case "ProjectPlanner":
                        chart = new ProjectPlanner();
                        break;
                    case "ScrollerChart":
                        chart = new ScrollerChart();
                        break;
                    case "DonutChart":
                        chart = new DonutChart();
                        break;
                    case "MultiPies":
                        chart = new MultiPies();
                        break;
                    case "MultiDonut":
                        chart = new MultiDonut();
                        break;
                }
                oldChart = ((string)(sender as Button).Tag);

                if (chart != null)
                {
                    chart.TopLevel = false;
                    chart.AutoScroll = true;
                    InsertForm(chart, panelChart);
                    chart.Dock = DockStyle.Fill;

                    panelChart.Controls.Add(chart);
                    chart.Show();
                }
            }
        }

        private void btnMenuGroup6_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup6.Height == 34)
            {
                pnlMenuGroup6.Height = (32 * 2) + 2;
                btnMenuGroup6.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup6.Height = 34;
                btnMenuGroup6.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup7_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup7.Height == 34)
            {
                pnlMenuGroup7.Height = (32 * 2) + 2;
                btnMenuGroup7.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup7.Height = 34;
                btnMenuGroup7.Image = Properties.Resources.down;
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            if ((string)(sender as Label).Tag != oldChart)
            {
                if (chart != null)
                    chart.Dispose();

                switch ((string)(sender as Label).Tag)
                {
                    case "StartForm":
                        chart = new StartForm();
                        break;
                }
                oldChart = ((string)(sender as Label).Tag);

                if (chart != null)
                {
                    chart.TopLevel = false;
                    chart.AutoScroll = true;
                    InsertForm(chart, panelChart);
                    chart.Dock = DockStyle.Fill;

                    panelChart.Controls.Add(chart);
                    chart.Show();
                }
            }

        }

        private void lblMenu_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.steema.com");
        }

        private void btnMenuGroup8_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup8.Height == 34)
            {
                pnlMenuGroup8.Height = (32 * 2) + 2;
                btnMenuGroup8.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup8.Height = 34;
                btnMenuGroup8.Image = Properties.Resources.down;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.steema.com");
        }
    }
}
