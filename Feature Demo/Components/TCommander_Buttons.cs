using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class TCommander_Buttons : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Commander commander1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public TCommander_Buttons()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			InitialiseChart();
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
			this.commander1 = new Steema.TeeChart.Commander();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "TeeChart\'s Commander ToolBar can now be fully customised by the addition of desir" +
				"ed buttons and separators.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.commander1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Commander Buttons"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// commander1
			// 
			this.commander1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.commander1.DropDownArrows = true;
			this.commander1.Location = new System.Drawing.Point(0, 0);
			this.commander1.Name = "commander1";
			this.commander1.ShowToolTips = true;
			this.commander1.Size = new System.Drawing.Size(440, 37);
			this.commander1.TabIndex = 0;
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.Red;
			// 
			// line1.Marks
			// 
			// 
			// line1.Marks.Symbol
			// 
			// 
			// line1.Marks.Symbol.Shadow
			// 
			this.line1.Marks.Symbol.Shadow.Height = 1;
			this.line1.Marks.Symbol.Shadow.Visible = true;
			this.line1.Marks.Symbol.Shadow.Width = 1;
			// 
			// line1.Pointer
			// 
			// 
			// line1.Pointer.Brush
			// 
			this.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "line1";
			// 
			// line1.XValues
			// 
			this.line1.XValues.DataMember = "X";
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line1.YValues
			// 
			this.line1.YValues.DataMember = "Y";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// TCommander_Buttons
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "TCommander_Buttons";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void InitialiseChart() {
			const int buttonCount = 5;
			ToolBarButton[] comButtons = new ToolBarButton[buttonCount];

			foreach(ToolBarButton button in commander1.Buttons) {
				button.Pushed = false;
				switch(button.Tag.ToString()) {
					case "bNormal":
						break;
					case "bSeparator":
						comButtons[1] = button;
						comButtons[3] = button;
						break;
					case "bRotate":
						button.Pushed = true;
						comButtons[0] = button;
						break;
					case "bMove":
						break;
					case "bZoom":
						comButtons[2] = button;
						break;
					case "bDepth":
						break;
					case "bView3D":
						break;
					case "bEdit":
						comButtons[4] = button;
						break;
					case "bPrint":
						break;
					case "bCopy":
						break;
					case "bExport":
						break;
					
				}
			}
			
			commander1.Buttons = comButtons;
			commander1.Chart = tChart1;
			line1.FillSampleValues();
		}
	}
}

