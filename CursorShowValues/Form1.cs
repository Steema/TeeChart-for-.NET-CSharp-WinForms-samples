using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CursorShowValues
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Styles.Line line2;
		private Steema.TeeChart.Tools.CursorTool cursorTool1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tChart1 = new Steema.TeeChart.TChart();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.line2 = new Steema.TeeChart.Styles.Line();
            this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Width = 0;
            this.tChart1.Axes.Left.Increment = 100D;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "TeeChart"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(16, 8);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Series.Add(this.line2);
            this.tChart1.Size = new System.Drawing.Size(496, 304);
            this.tChart1.TabIndex = 0;
            this.tChart1.Tools.Add(this.cursorTool1);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Visible = false;
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.Red;
            this.line1.Title = "line1";
            // 
            // line2
            // 
            // 
            // 
            // 
            this.line2.Brush.Color = System.Drawing.Color.Green;
            this.line2.Title = "line2";
            // 
            // cursorTool1
            // 
            this.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            this.cursorTool1.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool1_Change);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(528, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tChart1);
            this.Name = "Form1";
            this.Text = "Cursor Show Values";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			line1.FillSampleValues(10);
			line2.FillSampleValues(10);
			cursorTool1.FollowMouse = true;
			cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
			cursorTool1.Pen.Color = Color.Black;
			cursorTool1.Pen.Width = 1;
		}

		private void cursorTool1_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
		{
			int aspWidth = tChart1.Aspect.Width3D;
			tChart1.Refresh();
			for(int i = tChart1.Axes.Left.CalcYPosValue(line1.YValues.Maximum) - aspWidth;
				i <= tChart1.Axes.Left.CalcYPosValue(line1.YValues.Minimum) + aspWidth; ++i) 
			{				
				if(line1.Clicked(e.x, i) != -1) 
				{
					double yValue1 = tChart1.Axes.Left.CalcPosPoint(i);
					label1.Text = "Line 1 - YValue : "+yValue1.ToString();
				}
			}

			for(int j = tChart1.Axes.Left.CalcYPosValue(line2.YValues.Maximum) - aspWidth;
				j <= tChart1.Axes.Left.CalcYPosValue(line2.YValues.Minimum) + aspWidth; ++j) 
			{
				if(line2.Clicked(e.x, j) != -1) 
				{
					double yValue2 = tChart1.Axes.Left.CalcPosPoint(j);
					label2.Text = "Line 2 - YValue : "+yValue2.ToString();
				}
			}
		}
	}
}
