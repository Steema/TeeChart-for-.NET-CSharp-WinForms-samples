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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mySqlDataAdapter1.Fill(this.dataSet11);
            this.dataGridView1.DataSource = dataSet11.Tables[0];

            tChart1[0].CheckDataSource();

        }
    }
}
