using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// This example uses TeeChart Pro and the CursorTool in Managed mode. The example links charts
/// and shows how series values can be interpolated.
/// </summary>

namespace ManagedCursor
{
    enum activeChart { chart1, chart2, chart3, chart4 }
    public partial class cursorform : Form
    {
        public cursorform()
        {
            InitializeComponent();
        }

        private void cursorform_Load(object sender, EventArgs e)
        {
            tChart1.Axes.Left.SetMinMax(0, 300);
            tChart2.Axes.Left.SetMinMax(0, 300);
            tChart3.Axes.Left.SetMinMax(0, 400);
            tChart4.Axes.Left.SetMinMax(0, 300);

            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                tChart1[0].Add(225 - rand.Next(100));
                tChart2[0].Add(150 - rand.Next(50));
                tChart3[0].Add(350 - rand.Next(75));
                tChart4[0].Add(150 - rand.Next(50));
            }

            cursorTool1.FastCursor = false; //FastCursor not recommended. Due for deprecation
            cursorTool2.FastCursor = false;
            cursorTool3.FastCursor = false;
            cursorTool4.FastCursor = false;
        }

        private void cursorTool1_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
        {
            if (mouseInChart == activeChart.chart1)
            {
                cursorTool2.XValue = cursorTool1.XValue;
                cursorTool3.XValue = cursorTool1.XValue;
                cursorTool4.XValue = cursorTool1.XValue;
            }
        }

        activeChart mouseInChart;

        private void tChart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tChart1.Bounds.Contains(new Point(e.X + tChart1.Bounds.Left, e.Y + tChart1.Bounds.Top)))
            {
                mouseInChart = activeChart.chart1;
                InterpolateAllSeries(tChart1.Axes.Bottom.CalcPosPoint(e.X));
            }
        }

        private void tChart2_MouseMove(object sender, MouseEventArgs e)
        {
            if (tChart2.Bounds.Contains(new Point(e.X + tChart2.Bounds.Left, e.Y + tChart2.Bounds.Top)))
            {
                mouseInChart = activeChart.chart2;
                InterpolateAllSeries(tChart2.Axes.Bottom.CalcPosPoint(e.X));
            }
        }

        private void InterpolateAllSeries(double xvalue)
        {
            if (interPolate)
            {
                InterpolateLineSeries((Steema.TeeChart.Styles.FastLine)tChart1[0], xvalue, label1);
                InterpolateLineSeries((Steema.TeeChart.Styles.FastLine)tChart2[0], xvalue, label2);
                InterpolateLineSeries((Steema.TeeChart.Styles.FastLine)tChart3[0], xvalue, label3);
                InterpolateLineSeries((Steema.TeeChart.Styles.FastLine)tChart4[0], xvalue, label4);
            }
        }

        private void InterpolateLineSeries(Steema.TeeChart.Styles.FastLine series, double xvalue, Label aLabel)
        {
            double xval = InterpolateLineSeries(series, series.FirstVisibleIndex, series.LastVisibleIndex, xvalue);

            aLabel.Text = "";
            aLabel.Text += "Y(" + xvalue.ToString("0.00") + ")= ";
            aLabel.Text += xval.ToString("0.00") + "\r\n";

        }

        private double InterpolateLineSeries(Steema.TeeChart.Styles.FastLine series, int firstindex, int lastindex, double xvalue)
        {
            int index;
            for (index = firstindex; index <= lastindex; index++)
            {
                if (index == -1 || series.XValues.Value[index] > xvalue) break;
            }
            // safeguard
            if (index < 1) index = 1;
            else if (index >= series.Count) index = series.Count - 1;

            double dx = series.XValues[index] - series.XValues[index - 1];
            double dy = series.YValues[index] - series.YValues[index - 1];
            if (dx != 0.0) return dy * (xvalue - series.XValues[index - 1]) / dx + series.YValues[index - 1];
            else return 0.0;
        }

        private void tChart3_MouseMove(object sender, MouseEventArgs e)
        {
            if (tChart3.Bounds.Contains(new Point(e.X + tChart3.Bounds.Left, e.Y + tChart3.Bounds.Top)))
                mouseInChart = activeChart.chart3;
        }

        private void tChart4_MouseMove(object sender, MouseEventArgs e)
        {
            if (tChart4.Bounds.Contains(new Point(e.X + tChart4.Bounds.Left, e.Y + tChart4.Bounds.Top)))
                mouseInChart = activeChart.chart4;
        }

        private void cursorTool3_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
        {
            if (mouseInChart == activeChart.chart3)
            {
                cursorTool1.XValue = e.XValue;
                cursorTool2.XValue = e.XValue;
                cursorTool4.XValue = e.XValue;
            }
        }

        private void cursorTool2_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
        {
            if (mouseInChart == activeChart.chart2)
            {
                cursorTool1.XValue = e.XValue;
                cursorTool3.XValue = e.XValue;
                cursorTool4.XValue = e.XValue;
            }
        }

        private void cursorTool4_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
        {
            if (mouseInChart == activeChart.chart4)
            {
                cursorTool1.XValue = e.XValue;
                cursorTool2.XValue = e.XValue;
                cursorTool3.XValue = e.XValue;
            }
        }

        Boolean interPolate = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = checkBox1.Checked;
            label2.Visible = checkBox1.Checked;
            label3.Visible = checkBox1.Checked;
            label4.Visible = checkBox1.Checked;

            interPolate = checkBox1.Checked;
        }
    }
}
