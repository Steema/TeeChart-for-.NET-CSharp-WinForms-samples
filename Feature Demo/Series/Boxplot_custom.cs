using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Boxplot_custom : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.Box box1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components = null;

		public Boxplot_custom()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
      box1.Clear();
      box1.Add(new double[8] {12, 14, 18, 18.5, 18.6, 18.6, 19, 24});
      box1.UseCustomValues = false;
      UpdateDisplay();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.box1 = new Steema.TeeChart.Styles.Box();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Name = "textBox1";
      this.textBox1.Text = "Now you can fully customize all Boxplot series parameters. All you must do \r\nis s" +
        "et UseCustomValues property to true and then pass your values to \r\nQuartile, Inn" +
        "erFence and OuterFence properties.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(440, 79);
      // 
      // tChart1
      // 
      // 
      // tChart1.Header
      // 
      // 
      // tChart1.Header.Font
      // 
      this.tChart1.Header.Font.Bold = true;
      // 
      // tChart1.Header.Font.Brush
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Header.Lines = new string[] {
                                                 "Boxplot series custom values"};
      // 
      // tChart1.Legend
      // 
      this.tChart1.Legend.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(0, 152);
      this.tChart1.Name = "tChart1";
      // 
      // tChart1.Panel
      // 
      // 
      // tChart1.Panel.Brush
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
      // 
      // tChart1.Panel.Brush.Gradient
      // 
      this.tChart1.Panel.Brush.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
      this.tChart1.Panel.Brush.Gradient.Visible = true;
      this.tChart1.Series.Add(this.box1);
      this.tChart1.Size = new System.Drawing.Size(440, 165);
      this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
      // 
      // box1
      // 
      this.box1.AdjacentPoint1 = 1;
      this.box1.AdjacentPoint3 = 22;
      // 
      // box1.ExtrOut
      // 
      this.box1.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star;
      this.box1.InnerFence1 = -12.5;
      this.box1.InnerFence3 = 35.5;
      this.box1.Median = 12;
      // 
      // box1.MedianPen
      // 
      this.box1.MedianPen.Style = System.Drawing.Drawing2D.DashStyle.Dot;
      // 
      // box1.MildOut
      // 
      this.box1.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
      this.box1.OuterFence1 = -30.5;
      this.box1.OuterFence3 = 53.5;
      // 
      // box1.Pointer
      // 
      // 
      // box1.Pointer.Brush
      // 
      this.box1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
      this.box1.Pointer.Draw3D = false;
      this.box1.Pointer.HorizSize = 15;
      this.box1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.box1.Pointer.VertSize = 15;
      this.box1.Quartile1 = 5.5;
      this.box1.Quartile3 = 17.5;
      this.box1.Title = "box1";
      // 
      // box1.XValues
      // 
      this.box1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // checkBox1
      // 
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox1.Location = new System.Drawing.Point(16, 16);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(136, 24);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "Use custom values";
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(176, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(184, 16);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(176, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(184, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "label2";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(176, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(176, 16);
      this.label3.TabIndex = 3;
      this.label3.Text = "label3";
      // 
      // Boxplot_custom
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Boxplot_custom";
      this.panel1.ResumeLayout(false);

    }
		#endregion

    private void UpdateDisplay()
    {
      if (box1.UseCustomValues)
      {
        box1.Median = 15;
        box1.Quartile1 = 13;
        box1.Quartile3 = 17;
        box1.InnerFence1 = 12;
        box1.InnerFence3 = 18;
        box1.OuterFence1 = 10;
        box1.OuterFence3 = 20;
      }
      label1.Text = "Median = " + box1.Median.ToString("0.00");
      label2.Text = "Inner Fences = ["+ box1.InnerFence1.ToString("0.00")+
                    " ; " + box1.InnerFence3.ToString("0.00")+ "]";
      label3.Text = "Outer Fences = ["+box1.OuterFence1.ToString("0.00")+
                    " ; "+box1.OuterFence3.ToString("0.00")+"]";
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      box1.UseCustomValues = checkBox1.Checked;
      UpdateDisplay();
      tChart1.Refresh();
    }

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      UpdateDisplay();
    }
	}
}

