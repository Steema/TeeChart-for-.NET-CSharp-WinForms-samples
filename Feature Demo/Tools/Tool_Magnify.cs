using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;

namespace Steema.TeeChart.Samples
{
  public class Tool_Magnify : BaseForm
  {
    private CheckBox cbFollowMouse;
    private CheckBox cbCircled;
    private CheckBox cbSmooth;
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
      this.cbFollowMouse = new System.Windows.Forms.CheckBox();
      this.cbSmooth = new System.Windows.Forms.CheckBox();
      this.cbCircled = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "Move the Magnifying glass over the Chart to pick out the detail.\r\n\r\nUse the mouse" +
          " wheel to increase or decrease magnification having \r\nclicked on the Tool to giv" +
          "e it focus. Drag to resize.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cbCircled);
      this.panel1.Controls.Add(this.cbSmooth);
      this.panel1.Controls.Add(this.cbFollowMouse);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ZOffset = 0;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // cbFollowMouse
      // 
      this.cbFollowMouse.AutoSize = true;
      this.cbFollowMouse.Location = new System.Drawing.Point(3, 16);
      this.cbFollowMouse.Name = "cbFollowMouse";
      this.cbFollowMouse.Size = new System.Drawing.Size(91, 17);
      this.cbFollowMouse.TabIndex = 0;
      this.cbFollowMouse.Text = "&Follow Mouse";
      this.cbFollowMouse.UseVisualStyleBackColor = true;
      this.cbFollowMouse.CheckedChanged += new System.EventHandler(this.cbFollowMouse_CheckedChanged);
      // 
      // cbSmooth
      // 
      this.cbSmooth.AutoSize = true;
      this.cbSmooth.Location = new System.Drawing.Point(100, 16);
      this.cbSmooth.Name = "cbSmooth";
      this.cbSmooth.Size = new System.Drawing.Size(62, 17);
      this.cbSmooth.TabIndex = 1;
      this.cbSmooth.Text = "&Smooth";
      this.cbSmooth.UseVisualStyleBackColor = true;
      this.cbSmooth.CheckedChanged += new System.EventHandler(this.cbSmooth_CheckedChanged);
      // 
      // cbCircled
      // 
      this.cbCircled.AutoSize = true;
      this.cbCircled.Location = new System.Drawing.Point(168, 16);
      this.cbCircled.Name = "cbCircled";
      this.cbCircled.Size = new System.Drawing.Size(58, 17);
      this.cbCircled.TabIndex = 2;
      this.cbCircled.Text = "&Circled";
      this.cbCircled.UseVisualStyleBackColor = true;
      this.cbCircled.CheckedChanged += new System.EventHandler(this.cbCircled_CheckedChanged);
      // 
      // Tool_Magnify
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Tool_Magnify";
      this.Text = "Tool_Magnify";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public Tool_Magnify()
    {
      InitializeComponent();
      InitializeChart();
    }

    private Magnify magnify;

    private void InitializeChart()
    {
      tChart1.Series.Add(typeof(Line));
      tChart1.Series.Add(typeof(Points));
      tChart1.Series.Add(typeof(Line));

      tChart1[0].FillSampleValues();
      tChart1[1].FillSampleValues();
      tChart1[2].FillSampleValues();

      tChart1.Tools.Add(magnify = new Magnify());
      magnify.Width = 100;
      magnify.Height = 100;
    }

    private void cbFollowMouse_CheckedChanged(object sender, EventArgs e)
    {
      magnify.FollowMouse = cbFollowMouse.Checked;
    }

    private void cbCircled_CheckedChanged(object sender, EventArgs e)
    {
      magnify.Circled = cbCircled.Checked;
    }

    private void cbSmooth_CheckedChanged(object sender, EventArgs e)
    {
      magnify.Smooth = cbSmooth.Checked;
    }

  }
}
