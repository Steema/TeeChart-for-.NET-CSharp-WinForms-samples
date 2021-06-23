using System;
using System.Windows.Forms;

namespace ConnectingToSql
{
  public partial class FormStart : Form
  {
    public FormStart()
    {
      InitializeComponent();

      LinkLabel.Link link = new LinkLabel.Link
      {
        LinkData = "https://www.steema.com/product/net"
      };
      linkLabel1.Links.Add(link);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Form2 form = new Form2();
      form.Show(this);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Form1 form = new Form1();
      form.Show(this);
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(e.Link.LinkData as string);
    }
  }
}
