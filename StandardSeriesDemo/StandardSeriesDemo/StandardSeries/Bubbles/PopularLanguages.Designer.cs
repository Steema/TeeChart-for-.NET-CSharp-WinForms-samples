namespace StandardSeriesDemo.StandardSeries.Bubbles
{
    partial class PopularLanguages
    {
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
      this.tChart1 = new Steema.TeeChart.TChart();
      this.SuspendLayout();
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.View3D = false;
      this.tChart1.BackColor = System.Drawing.Color.Transparent;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.tChart1.Footer.Alignment = System.Drawing.StringAlignment.Near;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Gray;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Header.Font.Size = 36;
      this.tChart1.Header.Font.SizeFloat = 36F;
      this.tChart1.Header.Lines = new string[] {
        "Most popular coding languages of 2014"};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Legend.Font.Size = 19;
      this.tChart1.Legend.Font.SizeFloat = 19F;
      this.tChart1.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.Plain;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart1.Size = new System.Drawing.Size(1094, 660);
      this.tChart1.TabIndex = 0;
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
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.White;
      this.tChart1.Walls.Back.Visible = false;
      this.tChart1.GetLegendText += new Steema.TeeChart.GetLegendTextEventHandler(this.tChart1_GetLegendText);
      this.tChart1.DoubleClick += new System.EventHandler(this.tChart1_DoubleClick);
      // 
      // PopularLanguages
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1094, 660);
      this.Controls.Add(this.tChart1);
      this.Name = "PopularLanguages";
      this.Text = "PopularLanguages";
      this.Load += new System.EventHandler(this.PopularLanguages_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
    }
}