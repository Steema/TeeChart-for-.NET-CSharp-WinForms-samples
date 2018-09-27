using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Tool_Fader : BaseForm
	{
		private Button bEdit;
		private Button bStart;
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
			if(disposing && (components != null))
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
			this.bEdit = new System.Windows.Forms.Button();
			this.bStart = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "The Fader Tool creates an Animated Chart which fades in and out of a specified co" +
					"lor.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bStart);
			this.panel1.Controls.Add(this.bEdit);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
			this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Panel.Brush.Gradient.Sigma = true;
			this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
			this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// bEdit
			// 
			this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bEdit.Location = new System.Drawing.Point(115, 10);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(75, 23);
			this.bEdit.TabIndex = 0;
			this.bEdit.Text = "Edit...";
#if VS2005
			this.bEdit.UseVisualStyleBackColor = true;
#endif
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// bStart
			// 
			this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bStart.Location = new System.Drawing.Point(12, 10);
			this.bStart.Name = "bStart";
			this.bStart.Size = new System.Drawing.Size(75, 23);
			this.bStart.TabIndex = 1;
			this.bStart.Text = "Start";
#if VS2005
			this.bStart.UseVisualStyleBackColor = true;
#endif
			this.bStart.Click += new System.EventHandler(this.bStart_Click);
			// 
			// Tool_Fader
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Tool_Fader";
			this.Text = "Tool_Fader";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Tool_Fader()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Steema.TeeChart.Tools.FaderTool fader;
		private Steema.TeeChart.Styles.Bar bar;
		private void InitializeChart()
		{
			tChart1.Tools.Add(fader = new Steema.TeeChart.Tools.FaderTool());
			tChart1.Series.Add(bar = new Steema.TeeChart.Styles.Bar());
			bar.FillSampleValues();
			fader.Color = tChart1.Panel.Gradient.EndColor;
			fader.Speed = 2;
			fader.FaderStop += new EventHandler(fader_FaderStop); 

		}

		private void fader_FaderStop(object sender, EventArgs e)
		{
			if(bStart.Text == "Stop")
			{
				if(fader.Style == Steema.TeeChart.Tools.FaderStyle.FadeIn)
				{
					fader.Style = Steema.TeeChart.Tools.FaderStyle.FadeOut;
				}
				else
				{
					fader.Style = Steema.TeeChart.Tools.FaderStyle.FadeIn;
				}
				fader.Start();
			}
		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			Steema.TeeChart.Editors.Tools.FaderToolEditor faderEdit = new Steema.TeeChart.Editors.Tools.FaderToolEditor(fader);
      Steema.TeeChart.Editors.EditorUtils.Translate(faderEdit);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(faderEdit);
		}

		private void bStart_Click(object sender, EventArgs e)
		{
			if(bStart.Text == "Start")
			{
				bStart.Text = "Stop";
				fader.Start();
			}
			else if(bStart.Text == "Stop")
			{
				bStart.Text = "Start";
				fader.Stop();
			}
		}
	}
}