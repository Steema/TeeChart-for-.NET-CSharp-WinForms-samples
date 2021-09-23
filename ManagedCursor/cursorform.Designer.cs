namespace ManagedCursor
{
    partial class cursorform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cursorform));
            this.tChart3 = new Steema.TeeChart.TChart();
            this.fastLine4 = new Steema.TeeChart.Styles.FastLine();
            this.cursorTool3 = new Steema.TeeChart.Tools.CursorTool();
            this.cursorTool4 = new Steema.TeeChart.Tools.CursorTool();
            this.tChart4 = new Steema.TeeChart.TChart();
            this.fastLine3 = new Steema.TeeChart.Styles.FastLine();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
            this.cursorTool2 = new Steema.TeeChart.Tools.CursorTool();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tChart3
            // 
            // 
            // 
            // 
            this.tChart3.Header.Lines = new string[] {
        "TeeChart3"};
            // 
            // 
            // 
            this.tChart3.Legend.Visible = false;
            this.tChart3.Location = new System.Drawing.Point(33, 468);
            this.tChart3.Name = "tChart3";
            this.tChart3.Series.Add(this.fastLine4);
            this.tChart3.Size = new System.Drawing.Size(656, 150);
            this.tChart3.TabIndex = 5;
            this.tChart3.Tools.Add(this.cursorTool3);
            this.tChart3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart3_MouseMove);
            // 
            // fastLine4
            // 
            this.fastLine4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.fastLine4.ColorEach = false;
            // 
            // 
            // 
            this.fastLine4.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine4.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;

            this.fastLine4.Marks.TailParams.Margin = 0F;
            this.fastLine4.Marks.TailParams.PointerHeight = 8D;
            this.fastLine4.Marks.TailParams.PointerWidth = 8D;
            this.fastLine4.OriginalCursor = null;
            this.fastLine4.Title = "fastLine1";
            this.fastLine4.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine4.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine4.XValues.DataMember = "X";
            this.fastLine4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine4.YValues.DataMember = "Y";
            // 
            // cursorTool3
            // 
            this.cursorTool3.FollowMouse = true;
            this.cursorTool3.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            this.cursorTool3.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool3_Change);
            // 
            // cursorTool4
            // 
            this.cursorTool4.FollowMouse = true;
            this.cursorTool4.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            this.cursorTool4.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool4_Change);
            // 
            // tChart4
            // 
            // 
            // 
            // 
            this.tChart4.Header.Lines = new string[] {
        "TeeChart4"};
            // 
            // 
            // 
            this.tChart4.Legend.Visible = false;
            this.tChart4.Location = new System.Drawing.Point(33, 654);
            this.tChart4.Name = "tChart4";
            this.tChart4.Series.Add(this.fastLine3);
            this.tChart4.Size = new System.Drawing.Size(656, 150);
            this.tChart4.TabIndex = 4;
            this.tChart4.Tools.Add(this.cursorTool4);
            this.tChart4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart4_MouseMove);
            // 
            // fastLine3
            // 
            this.fastLine3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.fastLine3.ColorEach = false;
            // 
            // 
            // 
            this.fastLine3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.fastLine3.Marks.TailParams.Margin = 0F;
            this.fastLine3.Marks.TailParams.PointerHeight = 8D;
            this.fastLine3.Marks.TailParams.PointerWidth = 8D;
            this.fastLine3.OriginalCursor = null;
            this.fastLine3.Title = "fastLine1";
            this.fastLine3.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine3.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine3.XValues.DataMember = "X";
            this.fastLine3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine3.YValues.DataMember = "Y";
            // 
            // tChart2
            // 
            // 
            // 
            // 
            this.tChart2.Header.Lines = new string[] {
        "TeeChart2"};
            // 
            // 
            // 
            this.tChart2.Legend.Visible = false;
            this.tChart2.Location = new System.Drawing.Point(33, 281);
            this.tChart2.Name = "tChart2";
            this.tChart2.Series.Add(this.fastLine2);
            this.tChart2.Size = new System.Drawing.Size(656, 150);
            this.tChart2.TabIndex = 2;
            this.tChart2.Tools.Add(this.cursorTool2);
            this.tChart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart2_MouseMove);
            // 
            // fastLine2
            // 
            this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.fastLine2.ColorEach = false;
            // 
            // 
            // 
            this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;

            this.fastLine2.Marks.TailParams.Margin = 0F;
            this.fastLine2.Marks.TailParams.PointerHeight = 8D;
            this.fastLine2.Marks.TailParams.PointerWidth = 8D;
            this.fastLine2.OriginalCursor = null;
            this.fastLine2.Title = "fastLine1";
            this.fastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine2.XValues.DataMember = "X";
            this.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine2.YValues.DataMember = "Y";
            // 
            // cursorTool2
            // 
            this.cursorTool2.FollowMouse = true;
            this.cursorTool2.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            this.cursorTool2.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool2_Change);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "TeeChart1"};
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(33, 93);
            this.tChart1.Name = "tChart1";
            this.tChart1.Series.Add(this.fastLine1);
            this.tChart1.Size = new System.Drawing.Size(656, 150);
            this.tChart1.TabIndex = 1;
            this.tChart1.Tools.Add(this.cursorTool1);
            this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
            // 
            // fastLine1
            // 
            this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.fastLine1.ColorEach = false;
            // 
            // 
            // 
            this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;

            this.fastLine1.Marks.TailParams.Margin = 0F;
            this.fastLine1.Marks.TailParams.PointerHeight = 8D;
            this.fastLine1.Marks.TailParams.PointerWidth = 8D;
            this.fastLine1.OriginalCursor = null;
            this.fastLine1.Title = "fastLine1";
            this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine1.XValues.DataMember = "X";
            this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine1.YValues.DataMember = "Y";
            // 
            // cursorTool1
            // 
            this.cursorTool1.FollowMouse = true;
            this.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            this.cursorTool1.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool1_Change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(34, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(216, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Interpolate all Chart values";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cursorform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 827);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tChart3);
            this.Controls.Add(this.tChart4);
            this.Controls.Add(this.tChart2);
            this.Controls.Add(this.tChart1);
            this.Name = "cursorform";
            this.Text = "cursorform";
            this.Load += new System.EventHandler(this.cursorform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.TChart tChart2;
        private Steema.TeeChart.TChart tChart3;
        private Steema.TeeChart.TChart tChart4;
        private Steema.TeeChart.Styles.FastLine fastLine2;
        private Steema.TeeChart.Tools.CursorTool cursorTool2;
        private Steema.TeeChart.Styles.FastLine fastLine1;
        private Steema.TeeChart.Tools.CursorTool cursorTool1;
        private Steema.TeeChart.Styles.FastLine fastLine4;
        private Steema.TeeChart.Tools.CursorTool cursorTool4;
        private Steema.TeeChart.Styles.FastLine fastLine3;
        private Steema.TeeChart.Tools.CursorTool cursorTool3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


