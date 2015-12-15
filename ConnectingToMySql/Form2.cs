using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// *** Project information. Please read for database connection details ***
/// 
/// The project uses a MySQL database with the following connection information:
/// 
///  database server=db154.pair.com
///  Dsn=world_map
///  uid=flute_16_r
///  pwd=P2TXnnjs
/// 
///  To run this project you should set up a Windows DSN to connect to the database (via ODBC).
/// </summary>

namespace ConnectingToMySql
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();

      TeeSHP teeSHP = new TeeSHP();
      odbcDataAdapter1.Fill(dataSet1);
      teeSHP.LoadMap(map1, Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath) + "..\\..\\..\\Maps\\world.shp"), dataSet1.Tables[0], "CNTRY_NAME", "POP_CNTRY", null, null);

      this.dataGridView1.DataSource = dataSet1.Tables[0];
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      tChart1[0].Marks.Visible = true;
    }
  }
}
