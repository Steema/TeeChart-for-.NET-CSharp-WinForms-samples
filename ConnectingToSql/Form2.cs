using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

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

namespace ConnectingToSql
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
      using (SqlConnection connection = new SqlConnection("Persist Security Info=True;Initial Catalog=master;server=qs4591.pair.com;UID=nook4_10_r;PWD=8wqALzLA"))
      {
        try
        {
          await connection.OpenAsync();
        }
        catch (Exception)
        {
          throw;
        }

        using (SqlCommand command = new SqlCommand($"SELECT * FROM nook4_examples.world", connection))
        {
          try
          {
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
              adapter.Fill(dataSet1);
            }
          }
          catch (Exception ee)
          {
            throw ee;
          }
        }
      }

      TeeSHP teeSHP = new TeeSHP();

      string path = Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath) + "..\\..\\..\\Maps\\world.shp");

      teeSHP.LoadMap(map1, path, dataSet1.Tables[0], "CNTRY_NAME", "POP_CNTRY", null, null);

      dataGridView1.DataSource = dataSet1.Tables[0];

      tChart1[0].Marks.Visible = true;
    }
  }
}
