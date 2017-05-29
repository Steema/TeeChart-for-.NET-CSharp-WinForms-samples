using Steema.TeeChart.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Demo based on a Subaru BRZ dashboard and [some] public performance stats.
/// </summary>

namespace SubaruBRZSimul
{
  public partial class CarDash : Form
  {
    public CarDash()
    {
      InitializeComponent();
      initVars();
    }

    public void initRevChart()
    {
      circularGauge1.Axis.Labels.Font.Color = Color.FromArgb(255, 255, 153, 153);
      circularGauge1.HandOffset = 0;
      circularGauge1.Hand.Color = Color.Red;
      circularGauge1.Hand.Brush.Solid = true;
      circularGauge1.Hand.VertSize = 20;
      circularGauge1.Hand.Gradient.Visible = false;
      circularGauge1.Value = 1.8;
      circularGauge1.GreenLine.Visible = false;
      circularGauge1.RedLine.Visible = false;

      numericGauge1.FaceBrush.Visible = false;
      while (numericGauge1.Markers.Count > 1)
      {
        numericGauge1.Markers[numericGauge1.Markers.Count - 1].Active = false;
        numericGauge1.Markers.RemoveAt(numericGauge1.Markers.Count - 1);
      }

      numericGauge1.Markers[0].Shape.Visible = false;
      numericGauge1.Markers[0].Shape.Font.Size = 58;
      numericGauge1.Markers[0].Shape.Font.Color = Color.FromArgb(255, 255, 255);
      numericGauge1.Markers[0].Shape.Font.Italic = true;
      numericGauge1.Markers[0].Shape.Font.Bold = true;

      numericGauge1.ValueFormat = "0.";

      numericGauge2.FaceBrush.Visible = false;
      numericGauge2.Markers[1].Active = false;

      numericGauge2.Markers[0].Shape.Visible = false;
      numericGauge2.Markers[0].Shape.Font.Size = 34;
      numericGauge2.Markers[0].Shape.Font.Italic = true;
      numericGauge2.Markers[0].Shape.CustomPosition = true;
      numericGauge2.Markers[0].Shape.Left = 294;
      numericGauge2.Markers[0].Shape.Top = 540;

      while (numericGauge2.Markers.Count > 1)
      {
        numericGauge2.Markers[numericGauge2.Markers.Count - 1].Active = false;
        numericGauge2.Markers.RemoveAt(numericGauge2.Markers.Count - 1);
      }

      numericGauge2.ValueFormat = "#.0";

      numericGauge2.Markers.Add(new Marker("1", 36, Steema.TeeChart.Tools.AnnotationPositions.RightTop,
                                            StringAlignment.Center, Color.Red, Color.Red));
      numericGauge2.Markers[1].Chart = revChart.Chart;
      numericGauge2.Markers[1].Shape.Font.Italic = true;
      numericGauge2.Markers[1].Shape.Font.Bold = true;
      numericGauge2.Markers[1].Shape.Transparent = true;
      numericGauge2.Markers[1].Active = true;

    }

    private void initSpeedChart()
    {
      circularGauge2.Axis.Labels.Font.Color = Color.FromArgb(255, 255, 153, 153);
      circularGauge2.HandOffset = 0;
      circularGauge2.Hand.Color = Color.Red;
      circularGauge2.Hand.Brush.Solid = true;
      circularGauge2.Hand.VertSize = 20;
      circularGauge2.Hand.Gradient.Visible = false;
      circularGauge2.Value = 1.8;
      circularGauge2.GreenLine.Visible = false;
      circularGauge2.RedLine.Visible = false;
    }

    public void runCar()
    {
      timer1.Interval = 50;

      currentGear = 1;
      circularGauge1.Value = speedRevDropStart[currentGear - 1] / 1000;
      circularGauge2.Value = 0;
      numericGauge2.Markers[1].Text = currentGear.ToString();
      distance = 10; //10 miles on ODO
      numericGauge2.Value = distance;
      stepRevs = (7600) / (20 * secsToChange[0]);
      stepSpeed = (speedRevChgUp[0]) / (20 * secsToChange[0]);
      interval = new TimeSpan(0, 0, secsToChange[0]);

      changeTime = DateTime.Now;
      timer1.Start();
    }
      

    public void initVars()
    {
      initRevChart();
      initSpeedChart();

      goingThroughGears(); //setup gear/speed arrays

      runCar();

    }

    private int currentGear;
    private TimeSpan interval = new TimeSpan(0);
    private DateTime changeTime;
    private double stepRevs = 0;
    private double stepSpeed = 0;
    private double distance = 0;
    DateTime lastTime = DateTime.Now;
    int longerInterval = 0;
    int redWarningInterval = 0;
    int deltaWarning = 1;
    bool warningOn = false;

    private void timer1_Tick(object sender, EventArgs e)
    {
      DateTime currentTime = DateTime.Now;

      double newSpeed = circularGauge1.Value;

      if ((currentTime - changeTime) > interval)
      {
        currentGear++;
        if (currentGear == 7)
        {
          //pull up in 9 seconds
          stepRevs = -(8100) / (20 * 9); //increase the descent params
          stepSpeed = -(220) / (20 * 9);
          changeTime = DateTime.Now;
          interval = new TimeSpan(0, 0, 9);
        }
        else
        {
          numericGauge2.Markers[1].Text = currentGear.ToString();
          circularGauge1.Value = speedRevDropStart[currentGear - 1] / 1000;
          double topRevs = 7600;
          if (currentGear == 6)
            topRevs = 6500;
          stepRevs = (topRevs - speedRevDropStart[currentGear - 1]) / (20 * secsToChange[currentGear - 1]);
          stepSpeed = (speedRevChgUp[currentGear - 1] - speedRevChgUp[currentGear - 2]) / (20 * secsToChange[currentGear - 1]);  //speedrange/timer_entries/sec * secs
          circularGauge2.Value = speedRevChgUp[currentGear - 2];
          numericGauge1.Value = circularGauge2.Value;
          changeTime = DateTime.Now;
          interval = new TimeSpan(0, 0, secsToChange[currentGear - 1]);
        }
      }
      else
      {
        circularGauge1.Value = circularGauge1.Value + (stepRevs / 1000);
        circularGauge2.Value = circularGauge2.Value + stepSpeed;
        numericGauge1.Value = circularGauge2.Value;

        if (currentGear == 7)
        {
          if (circularGauge2.Value < 2)
          {
            circularGauge1.Value = 0;
            numericGauge1.Value = 0;
            numericGauge2.Markers[1].Text = "1";
            timer1.Stop();
          }
        }

        longerInterval++;

        if (circularGauge1.Value > 6.9)
        {
          //control rev warning light
          if (redWarningInterval >= 8)
          {
            warningOn = true;
            deltaWarning = -1;
          }
          else if (redWarningInterval <= 3)
          {
            redWarningInterval++;
            deltaWarning = 1;
            warningOn = false;
          }

          redWarningInterval = redWarningInterval + deltaWarning;
        }
        else
          warningOn = false;

        if (longerInterval == 50)
        {

          //run down only, down-gear arbitrarily
          if (currentGear == 7)
          {
            if (Convert.ToInt16(numericGauge2.Markers[1].Text) > 1)
              numericGauge2.Markers[1].Text = (Convert.ToInt16(numericGauge2.Markers[1].Text) - 1).ToString();
          }

          //set odometer
          TimeSpan deltaTime = currentTime - lastTime;
          distance = distance + (circularGauge2.Value / 3600 * deltaTime.Seconds);
          numericGauge2.Value = distance;
          longerInterval = 0;
          lastTime = DateTime.Now;
        }
      }

      revChart.Invalidate();
      speedChart.Invalidate();
    }

    private double[] speedRevChgUp;
    private int[] secsToChange;
    private double[] speedRevDropStart;

    private void goingThroughGears()
    {
      //not used
      double[] gearRatios = new double[] { 2.992, 2.080, 1.541, 1.213, 1.000, 0.861 };

      speedRevChgUp = new double[] { 39, 57, 86, 110, 133, 143 };
      secsToChange = new int[] { 3, 3, 4, 6, 6, 10, 20 };
      //gearchanges made at approx 7500rpm
      //137(ish) is a top speed at 7500rpm
      speedRevDropStart = new double[] { 800, 4700, 5400, 5700, 6100, 5600 };

      //perf 1/4 mile 	6.4 sec 0-60mph &	14.9 sec @ 95.5 mph 	Motor Trend
    }

    private void button1_Click(object sender, EventArgs e)
    {
      runCar();
    }

    private void revChart_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      if (warningOn) //display rev warning light
      {
        g.Brush.Image = SubaruBRZSimul.Properties.Resources.redline_warning;
        g.Pen.Transparency = 100;
        g.Rectangle(309, 207, 349, 247);
      }
    }
  }
}
