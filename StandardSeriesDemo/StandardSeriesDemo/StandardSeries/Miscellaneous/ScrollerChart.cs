using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Drawing;

namespace StandardSeriesDemo.StandardSeries.Miscellaneous
{
  public partial class ScrollerChart : Form
  {
    double axStartValue;
    double axEndValue;

    public ScrollerChart()
    {
      InitializeComponent();
    }

    private Steema.TeeChart.Tools.ScrollPager scroller;

    private void ScrollerChart_Load(object sender, EventArgs e)
    {
      this.SizeChanged += new System.EventHandler(this.Tools_ScrollPager_SizeChanged);

      tChart1.Panel.Gradient.Visible = false;
      tChart1.Panel.MarginTop = 12;

      double[] vals = { 1.234,1.233,1.235,1.241,1.241,1.244,1.239,1.220,1.222,1.224,1.228,1.242,1.241,1.239,1.244,1.238,1.233,1.250,1.253,
                          1.250,1.249,1.240,1.241,1.248,1.240,1.247,1.246,1.247,1.257,1.268,1.265,1.263,1.262,1.268,1.267,1.264,1.271,1.274,
                          1.265,1.275,1.279,1.285,1.292,1.301,1.304,1.317,1.325,1.323,1.321,1.309,1.312,1.308,1.303,1.300,1.301,1.306,1.298,
                          1.302,1.301,1.306,1.314,1.312,1.308,1.300,1.300,1.305,1.312,1.330,1.321,1.319,1.317,1.316,1.312,1.313,1.307,1.306,
                          1.309,1.302,1.297,1.290,1.300,1.290,1.289,1.284,1.282,1.286,1.288,1.289,1.290,1.292,1.290,1.297,1.304,1.310,1.311,
                          1.306,1.308,1.315,1.316,1.321,1.325,1.306,1.302,1.308,1.314,1.323,1.324,1.330,1.330,1.338,1.335,1.334,1.335,1.341,
                          1.338,1.333,1.342,1.328,1.316,1.316,1.324,1.321,1.320,1.340,1.351,1.348,1.342,1.342,1.352,1.345,1.350,1.345,1.347,
                          1.355,1.358,1.357,1.365,1.369,1.376,1.377,1.362,1.367,1.366,1.354,1.350,1.351,1.360,1.353,1.351,1.348,1.348,1.356,
                          1.341,1.337,1.335,1.318,1.322,1.328,1.322,1.314,1.317,1.319,1.313,1.322,1.314,1.315,1.319,1.310,1.317,1.304,1.308,
                          1.303,1.307,1.304,1.320,1.303,1.295,1.293,1.298,1.293,1.296,1.305,1.311,1.316,1.321,1.320,1.323,1.321,1.318,1.331,
                          1.319,1.321,1.319,1.318,1.314,1.317,1.316,1.320,1.320,1.329,1.323,1.324,1.321,1.325,1.329,1.317,1.312,1.314,1.303,
                          1.300,1.300,1.298,1.302,1.304,1.297,1.307,1.307,1.305,1.299,1.309,1.318,1.316,1.319,1.323,1.323,1.338,1.334,1.341,
                          1.344,1.351,1.347,1.347,1.347,1.353,1.337,1.338,1.327,1.321,1.315,1.319,1.319,1.319,1.310,1.313,1.303,1.296,1.302,
                          1.293,1.320,1.321,1.321,1.321,1.327,1.323,1.327,1.328,1.332,1.330,1.341,1.340,1.340,1.338,1.341,1.335,1.341,1.355,
                          1.360,1.363,1.350,1.345,1.344,1.339,1.346,1.346,1.346,1.353,1.347,1.347,1.350,1.350,1.350,1.339,1.336,1.351,1.346,
                          1.346,1.330,1.325,1.382,1.338,1.343,1.340,1.352,1.350,1.351,1.367,1.367,1.368,1.364,1.361 };

      long[] dates = {13420512,13421376,13423968,13424832,13425696,13426560,13427424,13428288,13430016,13430880,
                           13432608,13433472,13436064,13436928,13437792,13438656,13439520,13442112,13442976,13443840,
                           13444704,13445568,13448160,13449024,13450752,13451616,13454208,13455072,13455936,13456800,
                           13457664,13460256,13461120,13461984,13462848,13463712,13466304,13467168,13468032,13468896,
                           13469760,13470624,13472352,13474080,13474944,13475808,13478400,13479264,13480128,13480992,
                           13481856,13484448,13485312,13486176,13487040,13487904,13490496,13491360,13492224,13493088,
                           13493952,13496544,13497408,13498272,13499136,13502592,13503456,13504320,13505184,13506048,
                           13508640,13509504,13510368,13511232,13512096,13515552,13516416,13518144,13520736,13521600,
                           13522464,13523328,13524192,13526784,13527648,13528512,13529376,13530240,13532832,13533696,
                           13534560,13535424,13536288,13538880,13539744,13540608,13541472,13542336,13544928,13545792,
                           13546656,13548384,13550976,13551840,13552704,13553568,13554432,13557024,13557888,13558752,
                           13559616,13560480,13563072,13565664,13566528,13569120,13570848,13571712,13572576,13575168,
                           13576032,13576896,13577760,13578624,13581216,13582080,13582944,13583808,13584672,13587264,
                           13588128,13588992,13589856,13590720,13593312,13594176,13595040,13595904,13596768,13599360,
                           13600224,13601088,13601952,13602816,13605408,13606272,13607136,13608000,13608864,13611456,
                           13612320,13613184,13614048,13614912,13617504,13618368,13619232,13620096,13620960,13623552,
                           13624416,13625280,13626144,13627008,13629600,13630464,13631328,13632192,13633056,13635648,
                           13636512,13637376,13638240,13639104,13641696,13642560,13643424,13644288,13648608,13649472,
                           13650336,13651200,13653792,13654656,13655520,13656384,13657248,13659840,13660704,13661568,
                           13662432,13663296,13665888,13666752,13667616,13668480,13669344,13671936,13672800,13674528,
                           13675392,13677984,13678848,13679712,13680576,13681440,13684032,13684896,13685760,13686624,
                           13687488,13690080,13690944,13691808,13692672,13693536,13696128,13696992,13697856,13698720,
                           13699584,13702176,13703040,13703904,13704768,13705632,13708224,13709088,13709952,13710816,
                           13711680,13714272,13715136,13716000,13716864,13717728,13721184,13722048,13722912,13723776,
                           13726368,13727232,13728096,13728960,13729824,13732416,13733280,13734144,13735008,13735872,
                           13738464,13739328,13740192,13741056,13741920,13744512,13745376,13746240,13747968,13750560,
                           13751424,13752288,13753152,13754016,13756608,13757472,13758336,13759200,13760064,13762656,
                           13763520,13764384,13766112,13768704,13769568,13770432,13771296,13772160,13774752,13775616,
                           13776480,13777344,13778208,13780800,13781664,13782528,13783392,13784256,13786848,13787712,
                           13789440,13790304,13792896,13793760,13794624,13795488,13796352,13798944,13799808,13800672};


      tChart1[0].Title = "USD to Euro";
      tChart1[0].Add(vals);

      double[] avgDates = new double[tChart1.Series[0].Count];

      for (int t = 0; t < tChart1.Series[0].Count; t++)
      {
        System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        dtDateTime = dtDateTime.AddSeconds(dates[t] * 100).ToLocalTime();
        double tmpVal = dtDateTime.ToOADate();
        avgDates[t] = tmpVal;
        tChart1.Series[0].XValues.Value[t] = avgDates[t];
      }

      //config some series appearance characteristics
      //for (int i = 0; i < 1; i++)
      //{
      //tChart1.Series(i).asLine.Pointer.Visible = true;
      //tChart1.Series(i).asLine.Pointer.HorizontalSize = 4;
      //tChart1.Series(i).asLine.Pointer.VerticalSize = 4;
      //tChart1.Series(i).asLine.Pointer.Style = TeeChart.EPointerStyle.psCircle;
      //tChart1.Series(i).asLine.Pointer.Pen.Width = 2;                  
      //tChart1.Series(i).asLine.Pointer.Shadow.Visible=false;
      //line1.LinePen.Width = 2;
      //}

      //Axes
      tChart1.Axes.Left.Title.Caption = "$ 000s";
      tChart1.Axes.Left.Labels.RoundFirstLabel = true;
      tChart1.Axes.Left.Title.Visible = false;
      tChart1.Axes.Bottom.Labels.RoundFirstLabel = true;
      tChart1.Axes.Bottom.Title.Caption = "Bottom Axis";
      tChart1.Axes.Bottom.Title.Font.Size = 20;
      tChart1.Axes.Bottom.Title.Visible = false;
      tChart1.Axes.Bottom.Labels.DateTimeFormat = "dd/MM/yy";
      tChart1.Axes.Left.SetMinMax(1.2, 1.41);
      tChart1.Axes.Left.Grid.Width = 1;
      tChart1.Axes.Bottom.AxisPen.Width = 1;
      tChart1.Axes.Bottom.SetMinMax(tChart1[0].XValues.Value[50], tChart1[0].XValues.Value[250]);
      tChart1.Axes.Bottom.Grid.Visible = false;
      tChart1.Series[0].XValues.DateTime = true;
      tChart1.Axes.Left.Labels.Separation = 100;

      //Title
      tChart1.Header.Visible = false;

      //Legend
      tChart1.Legend.Visible = false;

      tChart1.Axes.Left.StartPosition = 10;

      /*// annotation (alternative title) //
      Steema.TeeChart.Tools.Annotation ann1 = new Steema.TeeChart.Tools.Annotation();
      tChart1.Tools.Add(ann1); //   TeeChart.EToolClass.tcAnnotate);
      ann1.Shape.Font.Size  =20;
      ann1.Text = "US Dollar against the Euro";
      ann1.Shape.Transparent = true;
  
      // annotation (alternative title)
      Steema.TeeChart.Tools.Annotation ann2 = new Steema.TeeChart.Tools.Annotation();
      tChart1.Tools.Add(ann2);
      ann2.Text = "  2012 - 2013 Source: Steema Software SL";
      ann2.Shape.Transparent = true;

      tChart1.Draw();  //get positions
    
      ann1.Left = tChart1.Axes.Bottom.CalcXPosValue(tChart1.Axes.Bottom.Minimum);
      ann1.Top = 8;
      ann2.Left = tChart1.Axes.Bottom.CalcXPosValue(tChart1.Axes.Bottom.Minimum);
      ann2.Top = 38;*/

      //tooltip
      Steema.TeeChart.Tools.MarksTip marks = new Steema.TeeChart.Tools.MarksTip();
      tChart1.Tools.Add(marks);

      tChart1.Zoom.Active = false;
      tChart1.Panning.Allow = Steema.TeeChart.ScrollModes.Horizontal;

      //scroller  
      scroller = new Steema.TeeChart.Tools.ScrollPager();
      tChart1.Tools.Add(scroller);
      scroller.Series = line1;
      scroller.SubChartTChart.Panel.Gradient.Visible = false;
      scroller.SubChartTChart.Walls.Back.Visible = false;
      scroller.SubChartTChart.Axes.Left.Visible = false;
      scroller.SubChartTChart.Axes.Bottom.Labels.DateTimeFormat = "MM/yy";

      axStartValue = tChart1.Series[0].XValues[70];
      axEndValue = tChart1.Series[0].XValues[tChart1.Series[0].Count - 70];

      //tChart1.Refresh();
      scroller.SubChartTChart.Footer.Font.Italic = true;
      scroller.SubChartTChart.Footer.Text = "         Showing data from " + DateTime.FromOADate(axStartValue).ToLongDateString() + " to " 
                                                                 + DateTime.FromOADate(axEndValue).ToLongDateString();
      scroller.SubChartTChart.Footer.Visible = true;
      scroller.SubChartTChart.Panel.Color = Color.White;
      scroller.SubChartTChart.Footer.Alignment = StringAlignment.Near;
      scroller.DivisionRatio = 8;
      scroller.StartLinePointer.Visible = false;
      scroller.EndLinePointer.Visible = false;
    }

    private void tChart1_OnDblClick(object sender, EventArgs e)
    {
      tChart1.ShowEditor();
      tChart1.Chart.CancelMouse = true;
    }

    private void tChart1_DoubleClick(object sender, EventArgs e)
    {
      (sender as Steema.TeeChart.TChart).Zoom.Active = false;
      (sender as Steema.TeeChart.TChart).ShowEditor();
      (sender as Steema.TeeChart.TChart).Chart.CancelMouse = true;
      (sender as Steema.TeeChart.TChart).Zoom.Active = true;
    }

    private void ScrollerChart_Resize(object sender, EventArgs e)
    {
      tChart1.Refresh();
      if (scroller != null)
        scroller.SubChartTChart.Refresh();
    }

    private void Tools_ScrollPager_SizeChanged(object sender, EventArgs e)
    {
      scroller.Series = line1;

      scroller.SubChartTChart.Panel.Pen.Visible = false;
      scroller.SubChartTChart.Panel.Bevel.Inner = BevelStyles.None;
      scroller.SubChartTChart.Panel.Bevel.Outer = BevelStyles.None;

      scroller.StartValue = tChart1.Series[0].XValues[70];
      scroller.EndValue = tChart1.Series[0].XValues[tChart1.Series[0].Count - 70];

      axStartValue = scroller.StartValue;
      axEndValue = scroller.EndValue;
    }

    int paintFirst = 0;

    private void tChart1_AfterDraw(object sender, Graphics3D g)
    {
      if (paintFirst > 1)
      {
        axStartValue = tChart1.Axes.Bottom.Minimum;
        axEndValue = tChart1.Axes.Bottom.Maximum;
      }

      paintFirst++;

      scroller.SubChartTChart.Footer.Font.Color = System.Drawing.Color.DarkBlue;
      scroller.SubChartTChart.Footer.Text = "         Showing data from " + DateTime.FromOADate(axStartValue).ToLongDateString() + " to " + DateTime.FromOADate(axEndValue).ToLongDateString();
    }

  }
}
