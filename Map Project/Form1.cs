using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using System.Security;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using Steema.TeeChart.Data;

namespace TeeMaps
{
  /// <summary>
  /// Summary description for Form1.
  /// </summary>
  public class TeeSHPForm : System.Windows.Forms.Form
  {
    private Steema.TeeChart.Commander commander1;
    private System.Windows.Forms.SplitContainer splitter1;
    private System.Windows.Forms.TabControl tabControl2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.ComponentModel.IContainer components;

    private TeeSHP teeSHP;
    private System.Windows.Forms.CheckBox cbDebug;
    private Random rnd = new Random();
    private System.Windows.Forms.CheckBox cBOutline;
    private System.Windows.Forms.CheckBox cBOutlineColor;
    private System.Windows.Forms.CheckBox cBClipOutline;
    private System.Windows.Forms.StatusBar statusBar1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.SplitContainer splitter2;
    private System.Windows.Forms.SplitContainer splitter3;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tPDebug;
    private System.Windows.Forms.ListBox lBCities;
    private System.Windows.Forms.ListBox listBox1;
    private int Old;
    private bool zoom = false;
    private System.Windows.Forms.CheckBox checkBox2;
    private Steema.TeeChart.TChart tChart1;
    private Steema.TeeChart.ChartListBox chartListBox1;
    private Steema.TeeChart.Styles.Map map1;
    private Steema.TeeChart.Styles.Points points1;
    private Steema.TeeChart.Tools.ColorLine colorLine1;
    private Steema.TeeChart.Tools.ColorLine colorLine2;
    private Steema.TeeChart.Tools.ColorLine colorLine3;
    private Steema.TeeChart.Tools.GridBand gridBand1;
    private Steema.TeeChart.Data.TextSource textSource1;
    private Steema.TeeChart.Tools.Annotation annotation1;
    private Steema.TeeChart.Tools.Annotation annotation2;
    private string path;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private DataTable Table1;
    private TabControl tabControl3;
    private TChart tChart2;
    private Line Route66 = new Line();
    private Points NuclearPlants = new Points();
    private Points Cities = new Points();
    private Map Populated = new Map();
    private TabPage tabPage3;
    private TabPage tabPage4;
    private CheckBox cbUSAColors;
    private CheckBox cbPopulated;
    private CheckBox cbNuclear;
    private CheckBox cbRoute66;
    private Button button2;
    private World USA = new World();


    public TeeSHPForm()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();
      InitializeChart();
      teeSHP = new TeeSHP();
      tabControl2 = new TabControl();
      tPDebug.Parent = tabControl2;
      commander1.Chart = tChart1;
      tabControl1.SelectedIndex = 0;

      Screen screen = Screen.FromControl(this);
      this.Height = Convert.ToInt32(screen.WorkingArea.Height * 0.75);
      this.Width = Convert.ToInt32(screen.WorkingArea.Width * 0.75);

      tChart1.Axes.Left.SetMinMax(-90, 90);
      tChart1.Axes.Left.Labels.ValueFormat = "0º";
      tChart1.Axes.Bottom.SetMinMax(-180, 180);
      tChart1.Axes.Bottom.Labels.ValueFormat = "0º";
      tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
      points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None;
      points1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.None;

      chartListBox1.ShowSeriesIcon = false;
      chartListBox1.ItemHeight = 20;

      colorLine1.Value = 0;
      colorLine2.Value = 23.5;
      colorLine2.Pen.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
      colorLine3.Value = -23.5;
      colorLine3.Pen.Style = System.Drawing.Drawing2D.DashStyle.DashDot;

      annotation1.Shape.CustomPosition = true;
      annotation1.Active = false;
      annotation2.Shape.Font.Bold = true;
      annotation2.Shape.Font.Color = Color.Purple;
      annotation2.Shape.Font.Size = 14;
      annotation2.Shape.Font.Name = "Verdana";
      annotation2.Shape.Shadow.Visible = false;
      annotation2.Shape.BorderRound = 30;
      annotation2.Shape.Gradient.Visible = true;
      annotation2.Callout.Arrow.Color = Color.Purple;
      annotation2.Callout.Arrow.Width = 3;

    }


    private void HidePointsOutsideUSA(Series series)
    {
      double x0 = USA.MinXValue();
      double x1 = USA.MaxXValue();
      double y0 = USA.MinYValue();
      double y1 = USA.MaxYValue();

      int t = 0;

      while (t < series.Count)
      {
        if (InsideBounds(series, t, x0, x1, y0, y1))
          t++;
        else
          series.Delete(t);
      }
    }

    private bool InsideBounds(Series series, int t, double x0, double x1, double y0, double y1)
    {
      if (series is Map)
      {
        double pX0 = ((Map)series).Shapes[t].Points.MinXValue();
        double pX1 = ((Map)series).Shapes[t].Points.MaxXValue();
        double pY0 = ((Map)series).Shapes[t].Points.MinYValue();
        double pY1 = ((Map)series).Shapes[t].Points.MaxYValue();

        return (pX0 >= x0) && (pX1 <= x1) && (pY0 >= y0) && (pY1 <= y1);

      }
      else
      {
        double x = series.XValues[t];
        double y = series.YValues[t];

        return (x >= x0) && (x <= x1) && (y >= y0) && (y <= y1);

      }
    }

    private void InitializeChart()
    {
      tabControl3.TabPages[0].Controls.Add(tChart1);
      tabControl3.TabPages[1].Controls.Add(tChart2);
      tabControl3.SelectedIndexChanged += TabControl3_SelectedIndexChanged;

      this.tChart2.Scroll += new System.EventHandler(this.tChart1_Scroll);
      this.tChart2.Zoomed += new System.EventHandler(this.tChart1_Zoomed);
      this.tChart2.UndoneZoom += new System.EventHandler(this.tChart1_UndoneZoom);
      this.tChart2.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
      this.tChart2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseDown);
      this.tChart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
      this.tChart2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseUp);
      this.tChart2.Resize += new System.EventHandler(this.tChart1_Resize);

      this.map1 = new Steema.TeeChart.Styles.Map();
      this.tChart1.Series.Add(this.map1);
      this.map1.AfterDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.map1_AfterDrawValues);
      this.points1 = new Steema.TeeChart.Styles.Points();
      this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
      this.tChart1.Series.Add(this.points1);
      this.textSource1.Series = points1;

      tChart2.Legend.Visible = false;
      tChart2.Axes.Visible = false;
      tChart2.Walls.Visible = false;

      tChart2.Panel.Gradient.Visible = false;
      tChart2.Panel.Color = Color.White;
      tChart2.Aspect.View3D = false;
      tChart2.Header.Text = "USA";

      tChart2.Tools.Add(typeof(Steema.TeeChart.Tools.MarksTip));

      tChart2.Series.Add(USA);
      USA.Map = WorldMapType.USA;
      USA.Color = Color.White;
      USA.FillSampleValues();

      tChart2.Series.Add(Route66);
      KMLSource.Load(Route66, Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\Maps\\Route66.kml"));
      Route66.Pointer.Visible = true;
      Route66.Pointer.HorizSize = 3;
      Route66.Pointer.VertSize = 3;
      Route66.Pointer.Style = PointerStyles.Circle;
      Route66.Pointer.Pen.Color = Color.FromArgb(128, Color.Red);
      Route66.Pointer.Color = Color.LawnGreen;

      tChart2.Series.Add(NuclearPlants);
      NuclearPlants.Pointer.HorizSize = 4;
      NuclearPlants.Pointer.VertSize = 4;
      NuclearPlants.Color = Color.Cyan;
      KMLSource.Load(NuclearPlants, Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\Maps\\WorldPowerPlants.kml"));

      HidePointsOutsideUSA(NuclearPlants);

      tChart2.Series.Add(Cities);

      string[] usaCities = File.ReadAllLines(Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\Maps\\USACities.txt"));
      World.AddPlacemarks(usaCities, Cities);

      Cities.Pointer.HorizSize = 2;
      Cities.Pointer.VertSize = 2;
      Cities.Pointer.Pen.Visible = false;

      HidePointsOutsideUSA(Cities);

      tChart2.Series.Add(Populated);

      SHP shape = new SHP();

      string filePath = Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\Maps\\ne_50m_urban_areas.shp"); //call to Path.Combine that was here only took one string, i.e. was not
                                                                                                                                        //combining with anything.

      Populated.UseColorRange = false;
      Populated.UsePalette = true;
      Populated.PaletteStyle = PaletteStyles.Rainbow;

      HidePointsOutsideUSA(Populated);

      foreach (Control control in this.splitter3.Panel2.Controls)
      {
        control.Enabled = false;
        control.ForeColor = Color.FromArgb(100, control.ForeColor);
      }
    }

    private void TabControl3_SelectedIndexChanged(object sender, EventArgs e)
    {
      bool flag = !Convert.ToBoolean(tabControl3.SelectedIndex);
      this.tabControl1.Enabled = flag;
      foreach (TabPage page in this.tabControl1.TabPages)
      {
        foreach (Control control in page.Controls)
        {
          control.ForeColor = Color.FromArgb(flag ? 255 : 100, control.ForeColor);
        }
      }
      foreach (Control control in this.splitter3.Panel1.Controls)
      {
        control.Enabled = flag;
        control.ForeColor = Color.FromArgb(flag ? 255 : 100, control.ForeColor);
      }

      foreach (Control control in this.splitter3.Panel2.Controls)
      {
        control.Enabled = !flag;
        control.ForeColor = Color.FromArgb(!flag ? 255 : 100, control.ForeColor);
      }
    }


    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeeSHPForm));
			this.commander1 = new Steema.TeeChart.Commander();
			this.splitter1 = new System.Windows.Forms.SplitContainer();
			this.splitter3 = new System.Windows.Forms.SplitContainer();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.cBClipOutline = new System.Windows.Forms.CheckBox();
			this.cBOutline = new System.Windows.Forms.CheckBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.cBOutlineColor = new System.Windows.Forms.CheckBox();
			this.cbDebug = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.cbUSAColors = new System.Windows.Forms.CheckBox();
			this.cbPopulated = new System.Windows.Forms.CheckBox();
			this.cbNuclear = new System.Windows.Forms.CheckBox();
			this.cbRoute66 = new System.Windows.Forms.CheckBox();
			this.splitter2 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.chartListBox1 = new Steema.TeeChart.ChartListBox(this.components);
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lBCities = new System.Windows.Forms.ListBox();
			this.tPDebug = new System.Windows.Forms.TabPage();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tChart1 = new Steema.TeeChart.TChart();
			this.colorLine1 = new Steema.TeeChart.Tools.ColorLine();
			this.colorLine2 = new Steema.TeeChart.Tools.ColorLine();
			this.colorLine3 = new Steema.TeeChart.Tools.ColorLine();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.annotation1 = new Steema.TeeChart.Tools.Annotation();
			this.annotation2 = new Steema.TeeChart.Tools.Annotation();
			this.tChart2 = new Steema.TeeChart.TChart();
			this.textSource1 = new Steema.TeeChart.Data.TextSource();
			this.splitter1.Panel1.SuspendLayout();
			this.splitter1.Panel2.SuspendLayout();
			this.splitter1.SuspendLayout();
			this.splitter3.Panel1.SuspendLayout();
			this.splitter3.Panel2.SuspendLayout();
			this.splitter3.SuspendLayout();
			this.splitter2.Panel1.SuspendLayout();
			this.splitter2.Panel2.SuspendLayout();
			this.splitter2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tPDebug.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.SuspendLayout();
			// 
			// commander1
			// 
			this.commander1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.commander1.DropDownArrows = true;
			this.commander1.LabelValues = true;
			this.commander1.Location = new System.Drawing.Point(0, 0);
			this.commander1.Name = "commander1";
			this.commander1.ShowToolTips = true;
			this.commander1.Size = new System.Drawing.Size(1115, 37);
			this.commander1.TabIndex = 25;
			this.commander1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.commander1_ButtonClick);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitter1.Location = new System.Drawing.Point(0, 37);
			this.splitter1.Name = "splitter1";
			this.splitter1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitter1.Panel1
			// 
			this.splitter1.Panel1.Controls.Add(this.splitter3);
			// 
			// splitter1.Panel2
			// 
			this.splitter1.Panel2.Controls.Add(this.splitter2);
			this.splitter1.Size = new System.Drawing.Size(1115, 632);
			this.splitter1.SplitterDistance = 97;
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// splitter3
			// 
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitter3.Location = new System.Drawing.Point(0, 0);
			this.splitter3.Name = "splitter3";
			// 
			// splitter3.Panel1
			// 
			this.splitter3.Panel1.Controls.Add(this.label2);
			this.splitter3.Panel1.Controls.Add(this.label1);
			this.splitter3.Panel1.Controls.Add(this.textBox2);
			this.splitter3.Panel1.Controls.Add(this.textBox1);
			this.splitter3.Panel1.Controls.Add(this.checkBox2);
			this.splitter3.Panel1.Controls.Add(this.cBClipOutline);
			this.splitter3.Panel1.Controls.Add(this.cBOutline);
			this.splitter3.Panel1.Controls.Add(this.statusBar1);
			this.splitter3.Panel1.Controls.Add(this.cBOutlineColor);
			this.splitter3.Panel1.Controls.Add(this.cbDebug);
			this.splitter3.Panel1.Controls.Add(this.checkBox1);
			this.splitter3.Panel1.Controls.Add(this.comboBox1);
			this.splitter3.Panel1.Controls.Add(this.button1);
			// 
			// splitter3.Panel2
			// 
			this.splitter3.Panel2.Controls.Add(this.button2);
			this.splitter3.Panel2.Controls.Add(this.cbUSAColors);
			this.splitter3.Panel2.Controls.Add(this.cbPopulated);
			this.splitter3.Panel2.Controls.Add(this.cbNuclear);
			this.splitter3.Panel2.Controls.Add(this.cbRoute66);
			this.splitter3.Size = new System.Drawing.Size(1115, 97);
			this.splitter3.SplitterDistance = 694;
			this.splitter3.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(460, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 30;
			this.label2.Text = "Value Field:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(268, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 29;
			this.label1.Text = "Text Field:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(532, 6);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 28;
			this.textBox2.Text = "POP_CNTRY";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(332, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 27;
			this.textBox1.Text = "CNTRY_NAME";
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(619, 45);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(84, 24);
			this.checkBox2.TabIndex = 23;
			this.checkBox2.Text = "Cities";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// cBClipOutline
			// 
			this.cBClipOutline.Checked = true;
			this.cBClipOutline.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cBClipOutline.Location = new System.Drawing.Point(532, 45);
			this.cBClipOutline.Name = "cBClipOutline";
			this.cBClipOutline.Size = new System.Drawing.Size(84, 24);
			this.cBClipOutline.TabIndex = 16;
			this.cBClipOutline.Text = " Clip outline";
			// 
			// cBOutline
			// 
			this.cBOutline.Checked = true;
			this.cBOutline.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cBOutline.Location = new System.Drawing.Point(407, 45);
			this.cBOutline.Name = "cBOutline";
			this.cBOutline.Size = new System.Drawing.Size(65, 24);
			this.cBOutline.TabIndex = 14;
			this.cBOutline.Text = "Outline";
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 75);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(694, 22);
			this.statusBar1.TabIndex = 19;
			this.statusBar1.Text = "statusBar1";
			// 
			// cBOutlineColor
			// 
			this.cBOutlineColor.Location = new System.Drawing.Point(473, 45);
			this.cBOutlineColor.Name = "cBOutlineColor";
			this.cBOutlineColor.Size = new System.Drawing.Size(73, 24);
			this.cBOutlineColor.TabIndex = 15;
			this.cBOutlineColor.Text = "Color";
			// 
			// cbDebug
			// 
			this.cbDebug.Location = new System.Drawing.Point(337, 45);
			this.cbDebug.Name = "cbDebug";
			this.cbDebug.Size = new System.Drawing.Size(104, 24);
			this.cbDebug.TabIndex = 8;
			this.cbDebug.Text = "Debug";
			this.cbDebug.Click += new System.EventHandler(this.cbDebug_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(217, 45);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(119, 24);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Use Access Table";
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            ""});
			this.comboBox1.Location = new System.Drawing.Point(88, 45);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(7, 44);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "&Load";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(298, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "R&eset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button4_Click);
			// 
			// cbUSAColors
			// 
			this.cbUSAColors.AutoSize = true;
			this.cbUSAColors.Checked = true;
			this.cbUSAColors.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbUSAColors.Location = new System.Drawing.Point(298, 47);
			this.cbUSAColors.Name = "cbUSAColors";
			this.cbUSAColors.Size = new System.Drawing.Size(80, 17);
			this.cbUSAColors.TabIndex = 9;
			this.cbUSAColors.Text = "USA Colors";
			this.cbUSAColors.UseVisualStyleBackColor = true;
			this.cbUSAColors.CheckedChanged += new System.EventHandler(this.cbUSAColors_CheckedChanged);
			// 
			// cbPopulated
			// 
			this.cbPopulated.AutoSize = true;
			this.cbPopulated.Checked = true;
			this.cbPopulated.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbPopulated.Location = new System.Drawing.Point(188, 47);
			this.cbPopulated.Name = "cbPopulated";
			this.cbPopulated.Size = new System.Drawing.Size(104, 17);
			this.cbPopulated.TabIndex = 8;
			this.cbPopulated.Text = "Populated Areas";
			this.cbPopulated.UseVisualStyleBackColor = true;
			this.cbPopulated.CheckedChanged += new System.EventHandler(this.cbPopulated_CheckedChanged);
			// 
			// cbNuclear
			// 
			this.cbNuclear.AutoSize = true;
			this.cbNuclear.Checked = true;
			this.cbNuclear.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbNuclear.Location = new System.Drawing.Point(87, 47);
			this.cbNuclear.Name = "cbNuclear";
			this.cbNuclear.Size = new System.Drawing.Size(95, 17);
			this.cbNuclear.TabIndex = 7;
			this.cbNuclear.Text = "Nuclear Plants";
			this.cbNuclear.UseVisualStyleBackColor = true;
			this.cbNuclear.CheckedChanged += new System.EventHandler(this.cbNuclear_CheckedChanged);
			// 
			// cbRoute66
			// 
			this.cbRoute66.AutoSize = true;
			this.cbRoute66.Checked = true;
			this.cbRoute66.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRoute66.Location = new System.Drawing.Point(11, 47);
			this.cbRoute66.Name = "cbRoute66";
			this.cbRoute66.Size = new System.Drawing.Size(70, 17);
			this.cbRoute66.TabIndex = 6;
			this.cbRoute66.Text = "Route 66";
			this.cbRoute66.UseVisualStyleBackColor = true;
			this.cbRoute66.CheckedChanged += new System.EventHandler(this.cbRoute66_CheckedChanged);
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitter2.Location = new System.Drawing.Point(0, 0);
			this.splitter2.Name = "splitter2";
			// 
			// splitter2.Panel1
			// 
			this.splitter2.Panel1.Controls.Add(this.tabControl1);
			// 
			// splitter2.Panel2
			// 
			this.splitter2.Panel2.Controls.Add(this.tabControl3);
			this.splitter2.Size = new System.Drawing.Size(1115, 531);
			this.splitter2.SplitterDistance = 153;
			this.splitter2.TabIndex = 21;
			this.splitter2.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tPDebug);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(153, 531);
			this.tabControl1.TabIndex = 20;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.chartListBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(145, 505);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Map";
			// 
			// chartListBox1
			// 
			this.chartListBox1.AllowDrop = true;
			this.chartListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartListBox1.Location = new System.Drawing.Point(0, 0);
			this.chartListBox1.Name = "chartListBox1";
			this.chartListBox1.OtherItems = null;
			this.chartListBox1.Size = new System.Drawing.Size(145, 505);
			this.chartListBox1.TabIndex = 0;
			this.chartListBox1.ChangeColor += new Steema.TeeChart.ChangeColorEventHandler(this.chartListBox1_ChangeColor);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lBCities);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(145, 505);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Cities";
			// 
			// lBCities
			// 
			this.lBCities.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lBCities.Location = new System.Drawing.Point(0, 0);
			this.lBCities.Name = "lBCities";
			this.lBCities.Size = new System.Drawing.Size(145, 505);
			this.lBCities.TabIndex = 0;
			this.lBCities.SelectedIndexChanged += new System.EventHandler(this.lBCities_SelectedIndexChanged);
			// 
			// tPDebug
			// 
			this.tPDebug.Controls.Add(this.listBox1);
			this.tPDebug.Location = new System.Drawing.Point(4, 22);
			this.tPDebug.Name = "tPDebug";
			this.tPDebug.Size = new System.Drawing.Size(145, 505);
			this.tPDebug.TabIndex = 2;
			this.tPDebug.Text = "Debug";
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(145, 505);
			this.listBox1.TabIndex = 0;
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.Add(this.tabPage3);
			this.tabControl3.Controls.Add(this.tabPage4);
			this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl3.Location = new System.Drawing.Point(0, 0);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(958, 531);
			this.tabControl3.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(950, 505);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "World Map";
			this.tabPage3.Visible = false;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(950, 505);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "KML Import";
			this.tabPage4.Visible = false;
			// 
			// tChart1
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
			this.tChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Axes.Bottom.Labels.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
			this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Angle = 0;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Axes.Bottom.Title.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Bottom.Title.Font.Size = 11;
			this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Axes.Depth.Labels.Brush.Solid = true;
			this.tChart1.Axes.Depth.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
			this.tChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Depth.Labels.Font.Size = 9;
			this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Angle = 0;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Axes.Depth.Title.Brush.Solid = true;
			this.tChart1.Axes.Depth.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Depth.Title.Font.Brush.Solid = true;
			this.tChart1.Axes.Depth.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Depth.Title.Font.Size = 11;
			this.tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Axes.DepthTop.Labels.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.DepthTop.Labels.Font.Size = 9;
			this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Angle = 0;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Axes.DepthTop.Title.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.DepthTop.Title.Font.Size = 11;
			this.tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
			this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Axes.Left.Labels.Brush.Solid = true;
			this.tChart1.Axes.Left.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Axes.Left.Labels.Font.Brush.Solid = true;
			this.tChart1.Axes.Left.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Left.Labels.Font.Size = 9;
			this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Angle = 90;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Axes.Left.Title.Brush.Solid = true;
			this.tChart1.Axes.Left.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Left.Title.Font.Brush.Solid = true;
			this.tChart1.Axes.Left.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Left.Title.Font.Size = 11;
			this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Axes.Right.Labels.Brush.Solid = true;
			this.tChart1.Axes.Right.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Axes.Right.Labels.Font.Brush.Solid = true;
			this.tChart1.Axes.Right.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Right.Labels.Font.Size = 9;
			this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Angle = 270;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Axes.Right.Title.Brush.Solid = true;
			this.tChart1.Axes.Right.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Right.Title.Font.Brush.Solid = true;
			this.tChart1.Axes.Right.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Right.Title.Font.Size = 11;
			this.tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Axes.Top.Labels.Brush.Solid = true;
			this.tChart1.Axes.Top.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Axes.Top.Labels.Font.Brush.Solid = true;
			this.tChart1.Axes.Top.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Top.Labels.Font.Size = 9;
			this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Angle = 0;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Axes.Top.Title.Brush.Solid = true;
			this.tChart1.Axes.Top.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Top.Title.Font.Brush.Solid = true;
			this.tChart1.Axes.Top.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
			this.tChart1.Axes.Top.Title.Font.Size = 11;
			this.tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
			this.tChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
			this.tChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
			this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Footer.Brush.Solid = true;
			this.tChart1.Footer.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Footer.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
			this.tChart1.Footer.Font.Brush.Solid = true;
			this.tChart1.Footer.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Footer.Font.Shadow.Brush.Solid = true;
			this.tChart1.Footer.Font.Shadow.Brush.Visible = true;
			this.tChart1.Footer.Font.Size = 8;
			this.tChart1.Footer.Font.SizeFloat = 8F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Footer.ImageBevel.Brush.Solid = true;
			this.tChart1.Footer.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Footer.Shadow.Brush.Solid = true;
			this.tChart1.Footer.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.Header.Brush.Solid = true;
			this.tChart1.Header.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Header.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Header.Font.Brush.Solid = true;
			this.tChart1.Header.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Header.Font.Shadow.Brush.Solid = true;
			this.tChart1.Header.Font.Shadow.Brush.Visible = true;
			this.tChart1.Header.Font.Size = 12;
			this.tChart1.Header.Font.SizeFloat = 12F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Header.ImageBevel.Brush.Solid = true;
			this.tChart1.Header.ImageBevel.Brush.Visible = true;
			this.tChart1.Header.Lines = new string[] {
        "Maps courtesy of www.nationalatlas.gov"};
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.tChart1.Header.Shadow.Brush.Solid = true;
			this.tChart1.Header.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Legend.Brush.Solid = true;
			this.tChart1.Legend.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Legend.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Legend.Font.Brush.Solid = true;
			this.tChart1.Legend.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Legend.Font.Shadow.Brush.Solid = true;
			this.tChart1.Legend.Font.Shadow.Brush.Visible = true;
			this.tChart1.Legend.Font.Size = 9;
			this.tChart1.Legend.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Legend.ImageBevel.Brush.Solid = true;
			this.tChart1.Legend.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Legend.Shadow.Brush.Solid = true;
			this.tChart1.Legend.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Legend.Symbol.Shadow.Brush.Solid = true;
			this.tChart1.Legend.Symbol.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Legend.Title.Brush.Solid = true;
			this.tChart1.Legend.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.Legend.Title.Font.Bold = true;
			// 
			// 
			// 
			this.tChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Legend.Title.Font.Brush.Solid = true;
			this.tChart1.Legend.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
			this.tChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
			this.tChart1.Legend.Title.Font.Size = 8;
			this.tChart1.Legend.Title.Font.SizeFloat = 8F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Legend.Title.ImageBevel.Brush.Solid = true;
			this.tChart1.Legend.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Legend.Title.Shadow.Brush.Solid = true;
			this.tChart1.Legend.Title.Shadow.Brush.Visible = true;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(150, 72);
			this.tChart1.Name = "tChart1";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Panel.Brush.Solid = true;
			this.tChart1.Panel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Panel.ImageBevel.Brush.Solid = true;
			this.tChart1.Panel.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Panel.Shadow.Brush.Solid = true;
			this.tChart1.Panel.Shadow.Brush.Visible = true;
			this.tChart1.Size = new System.Drawing.Size(722, 575);
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.SubFooter.Brush.Solid = true;
			this.tChart1.SubFooter.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.SubFooter.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
			this.tChart1.SubFooter.Font.Brush.Solid = true;
			this.tChart1.SubFooter.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.SubFooter.Font.Shadow.Brush.Solid = true;
			this.tChart1.SubFooter.Font.Shadow.Brush.Visible = true;
			this.tChart1.SubFooter.Font.Size = 8;
			this.tChart1.SubFooter.Font.SizeFloat = 8F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.SubFooter.ImageBevel.Brush.Solid = true;
			this.tChart1.SubFooter.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.SubFooter.Shadow.Brush.Solid = true;
			this.tChart1.SubFooter.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.SubHeader.Brush.Solid = true;
			this.tChart1.SubHeader.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart1.SubHeader.Font.Bold = false;
			// 
			// 
			// 
			this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.SubHeader.Font.Brush.Solid = true;
			this.tChart1.SubHeader.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.SubHeader.Font.Shadow.Brush.Solid = true;
			this.tChart1.SubHeader.Font.Shadow.Brush.Visible = true;
			this.tChart1.SubHeader.Font.Size = 12;
			this.tChart1.SubHeader.Font.SizeFloat = 12F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.SubHeader.ImageBevel.Brush.Solid = true;
			this.tChart1.SubHeader.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.tChart1.SubHeader.Shadow.Brush.Solid = true;
			this.tChart1.SubHeader.Shadow.Brush.Visible = true;
			this.tChart1.TabIndex = 26;
			this.tChart1.Tools.Add(this.colorLine1);
			this.tChart1.Tools.Add(this.colorLine2);
			this.tChart1.Tools.Add(this.colorLine3);
			this.tChart1.Tools.Add(this.gridBand1);
			this.tChart1.Tools.Add(this.annotation1);
			this.tChart1.Tools.Add(this.annotation2);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Walls.Back.Brush.Solid = true;
			this.tChart1.Walls.Back.Brush.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Walls.Back.ImageBevel.Brush.Solid = true;
			this.tChart1.Walls.Back.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Walls.Back.Shadow.Brush.Solid = true;
			this.tChart1.Walls.Back.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Walls.Bottom.Brush.Solid = true;
			this.tChart1.Walls.Bottom.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
			this.tChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Walls.Bottom.Shadow.Brush.Solid = true;
			this.tChart1.Walls.Bottom.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
			this.tChart1.Walls.Left.Brush.Solid = true;
			this.tChart1.Walls.Left.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Walls.Left.ImageBevel.Brush.Solid = true;
			this.tChart1.Walls.Left.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Walls.Left.Shadow.Brush.Solid = true;
			this.tChart1.Walls.Left.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
			this.tChart1.Walls.Right.Brush.Solid = true;
			this.tChart1.Walls.Right.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart1.Walls.Right.ImageBevel.Brush.Solid = true;
			this.tChart1.Walls.Right.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Walls.Right.Shadow.Brush.Solid = true;
			this.tChart1.Walls.Right.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
			this.tChart1.Zoom.Brush.Solid = true;
			this.tChart1.Zoom.Brush.Visible = true;
			this.tChart1.Scroll += new System.EventHandler(this.tChart1_Scroll);
			this.tChart1.Zoomed += new System.EventHandler(this.tChart1_Zoomed);
			this.tChart1.UndoneZoom += new System.EventHandler(this.tChart1_UndoneZoom);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			this.tChart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseDown);
			this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
			this.tChart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseUp);
			this.tChart1.Resize += new System.EventHandler(this.tChart1_Resize);
			// 
			// colorLine1
			// 
			this.colorLine1.AllowDrag = false;
			this.colorLine1.Axis = this.tChart1.Axes.Left;
			// 
			// colorLine2
			// 
			this.colorLine2.AllowDrag = false;
			this.colorLine2.Axis = this.tChart1.Axes.Left;
			// 
			// colorLine3
			// 
			this.colorLine3.AllowDrag = false;
			this.colorLine3.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Bottom;
			// 
			// 
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
			this.gridBand1.Band1.Solid = true;
			this.gridBand1.Band1.Visible = true;
			// 
			// 
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.gridBand1.Band2.Solid = true;
			this.gridBand1.Band2.Visible = true;
			// 
			// annotation1
			// 
			this.annotation1.AutoSize = true;
			// 
			// 
			// 
			this.annotation1.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.annotation1.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
			this.annotation1.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.annotation1.Callout.Brush.Color = System.Drawing.Color.Black;
			this.annotation1.Callout.Brush.Solid = true;
			this.annotation1.Callout.Brush.Visible = true;
			this.annotation1.Callout.Distance = 0;
			this.annotation1.Callout.SizeDouble = 0D;
			this.annotation1.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
			this.annotation1.Callout.XPosition = 0;
			this.annotation1.Callout.YPosition = 0;
			this.annotation1.Callout.ZPosition = 0;
			this.annotation1.Cursor = System.Windows.Forms.Cursors.Default;
			this.annotation1.Left = 6;
			// 
			// 
			// 
			// 
			// 
			// 
			this.annotation1.Shape.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			this.annotation1.Shape.Bottom = 27;
			// 
			// 
			// 
			this.annotation1.Shape.Brush.Color = System.Drawing.Color.White;
			this.annotation1.Shape.Brush.Solid = true;
			this.annotation1.Shape.Brush.Visible = true;
			this.annotation1.Shape.CustomPosition = true;
			// 
			// 
			// 
			this.annotation1.Shape.Font.Bold = false;
			// 
			// 
			// 
			this.annotation1.Shape.Font.Brush.Color = System.Drawing.Color.Black;
			this.annotation1.Shape.Font.Brush.Solid = true;
			this.annotation1.Shape.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.annotation1.Shape.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.annotation1.Shape.Font.Shadow.Brush.Solid = true;
			this.annotation1.Shape.Font.Shadow.Brush.Visible = true;
			this.annotation1.Shape.Font.Size = 8;
			this.annotation1.Shape.Font.SizeFloat = 8F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.annotation1.Shape.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.annotation1.Shape.ImageBevel.Brush.Solid = true;
			this.annotation1.Shape.ImageBevel.Brush.Visible = true;
			this.annotation1.Shape.Left = 6;
			this.annotation1.Shape.Right = 19;
			// 
			// 
			// 
			// 
			// 
			// 
			this.annotation1.Shape.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.annotation1.Shape.Shadow.Brush.Solid = true;
			this.annotation1.Shape.Shadow.Brush.Visible = true;
			this.annotation1.Shape.Top = 8;
			this.annotation1.Top = 8;
			// 
			// annotation2
			// 
			this.annotation2.AutoSize = false;
			// 
			// 
			// 
			this.annotation2.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.annotation2.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
			this.annotation2.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.annotation2.Callout.Brush.Color = System.Drawing.Color.Black;
			this.annotation2.Callout.Brush.Solid = true;
			this.annotation2.Callout.Brush.Visible = true;
			this.annotation2.Callout.Distance = 0;
			this.annotation2.Callout.SizeDouble = 0D;
			this.annotation2.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
			this.annotation2.Callout.XPosition = 0;
			this.annotation2.Callout.YPosition = 0;
			this.annotation2.Callout.ZPosition = 0;
			this.annotation2.Cursor = System.Windows.Forms.Cursors.Default;
			this.annotation2.Height = 17;
			this.annotation2.Left = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.annotation2.Shape.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.annotation2.Shape.Brush.Color = System.Drawing.Color.White;
			this.annotation2.Shape.Brush.Solid = true;
			this.annotation2.Shape.Brush.Visible = true;
			// 
			// 
			// 
			this.annotation2.Shape.Font.Bold = false;
			// 
			// 
			// 
			this.annotation2.Shape.Font.Brush.Color = System.Drawing.Color.Black;
			this.annotation2.Shape.Font.Brush.Solid = true;
			this.annotation2.Shape.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.annotation2.Shape.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.annotation2.Shape.Font.Shadow.Brush.Solid = true;
			this.annotation2.Shape.Font.Shadow.Brush.Visible = true;
			this.annotation2.Shape.Font.Size = 8;
			this.annotation2.Shape.Font.SizeFloat = 8F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.annotation2.Shape.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.annotation2.Shape.ImageBevel.Brush.Solid = true;
			this.annotation2.Shape.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.annotation2.Shape.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.annotation2.Shape.Shadow.Brush.Solid = true;
			this.annotation2.Shape.Shadow.Brush.Visible = true;
			this.annotation2.Width = 9;
			// 
			// tChart2
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
			this.tChart2.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Axes.Bottom.Labels.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Bottom.Labels.Font.Size = 9;
			this.tChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Title.Angle = 0;
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.Axes.Bottom.Title.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Bottom.Title.Font.Size = 11;
			this.tChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Axes.Depth.Labels.Brush.Solid = true;
			this.tChart2.Axes.Depth.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
			this.tChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Depth.Labels.Font.Size = 9;
			this.tChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Title.Angle = 0;
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.Axes.Depth.Title.Brush.Solid = true;
			this.tChart2.Axes.Depth.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart2.Axes.Depth.Title.Font.Brush.Solid = true;
			this.tChart2.Axes.Depth.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Depth.Title.Font.Size = 11;
			this.tChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Axes.DepthTop.Labels.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.DepthTop.Labels.Font.Size = 9;
			this.tChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Title.Angle = 0;
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.Axes.DepthTop.Title.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.DepthTop.Title.Font.Size = 11;
			this.tChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
			this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Axes.Left.Labels.Brush.Solid = true;
			this.tChart2.Axes.Left.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Left.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart2.Axes.Left.Labels.Font.Brush.Solid = true;
			this.tChart2.Axes.Left.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Left.Labels.Font.Size = 9;
			this.tChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Left.Title.Angle = 90;
			// 
			// 
			// 
			this.tChart2.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.Axes.Left.Title.Brush.Solid = true;
			this.tChart2.Axes.Left.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Left.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart2.Axes.Left.Title.Font.Brush.Solid = true;
			this.tChart2.Axes.Left.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Left.Title.Font.Size = 11;
			this.tChart2.Axes.Left.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Axes.Right.Labels.Brush.Solid = true;
			this.tChart2.Axes.Right.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Right.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart2.Axes.Right.Labels.Font.Brush.Solid = true;
			this.tChart2.Axes.Right.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Right.Labels.Font.Size = 9;
			this.tChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Right.Title.Angle = 270;
			// 
			// 
			// 
			this.tChart2.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.Axes.Right.Title.Brush.Solid = true;
			this.tChart2.Axes.Right.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Right.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart2.Axes.Right.Title.Font.Brush.Solid = true;
			this.tChart2.Axes.Right.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Right.Title.Font.Size = 11;
			this.tChart2.Axes.Right.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Axes.Top.Labels.Brush.Solid = true;
			this.tChart2.Axes.Top.Labels.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Top.Labels.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart2.Axes.Top.Labels.Font.Brush.Solid = true;
			this.tChart2.Axes.Top.Labels.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Top.Labels.Font.Size = 9;
			this.tChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Top.Title.Angle = 0;
			// 
			// 
			// 
			this.tChart2.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.Axes.Top.Title.Brush.Solid = true;
			this.tChart2.Axes.Top.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Axes.Top.Title.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart2.Axes.Top.Title.Font.Brush.Solid = true;
			this.tChart2.Axes.Top.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
			this.tChart2.Axes.Top.Title.Font.Size = 11;
			this.tChart2.Axes.Top.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
			this.tChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
			this.tChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
			this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Footer.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.Footer.Brush.Solid = true;
			this.tChart2.Footer.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Footer.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Footer.Font.Brush.Color = System.Drawing.Color.Red;
			this.tChart2.Footer.Font.Brush.Solid = true;
			this.tChart2.Footer.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Footer.Font.Shadow.Brush.Solid = true;
			this.tChart2.Footer.Font.Shadow.Brush.Visible = true;
			this.tChart2.Footer.Font.Size = 8;
			this.tChart2.Footer.Font.SizeFloat = 8F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Footer.ImageBevel.Brush.Solid = true;
			this.tChart2.Footer.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Footer.Shadow.Brush.Solid = true;
			this.tChart2.Footer.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart2.Header.Brush.Solid = true;
			this.tChart2.Header.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Header.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart2.Header.Font.Brush.Solid = true;
			this.tChart2.Header.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Header.Font.Shadow.Brush.Solid = true;
			this.tChart2.Header.Font.Shadow.Brush.Visible = true;
			this.tChart2.Header.Font.Size = 12;
			this.tChart2.Header.Font.SizeFloat = 12F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Header.ImageBevel.Brush.Solid = true;
			this.tChart2.Header.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.tChart2.Header.Shadow.Brush.Solid = true;
			this.tChart2.Header.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Legend.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Legend.Brush.Solid = true;
			this.tChart2.Legend.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Legend.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart2.Legend.Font.Brush.Solid = true;
			this.tChart2.Legend.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Legend.Font.Shadow.Brush.Solid = true;
			this.tChart2.Legend.Font.Shadow.Brush.Visible = true;
			this.tChart2.Legend.Font.Size = 9;
			this.tChart2.Legend.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Legend.ImageBevel.Brush.Solid = true;
			this.tChart2.Legend.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart2.Legend.Shadow.Brush.Solid = true;
			this.tChart2.Legend.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Legend.Symbol.Shadow.Brush.Solid = true;
			this.tChart2.Legend.Symbol.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Legend.Title.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Legend.Title.Brush.Solid = true;
			this.tChart2.Legend.Title.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.Legend.Title.Font.Bold = true;
			// 
			// 
			// 
			this.tChart2.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart2.Legend.Title.Font.Brush.Solid = true;
			this.tChart2.Legend.Title.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
			this.tChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
			this.tChart2.Legend.Title.Font.Size = 8;
			this.tChart2.Legend.Title.Font.SizeFloat = 8F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Legend.Title.ImageBevel.Brush.Solid = true;
			this.tChart2.Legend.Title.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Legend.Title.Shadow.Brush.Solid = true;
			this.tChart2.Legend.Title.Shadow.Brush.Visible = true;
			this.tChart2.Location = new System.Drawing.Point(0, 0);
			this.tChart2.Name = "tChart2";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart2.Panel.Brush.Solid = true;
			this.tChart2.Panel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Panel.ImageBevel.Brush.Solid = true;
			this.tChart2.Panel.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Panel.Shadow.Brush.Solid = true;
			this.tChart2.Panel.Shadow.Brush.Visible = true;
			this.tChart2.Size = new System.Drawing.Size(600, 400);
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.SubFooter.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.SubFooter.Brush.Solid = true;
			this.tChart2.SubFooter.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.SubFooter.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
			this.tChart2.SubFooter.Font.Brush.Solid = true;
			this.tChart2.SubFooter.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.SubFooter.Font.Shadow.Brush.Solid = true;
			this.tChart2.SubFooter.Font.Shadow.Brush.Visible = true;
			this.tChart2.SubFooter.Font.Size = 8;
			this.tChart2.SubFooter.Font.SizeFloat = 8F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.SubFooter.ImageBevel.Brush.Solid = true;
			this.tChart2.SubFooter.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.SubFooter.Shadow.Brush.Solid = true;
			this.tChart2.SubFooter.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart2.SubHeader.Brush.Solid = true;
			this.tChart2.SubHeader.Brush.Visible = true;
			// 
			// 
			// 
			this.tChart2.SubHeader.Font.Bold = false;
			// 
			// 
			// 
			this.tChart2.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart2.SubHeader.Font.Brush.Solid = true;
			this.tChart2.SubHeader.Font.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.SubHeader.Font.Shadow.Brush.Solid = true;
			this.tChart2.SubHeader.Font.Shadow.Brush.Visible = true;
			this.tChart2.SubHeader.Font.Size = 12;
			this.tChart2.SubHeader.Font.SizeFloat = 12F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.SubHeader.ImageBevel.Brush.Solid = true;
			this.tChart2.SubHeader.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.tChart2.SubHeader.Shadow.Brush.Solid = true;
			this.tChart2.SubHeader.Shadow.Brush.Visible = true;
			this.tChart2.TabIndex = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
			this.tChart2.Walls.Back.Brush.Solid = true;
			this.tChart2.Walls.Back.Brush.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Walls.Back.ImageBevel.Brush.Solid = true;
			this.tChart2.Walls.Back.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Walls.Back.Shadow.Brush.Solid = true;
			this.tChart2.Walls.Back.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
			this.tChart2.Walls.Bottom.Brush.Solid = true;
			this.tChart2.Walls.Bottom.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
			this.tChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Walls.Bottom.Shadow.Brush.Solid = true;
			this.tChart2.Walls.Bottom.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
			this.tChart2.Walls.Left.Brush.Solid = true;
			this.tChart2.Walls.Left.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Walls.Left.ImageBevel.Brush.Solid = true;
			this.tChart2.Walls.Left.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Walls.Left.Shadow.Brush.Solid = true;
			this.tChart2.Walls.Left.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			this.tChart2.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
			this.tChart2.Walls.Right.Brush.Solid = true;
			this.tChart2.Walls.Right.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
			this.tChart2.Walls.Right.ImageBevel.Brush.Solid = true;
			this.tChart2.Walls.Right.ImageBevel.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart2.Walls.Right.Shadow.Brush.Solid = true;
			this.tChart2.Walls.Right.Shadow.Brush.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
			this.tChart2.Zoom.Brush.Solid = true;
			this.tChart2.Zoom.Brush.Visible = true;
			// 
			// textSource1
			// 
			this.textSource1.DecimalSeparator = ',';
			this.textSource1.Separator = ';';
			this.textSource1.Series = null;
			// 
			// TeeSHPForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1115, 669);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.commander1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TeeSHPForm";
			this.Text = "TeeChart for .NET v2018 TeeMaps Example";
			this.Load += new System.EventHandler(this.TeeSHPForm_Load);
			this.splitter1.Panel1.ResumeLayout(false);
			this.splitter1.Panel2.ResumeLayout(false);
			this.splitter1.ResumeLayout(false);
			this.splitter3.Panel1.ResumeLayout(false);
			this.splitter3.Panel1.PerformLayout();
			this.splitter3.Panel2.ResumeLayout(false);
			this.splitter3.Panel2.PerformLayout();
			this.splitter3.ResumeLayout(false);
			this.splitter2.Panel1.ResumeLayout(false);
			this.splitter2.Panel2.ResumeLayout(false);
			this.splitter2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tPDebug.ResumeLayout(false);
			this.tabControl3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

    }
    #endregion

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.Run(new TeeSHPForm());
    }

    private static short HORZSIZE = 4;     // Horizontal size in millimeters 
    private static short VERTSIZE = 6;     // Vertical size in millimeters 
    [DllImport("gdi32.dll")]
    private static extern Int32 GetDeviceCaps(IntPtr hdc, Int32 capindex);


    private void LoadCityList()
    {
      lBCities.Items.Clear();
      if (checkBox2.Checked)
      {
        lBCities.Sorted = false;
        for (int i = 0; i < points1.Count; ++i)
        {
          lBCities.Items.Add(points1.Labels[i]);
        }
        lBCities.Sorted = true;
      }
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      if (cbDebug.Checked)
      {
        if (checkBox1.Checked)
        {
          TryLoadTable();
          teeSHP.LoadMap(map1, this.comboBox1.Text, Table1, textBox1.Text, textBox2.Text, listBox1.Items, null);
        }
        else
          teeSHP.LoadMap(map1, this.comboBox1.Text, null, null, null, listBox1.Items, null);
      }
      else
      {
        if (checkBox1.Checked)
        {
          TryLoadTable();
          teeSHP.LoadMap(map1, this.comboBox1.Text, Table1, textBox1.Text, textBox2.Text, null, null);
        }
        else
          teeSHP.LoadMap(map1, this.comboBox1.Text);
      }

      if (comboBox1.SelectedIndex == 2)
      {
        tChart1.Axes.Left.SetMinMax(24, 50);
        tChart1.Axes.Bottom.SetMinMax(-125, -67);
        points1.Clear();
        textSource1.LoadFromFile(path + @"Maps/USACities.txt");
      }
      else
      {
        tChart1.Axes.Left.SetMinMax(-90, 90);
        tChart1.Axes.Bottom.SetMinMax(-180, 180);
        points1.Clear();
        textSource1.LoadFromFile(path + @"Maps/WorldCities.txt");
      }

      LoadCityList();
      ResetCitySize();

      map1.UseColorRange = rnd.Next(100) < 50;
      if (map1.UseColorRange)
      {
        Steema.TeeChart.Drawing.Gradient grad = new Steema.TeeChart.Drawing.Gradient();
        map1.StartColor = grad.StartColor;
        map1.MidColor = grad.MiddleColor;
        map1.EndColor = grad.EndColor;
      }
      else
      {
        map1.UsePalette = true;
        map1.PaletteStyle = (Steema.TeeChart.Styles.PaletteStyles)rnd.Next(0, 4);
      }

      chartListBox1.BeginUpdate();
      FillShapes();
      Cursor.Current = Cursors.Default;
      annotation2.Active = false;

    }


    private void FillShapes()
    {
      chartListBox1.Chart = tChart1;
      chartListBox1.ClearItems();
      string tmpS;
      for (int t = 0; t < map1.Shapes.Count; ++t)
      {
        tmpS = map1.Labels[t];
        if (tmpS == "") tmpS = t.ToString();
        map1.Shapes[t].Points.Title = tmpS;
        chartListBox1.Items.Add(map1.Shapes[t].Points);
      }
    }

    private void cbDebug_Click(object sender, System.EventArgs e)
    {
      tPDebug.Parent = cbDebug.Checked ? tabControl1 : tabControl2;
      tabControl1.SelectedTab = cbDebug.Checked ? tPDebug : tabControl1.SelectedTab;

    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      string s = "Shapes in Map: " + map1.Shapes.Count.ToString();
      Steema.TeeChart.Styles.Polygon polygon;
      int count = 0;
      for (int i = 0; i < map1.Shapes.Count; ++i)
      {
        polygon = map1.Shapes[i];
        count = count + polygon.Points.Count;
      }
      s = s + " Total points in Shapes: " + count.ToString();
      MessageBox.Show(s);
    }

    private void button3_Click(object sender, System.EventArgs e)
    {
      string[] ss = new string[listBox1.SelectedItems.Count];
      listBox1.SelectedItems.CopyTo(ss, 0);
      FileStream fs = File.Open(@"C:\Chris\listbox.txt", System.IO.FileMode.OpenOrCreate);
      StreamWriter sw = new StreamWriter(fs);
      foreach (string s in ss)
      {
        sw.WriteLine(s);
      }
      sw.Close();
      fs.Close();
    }

    private void map1_AfterDrawValues(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      chartListBox1.EndUpdate();
    }

    private void commander1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
    {
      chartListBox1.Invalidate();
    }

    private void cbRoute66_CheckedChanged(object sender, EventArgs e)
    {
      Route66.Visible = cbRoute66.Checked;
    }

    private void cbNuclear_CheckedChanged(object sender, EventArgs e)
    {
      NuclearPlants.Visible = cbNuclear.Checked;
    }


    private void cbPopulated_CheckedChanged(object sender, EventArgs e)
    {
      Populated.Visible = cbPopulated.Checked;
    }

    private void cbUSAColors_CheckedChanged(object sender, EventArgs e)
    {
      USA.UseColorRange = cbUSAColors.Checked;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      tChart2.Axes.Reset();
    }

    private void MakeIsometric(Axis vertical, Axis horizontal)
    {
      if ((vertical.Chart.Width > 0) && (vertical.Chart.Height > 0))
      {
        // setup values
        double xrange = horizontal.Maximum - horizontal.Minimum;
        double yrange = vertical.Maximum - vertical.Minimum;
        double tmpx = xrange / (double)vertical.Chart.Width;
        double tmpy = yrange / (double)vertical.Chart.Height;

        Screen screen = Screen.FromControl(this);
        Graphics g = Graphics.FromHwnd(this.Handle);
        IntPtr hptr = g.GetHdc();
        double xyscreen = GetDeviceCaps(hptr, HORZSIZE) * screen.Bounds.Height;
        xyscreen /= (double)GetDeviceCaps(hptr, VERTSIZE) * screen.Bounds.Width;
        g.ReleaseHdc(hptr);
        g.Dispose();

        tmpy *= xyscreen;
        double offset = 0.0;
        if (tmpx > tmpy)
        {
          if (tmpy != 0.0)
          {
            offset = 0.5 * (yrange * tmpx / tmpy - yrange);
            vertical.SetMinMax(vertical.Minimum - offset, vertical.Maximum + offset);
          }
        }
        else if (tmpx < tmpy)
        {
          if (tmpx != 0.0)
          {
            offset = 0.5 * (xrange * tmpy / tmpx - xrange);
            horizontal.SetMinMax(horizontal.Minimum - offset, horizontal.Maximum + offset);
          }
        }
      }
    }


    private void MakeIsometric(Steema.TeeChart.Styles.Series series)
    {
      MakeIsometric(series.GetVertAxis, series.GetHorizAxis);
    }


    private void tChart1_Zoomed(object sender, System.EventArgs e)
    {
      MakeIsometric(map1);

      if (tabControl1.SelectedIndex == 1) ResetCitySize();
      RefreshCityArrow();
    }

    private void TeeSHPForm_Load(object sender, System.EventArgs e)
    {
      path = Application.StartupPath;
      path = path + @"\..\..\";

      textSource1.Fields.Add(0, "text");
      textSource1.Fields.Add(1, "X");
      textSource1.Fields.Add(2, "Y");
      textSource1.DecimalSeparator = ',';


      if (File.Exists(path + @"Maps\World.shp"))
      {
        comboBox1.Items.Add(@"Maps\World");
        if (File.Exists(path + @"Maps\USAStates.shp"))
          comboBox1.Items.Add(@"Maps\USAStates");

        comboBox1.Text = @"Maps\World";
        button1_Click(sender, e);
      }

      tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
    }

    private void SetCustomBrush()
    {
      SelectedShape().ParentBrush = false;
      map1.Invalidate();
      chartListBox1.Refresh();
    }


    private Polygon SelectedShape()
    {
      Polygon result;
      if (chartListBox1.SelectedIndex >= 0)
        result = map1.Shapes[chartListBox1.SelectedIndex];
      else
        result = null;

      return result;
    }


    private void chartListBox1_ChangeColor(object sender, Steema.TeeChart.NotifySeriesEventArgs e)
    {
      SetCustomBrush();
    }

    private void OutlineShape(int Index)
    {
      if (Index != Old)
      {
        if (Old != -1) DrawShapeOutline(Old);
        Old = Index;
        if (Old != -1) DrawShapeOutline(Old);
      }
    }

    private void DrawShapeOutline(int Index)
    {
      Point[] P;
      if (cBOutline.Checked && map1[Index].Visible())
      {
        Steema.TeeChart.Drawing.Graphics3D g = tChart1.Graphics3D;
        g.Pen.Color = Color.Red;

        if (map1[Index].Pen.Visible)
        {
          g.Pen.Style = System.Drawing.Drawing2D.DashStyle.Solid;
          g.Pen.Width = map1[Index].Pen.Width;
        }
        else
          g.Pen.Width = 2;

        if (cBOutlineColor.Checked)
        {
          g.Brush.Visible = true;
          g.Brush.Color = Color.Yellow;
        }
        else
        {
          g.Brush.Visible = false;
          g.Pen.Width = 2;
        }

        map1.Invalidate();

        P = map1[Index].GetPoints();

        if (cBClipOutline.Checked)
          g.ClipRectangle(tChart1.Chart.ChartRect);

        if (tChart1.Aspect.View3D)
        {
          if (map1[Index].Closed) g.Polygon(map1.CalcZPos(Index), P);
          else g.Polyline(map1.CalcZPos(Index), P);
        }
        else
        {
          if (map1[Index].Closed) g.Polygon(P);
          else g.Polyline(P);
        }

        if (cBClipOutline.Checked)
          g.UnClip();
      }
    }

    private Points GetPoints()
    {
      return Convert.ToBoolean(tabControl3.SelectedIndex) ? Cities : points1;
    }

    private Map GetMap()
    {
      return Convert.ToBoolean(tabControl3.SelectedIndex) ? USA : map1;
    }

    private void tChart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
    {
      string cityName = "";
      int tmp = GetMap().Clicked(e.X, e.Y);

      if (!zoom) OutlineShape(tmp);

      double tmpX = GetMap().GetHorizAxis.CalcPosPoint(e.X);
      double tmpY = GetMap().GetVertAxis.CalcPosPoint(e.Y);

      int city = GetPoints().Clicked(e.X, e.Y);
      if (city != -1)
      {
        cityName = GetPoints().Labels[city];
        if (!zoom)
        {
          annotation1.Text = cityName;
          annotation1.Active = true;
          annotation1.Shape.Left = e.X;
          annotation1.Shape.Top = e.Y - 10;
        }
      }
      else
      {
        cityName = "";
        annotation1.Active = false;
      }

      statusBar1.Text = GetMap().GetVertAxis.Labels.LabelValue(tmpY) +
        " " + GetMap().GetHorizAxis.Labels.LabelValue(tmpX) +
        " " + cityName;

      if (tmp != -1)
      {
        statusBar1.Text = statusBar1.Text + " " + GetMap().Labels[tmp] +
          " " + GetMap().ZValues[tmp].ToString() +
          " ID: " + GetMap()[tmp].Index.ToString();
      }
    }

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      if (Old != -1 && !zoom)
        DrawShapeOutline(Old);
    }

    private void tChart1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left) zoom = true;
    }

    private void tChart1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left) zoom = false;
    }

    private void checkBox2_Click(object sender, System.EventArgs e)
    {
      points1.Visible = checkBox2.Checked;
      if (!checkBox2.Checked)
      {
        tabControl1.SelectedIndex = 0;
        lBCities.Items.Clear();
      }
      else
      {
        tabControl1.SelectedIndex = 1;
        LoadCityList();
      }
    }

    private int CurrentCity()
    {
      int result = 0;
      if (lBCities.SelectedItem != null)
      {
        result = points1.Labels.IndexOf(lBCities.SelectedItem.ToString());
      }
      return result;
    }

    private void lBCities_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      int tmp = CurrentCity();

      annotation2.AutoSize = true;
      annotation2.TextAlign = StringAlignment.Center;
      annotation2.Text = points1.Labels[tmp];
      annotation2.Callout.XPosition = points1.CalcXPos(tmp);
      annotation2.Callout.YPosition = points1.CalcYPos(tmp);
      annotation2.Callout.Arrow.Visible = true;
      annotation2.Active = true;
    }

    private void RefreshCityArrow()
    {
      if (annotation2.Active)
      {
        tChart1.Axes.Left.AdjustMaxMin();
        tChart1.Axes.Bottom.AdjustMaxMin();
        tChart1.Refresh();
        annotation2.Callout.XPosition = points1.CalcXPos(CurrentCity());
        annotation2.Callout.YPosition = points1.CalcYPos(CurrentCity());

      }
    }

    private void ResetCitySize()
    {
      tChart1.Axes.Bottom.AdjustMaxMin();
      points1.Pointer.HorizSize = Math.Max(3, tChart1.Axes.Bottom.CalcSizeValue(0.1));
      points1.Pointer.VertSize = points1.Pointer.HorizSize;

    }

    private void tChart1_Resize(object sender, System.EventArgs e)
    {
      if (tChart1.Series.Count > 0)
      {
        RefreshCityArrow();
        ResetCitySize();
      }
    }

    private void tChart1_Scroll(object sender, System.EventArgs e)
    {
      RefreshCityArrow();
    }

    private void tChart1_UndoneZoom(object sender, System.EventArgs e)
    {
      ResetCitySize();
      RefreshCityArrow();
    }

    [OleDbPermissionAttribute(SecurityAction.Demand, Provider = "Microsoft.Jet.OLEDB.4.0")]
    private void OpenConnWithJet40(ref DataSet MasterDataSet, string DataPath, string TableName)
    {
      OleDbConnection testConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
        @"Data Source=" + DataPath + ";");
      testConn.Open();
      string strCom = "SELECT * FROM " + TableName;
      OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, testConn);
      myCommand.Fill(MasterDataSet, TableName);
      testConn.Close();
    }

    private void TryLoadTable()
    {
      DataSet masterDataSet = new DataSet();
      string dataPath = path + @"Maps\Coordinates.mdb";
      string tableName = comboBox1.Text;
      tableName = tableName.Remove(0, 5);

      OpenConnWithJet40(ref masterDataSet, dataPath, tableName);

      Table1 = masterDataSet.Tables[tableName];

    }


    private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      if (tabControl1.SelectedIndex != 1) annotation2.Active = false;
    }

    private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      switch (comboBox1.SelectedIndex)
      {
        case 1:
          textBox1.Text = "CNTRY_NAME";
          textBox2.Text = "POP_CNTRY";
          colorLine1.Active = true;
          colorLine2.Active = true;
          colorLine3.Active = true;
          break;
        case 2:
          textBox1.Text = "STATE";
          textBox2.Text = "";
          colorLine1.Active = false;
          colorLine2.Active = false;
          colorLine3.Active = false;
          break;
      }
    }
  }
}
