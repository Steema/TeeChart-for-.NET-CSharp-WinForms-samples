using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Drawing;

namespace Steema.TeeChart.Samples
{
  public class CircularGauge_Embed : BaseForm
  {
    private Timer timer1;
    private ComboBox cbPalette;
    private Label label1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.cbPalette = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "Using a very simple technique demonstrated here, multiple Numeric Gauges\r\nand/or " +
          "LinearGauges can be embedded in a CircularGauge.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cbPalette);
      this.panel1.Controls.Add(this.label1);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ZOffset = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.PartnerAxis = null;
      this.tChart1.Axes.Bottom.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.PartnerAxis = null;
      this.tChart1.Axes.Depth.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.PartnerAxis = null;
      this.tChart1.Axes.DepthTop.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.PartnerAxis = null;
      this.tChart1.Axes.Left.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.Right.PartnerAxis = null;
      this.tChart1.Axes.Right.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.Top.PartnerAxis = null;
      this.tChart1.Axes.Top.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Legend.TextSymbolGap = 0;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // timer1
      // 
      this.timer1.Interval = 10;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Palette:";
      // 
      // cbPalette
      // 
#if VS2005
      this.cbPalette.FormattingEnabled = true;
#endif
      this.cbPalette.Location = new System.Drawing.Point(61, 11);
      this.cbPalette.Name = "cbPalette";
      this.cbPalette.Size = new System.Drawing.Size(217, 21);
      this.cbPalette.TabIndex = 1;
      this.cbPalette.SelectedIndexChanged += new System.EventHandler(this.cbPalette_SelectedIndexChanged);
      // 
      // CircularGauge_Embed
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "CircularGauge_Embed";
      this.Text = "CircularGauge_Embed";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public CircularGauge_Embed()
    {
      InitializeComponent();
      FillComboBox();
      InitializeChart();
    }

    private void FillComboBox()
    {
      cbPalette.Items.Add("Current");
      cbPalette.Items.Add("BlackPalette");
      cbPalette.Items.Add("BluesPalette");
      cbPalette.Items.AddRange(Steema.TeeChart.Themes.Theme.ColorPalettes.ToArray());
      cbPalette.SelectedIndex = 0;
    }

    private CircularGauge cGauge;
    private NumericGauge nGauge;
    private LinearGauge lGauge;

    private void InitializeChart()
    {
      tChart1.Series.Add(cGauge = new CircularGauge());
      cGauge.RotationAngle = 270;
      cGauge.TotalAngle = 180;
      cGauge.Axis.Labels.Font.Size = 7;
      cGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, cGauge.GaugeColorPalette);
      cGauge.RedLine.Visible = false;
      cGauge.GreenLine.Visible = false;
      cGauge.BeforeDrawHand+=new PaintChartEventHandler(cGauge_BeforeDrawHand);
      cGauge.Value = 1;

      timer1.Enabled = true;

      SetUpNGauge();
      SetUpLGauge();
    }

    private void SetUpLGauge()
    {
      Axis axisH = new Axis();
      axisH.Horizontal = true;
      Axis axisV = new Axis();
      axisV.Horizontal = false;
      lGauge = new LinearGauge();
      lGauge.HorizAxis = HorizontalAxis.Custom;
      lGauge.VertAxis = VerticalAxis.Custom;
      lGauge.Horizontal = false;
      lGauge.Visible = false;
      lGauge.CustomHorizAxis = axisH;
      lGauge.CustomVertAxis = axisV;
      lGauge.Axis.Title.Font.Size = 7;
      lGauge.Axis.Title.Font.Color = CustomGauge.GetGaugePaletteColor(20, lGauge.GaugeColorPalette);
      lGauge.Axis.Title.Caption = "Independent value";
      lGauge.Axis.Labels.Font.Size = 6;
      lGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, lGauge.GaugeColorPalette);
      lGauge.Axis.Increment = 20;
      lGauge.RedLine.Visible = false;
      lGauge.GreenLine.Visible = false;
      lGauge.Frame.Visible = false;
      lGauge.FaceBrush.Visible = false;
    }

    private void SetUpNGauge()
    {
      Axis axis = new Axis();
      axis.Horizontal = true;
      nGauge = new NumericGauge();
      nGauge.HorizAxis = HorizontalAxis.Custom;
      nGauge.CustomHorizAxis = axis;
      nGauge.Visible = false;
      nGauge.TextMarker.Active = false;
      nGauge.UnitsMarker.Active = false;
      nGauge.Horizontal = true;
      nGauge.ValueFormat = "###.0";
      nGauge.ValueMarker.Active = true;
      nGauge.ValueMarker.Shape.Font.Size = 14;
    }


    private Rectangle CalcLGaugeBounds()
    {
      Rectangle result = Steema.TeeChart.Utils.FromLTRB(cGauge.CircleXCenter + (cGauge.CircleWidth / 7),
        cGauge.CircleYCenter - (cGauge.CircleHeight / 3), cGauge.CircleXCenter + (cGauge.CircleWidth / 4),
        cGauge.CircleYCenter + (cGauge.CircleHeight / 3));
      return result;
    }

    private Rectangle CalcNGaugeBounds()
    {
      Rectangle result = Steema.TeeChart.Utils.FromLTRB(cGauge.CircleXCenter - Steema.TeeChart.Utils.Round(cGauge.CircleWidth / 3.75),
        cGauge.CircleYCenter - (cGauge.CircleHeight / 10), cGauge.CircleXCenter - (cGauge.CircleWidth / 12),
        cGauge.CircleYCenter + (cGauge.CircleHeight / 10));
      return result;
    }

    private void DrawNGauge(Graphics3D g)
    {
      nGauge.Value = cGauge.Value;
      nGauge.CustomBounds = CalcNGaugeBounds();
      nGauge.Draw(g);
    }

    private Random rnd = new Random();

    private void DrawLGauge(Graphics3D g)
    {
      lGauge.Value = rnd.Next(0, 100); 
      lGauge.CustomBounds = CalcLGaugeBounds();
      lGauge.Draw(g);
    }

    void cGauge_BeforeDrawHand(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      DrawNGauge(g);
      DrawLGauge(g);
    }


    private bool up = true;

    private void timer1_Tick(object sender, EventArgs e)
    {
      if ((int)cGauge.Value == 100 || (int)cGauge.Value == 0.0)
      {
        up = !up;
      }

      if (up)
      {
        cGauge.Value += 0.1;
      }
      else
      {
        cGauge.Value -= 0.1;
      }
    }

    private void ApplyPalette(Color[] palette)
    {
      cGauge.GaugeColorPalette = palette;
      cGauge.GreenLine.Visible = false;
      cGauge.RedLine.Visible = false;
      lGauge.GaugeColorPalette = palette;
      lGauge.GreenLine.Visible = false;
      lGauge.RedLine.Visible = false;
      lGauge.FaceBrush.Visible = false;
      lGauge.Hand.Pen.Visible = false;
    }

    private void cbPalette_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbPalette.SelectedIndex > 2)
      {
        ApplyPalette(Steema.TeeChart.Themes.ColorPalettes.GetPalette(cbPalette.SelectedIndex - 3));
      }
      else if (cbPalette.SelectedIndex == 1)
      {
        ApplyPalette(Steema.TeeChart.Styles.CustomGauge.BlackPalette);
      }
      else if (cbPalette.SelectedIndex == 2)
      {
        ApplyPalette(Steema.TeeChart.Styles.CustomGauge.BluesPalette);
      }
    }
  }
}
