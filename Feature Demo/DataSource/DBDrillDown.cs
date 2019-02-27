using Steema.TeeChart.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
* Special note.Access to the MS Access MDB demo is facilitated via the MS Jet 4.0 driver.Note that projects compiled
* as x64 or 'any cpu' should have the corresponding 64 bit Jet driver in place.Otherwise, please set your project to
* x84 in project options.
*/

namespace Steema.TeeChart.Samples
{
  public partial class DBDrillDown : Steema.TeeChart.Samples.BaseForm
  {
	public DBDrillDown()
	{
	  InitializeComponent();

	  // TODO: This line of code loads data into the 'techProductsLtdDataSet.___SalesByYearCountry' table. You can move, or remove it, as needed.
	  this.___SalesByYearCountryTableAdapter.Fill(this.techProductsLtdDataSet.___SalesByYearCountry);
	  // TODO: This line of code loads data into the 'techProductsLtdDataSet.___SalesByCountryYear' table. You can move, or remove it, as needed.
	  this.___SalesByCountryYearTableAdapter.Fill(this.techProductsLtdDataSet.___SalesByCountryYear);
	}

	private void DBDrillDown_Load(object sender, EventArgs e)
	{


	}

	private void button1_Click(object sender, EventArgs e)
	{
	  Steema.TeeChart.Editors.SeriesEditor.ShowEditor(bar1, ChartEditorTabs.SeriesDataSource);
	}
  }
}
