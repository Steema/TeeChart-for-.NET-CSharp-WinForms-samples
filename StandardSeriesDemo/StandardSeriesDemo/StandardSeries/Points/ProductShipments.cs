using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StandardSeriesDemo.StandardSeries.Points
{
    public partial class ProductShipments : Form
    {
        public ProductShipments()
        {
            InitializeComponent();
        }

        private void ProductShipments_Load(object sender, EventArgs e)
        {
            int[] Yarr1 = new int[] { 5,3,2,7,1,6,4,5,1,0,10,7,11,15,12,21,17,15,19,24,21,11,15,21,19,17,20,23 }; 
            int[] Yarr2 = new int[] { 7,1,5,1,0,10,6,3,2,7,11,4,5,3,4,5,1,5,11,15,16,14,14,13,12,15,17,19 };

            DateTime[] Xarr = new DateTime[] {new DateTime(2012, 9, 1),new DateTime(2012, 9, 15),new DateTime(2012, 10, 1),new DateTime(2012, 10, 15),new DateTime(2012, 11, 1)
                  ,new DateTime(2012, 11, 15),new DateTime(2012, 12, 1),new DateTime(2012, 12, 15),new DateTime(2013, 1, 1),new DateTime(2013, 1, 15)
				  ,new DateTime(2013, 2, 1),new DateTime(2013, 2, 15),new DateTime(2013, 3, 1),new DateTime(2013, 3, 15)
				  ,new DateTime(2013, 4, 1),new DateTime(2013, 4, 15),new DateTime(2013, 5, 1),new DateTime(2013, 5, 15),new DateTime(2013, 6, 1)
                  ,new DateTime(2013, 6, 15),new DateTime(2013, 7, 1),new DateTime(2013, 7, 15),new DateTime(2013, 8, 1),new DateTime(2013, 8, 15)
				  ,new DateTime(2013, 9, 1),new DateTime(2013, 9, 15),new DateTime(2013, 10, 1),new DateTime(2013, 10, 15)};

            tChart1.Panel.Gradient.Visible = false;
            tChart1.Walls.Back.Visible = false;
           
            tChart1[0].Title = "Apples";
            tChart1[1].Title = "Pears";
            tChart1[2].Title = "Average";
            tChart1[0].Add(Xarr,Yarr1);
            tChart1[1].Add(Xarr,Yarr2);

            tChart1[0].XValues.DateTime = true;
            tChart1[1].XValues.DateTime = true;

            points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            points2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            points1.Pointer.Pen.Visible = false;
            points2.Pointer.Pen.Visible = false;

            line1.LinePen.Visible = false;
            line1.Legend.Visible = false;
            line1.CheckDataSource();

            line2.DataSource = line1;
            line2.Smoothed = true;
            line2.CheckDataSource();
            
            tChart1.Header.Font.Size = 16;
            tChart1.SubHeader.Font.Size = 10;
            tChart1.SubHeader.Alignment = StringAlignment.Near;
        }

        private void tChart1_DoubleClick(object sender, EventArgs e)
        {
          tChart1.Zoom.Active = false;
          tChart1.ShowEditor();
          tChart1.Chart.CancelMouse = true;
          tChart1.Zoom.Active = true;
        }
    }
}
