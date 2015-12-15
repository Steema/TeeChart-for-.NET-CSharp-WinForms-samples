using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingToMySql
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      tChart1[0].CheckDataSource();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

      this.odbcDataAdapter1.Fill(this.dataSet11);
      this.dataGridView1.DataSource = dataSet11.Tables[0];
    }

    private void tChart1_Click(object sender, EventArgs e)
    {

    }

    private void chartController1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }
  }
}
