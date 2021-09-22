using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// TeeChart's XOr cursor in the managed framework is not as fast or as smooth as
/// a native cursor. A native cursor is unmanaged though, so we're not including it in the core
/// product. Alternatively use TeeChart's conventional cursor, quite nimble in a 100%
/// managed code project.
/// 
/// This example was inspired by the RubberRectangle example here:
/// https://www.codeproject.com/Articles/27389/C-Rubber-Rectangle
/// </summary>

namespace NativeCursor
{
    public partial class Form1 : Form
    {
        private GDI32.GDI32 gdi;

        public Form1()
        {
            InitializeComponent();
            gdi = new GDI32.GDI32();

           
        }

        protected Point oldMouse, mouseDownAt;  //form drawing
        protected Point[] mouseTop = new Point[2]; //TeeChart
        protected Point[] mouseBottom = new Point[2];
        protected Point[] oldMouseTop = new Point[2];
        protected Point[] oldMouseBottom = new Point[2];

        /// <summary>
        ///  basic functionality:
        ///  
        ///  The mousedown event sets off the first line render location, subsequent
        ///  mousemoves plotthe line and replot over the original line, reverse-draw hiding it.
        /// </summary>

 
        bool joinCharts = false;

        bool first = false;

        private void tChart1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                oldMouseTop[0] = new Point(e.X, tChart1.Axes.Left.CalcYPosValue(tChart1.Axes.Left.Maximum));
                oldMouseBottom[0] = new Point(e.X, tChart1.Axes.Left.CalcYPosValue(tChart1.Axes.Left.Minimum));

                first = true;
            }
        }

        private void tChart1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                //check that x pos is on axis range 
                if ((e.X > tChart1.Axes.Left.Position) && (e.X < tChart1.Axes.Bottom.CalcXPosValue(tChart1.Axes.Bottom.Maximum)))
                {

                    double xval = tChart1.Axes.Bottom.CalcPosPoint(e.X);
                    label1.Text = "";
                    for (int i = 0; i < tChart1.Series.Count; i++)
                        if (tChart1.Series[i] is Steema.TeeChart.Styles.FastLine)
                        {
                            label1.Text += "Chart1, " + tChart1.Series[i].Title + ": Y(" + xval.ToString("0.00") + ")= ";
                            label1.Text += InterpolateLineSeries(tChart1.Series[i] as Steema.TeeChart.Styles.FastLine, xval).ToString("0.00") + "\r\n";
                        }

                    if (joinCharts)
                    {
                        label2.Text = "";
                        for (int i = 0; i < tChart2.Series.Count; i++)
                            if (tChart2.Series[i] is Steema.TeeChart.Styles.FastLine)
                            {
                                label2.Text += "Chart2, " + tChart2.Series[i].Title + ": Y(" + xval.ToString("0.00") + ")= ";
                                label2.Text += InterpolateLineSeries(tChart2.Series[i] as Steema.TeeChart.Styles.FastLine, xval).ToString("0.00") + "\r\n";
                            }
                    }

                    if (first)
                    {
                        gdi.DrawLine(tChart1.CreateGraphics(), oldMouseTop[0], oldMouseBottom[0]);


                        if (joinCharts)
                        {
                            gdi.DrawLine(tChart2.CreateGraphics(), oldMouseTop[0], oldMouseBottom[0]);
                        }

                        first = false;
                    }

                    mouseTop[0] = new Point(e.X, tChart1.Axes.Left.CalcYPosValue(tChart1.Axes.Left.Maximum));
                    mouseBottom[0] = new Point(e.X, tChart1.Axes.Left.CalcYPosValue(tChart1.Axes.Left.Minimum));

                    gdi.DrawLine(tChart1.CreateGraphics(), mouseTop[0], mouseBottom[0]);
                    gdi.DrawLine(tChart1.CreateGraphics(), oldMouseTop[0], oldMouseBottom[0]);

                    if (joinCharts)
                    {
                        gdi.DrawLine(tChart2.CreateGraphics(), mouseTop[0], mouseBottom[0]);
                        gdi.DrawLine(tChart2.CreateGraphics(), oldMouseTop[0], oldMouseBottom[0]);
                    }

                    oldMouseTop[0] = new Point(e.X, tChart1.Axes.Left.CalcYPosValue(tChart1.Axes.Left.Maximum));
                    oldMouseBottom[0] = new Point(e.X, tChart1.Axes.Left.CalcYPosValue(tChart1.Axes.Left.Minimum));
                }
            }
        }

        private double InterpolateLineSeries(Steema.TeeChart.Styles.FastLine series, double xvalue)
        {
            return InterpolateLineSeries(series, series.FirstVisibleIndex, series.LastVisibleIndex, xvalue);
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

        private void tChart1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                gdi.DrawLine(tChart1.CreateGraphics(), oldMouseTop[0], oldMouseBottom[0]);

                if (joinCharts)
                {
                    gdi.DrawLine(tChart2.CreateGraphics(), oldMouseTop[0], oldMouseBottom[0]);
                }
            }
        }


        bool first2 = false;

        private void tChart2_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                oldMouseTop[1] = new Point(e.X, tChart2.Axes.Left.CalcYPosValue(tChart2.Axes.Left.Maximum));
                oldMouseBottom[1] = new Point(e.X, tChart2.Axes.Left.CalcYPosValue(tChart2.Axes.Left.Minimum));

                first2 = true;
            }
        }

        private void tChart2_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {

                if (first2)
                {
                    gdi.DrawLine(tChart2.CreateGraphics(), oldMouseTop[1], oldMouseBottom[1]);
                    first2 = false;
                }

                mouseTop[1] = new Point(e.X, tChart2.Axes.Left.CalcYPosValue(tChart2.Axes.Left.Maximum));
                mouseBottom[1] = new Point(e.X, tChart2.Axes.Left.CalcYPosValue(tChart2.Axes.Left.Minimum));

                gdi.DrawLine(tChart2.CreateGraphics(), mouseTop[1], mouseBottom[1]);

                gdi.DrawLine(tChart2.CreateGraphics(), oldMouseTop[1], oldMouseBottom[1]);

                oldMouseTop[1] = new Point(e.X, tChart2.Axes.Left.CalcYPosValue(tChart2.Axes.Left.Maximum));
                oldMouseBottom[1] = new Point(e.X, tChart2.Axes.Left.CalcYPosValue(tChart2.Axes.Left.Minimum));
            }
        }

        private void tChart2_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                gdi.DrawLine(tChart2.CreateGraphics(), oldMouseTop[1], oldMouseBottom[1]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tChart1[0].FillSampleValues(100);
            tChart2[0].FillSampleValues(100);

            tChart1.Panning.Active = false;
            tChart1.Zoom.Active = false;
            tChart1.Zoom.Direction = Steema.TeeChart.ZoomDirections.None;

            tChart2.Panning.Active = false;
            tChart2.Zoom.Active = false;
            tChart2.Zoom.Direction = Steema.TeeChart.ZoomDirections.None;
        }


        //************** used for drawing rectangles on form **********

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                oldMouse = mouseDownAt = new Point(e.X, e.Y);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                gdi.DrawRectangle(CreateGraphics(), mouseDownAt, new Point(e.X, e.Y));
                gdi.DrawRectangle(CreateGraphics(), mouseDownAt, oldMouse);
                oldMouse = new Point(e.X, e.Y);
            }
        }

        private void cBJoin_CheckedChanged(object sender, EventArgs e)
        {
            joinCharts = cBJoin.Checked;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                gdi.DrawRectangle(CreateGraphics(), mouseDownAt, oldMouse);
            }
        }

    }
}
