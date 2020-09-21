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
using System.Data.SqlClient;

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
            using (var connection = new SqlConnection("Persist Security Info=True;Initial Catalog=master;server=tcp:steema.net;UID=steema;PWD=girona2020")) 
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand($"SELECT * FROM flute_examples.world", connection))
                {
                    try
                    {
                        using (var adapter = new SqlDataAdapter(command))
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

            var teeSHP = new TeeSHP();

            var path = Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath) + "..\\..\\..\\Maps\\world.shp");

            teeSHP.LoadMap(map1, path, dataSet1.Tables[0], "CNTRY_NAME", "POP_CNTRY", null, null);

            dataGridView1.DataSource = dataSet1.Tables[0];

            tChart1[0].Marks.Visible = true;
        }
    }
}
