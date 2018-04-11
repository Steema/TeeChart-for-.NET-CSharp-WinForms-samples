using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppNetCore2.Models;

namespace WebAppNetCore2.Controllers
{
	public class HomeController : Controller
	{

		private static Object renderLock = new Object();

		System.IO.MemoryStream tempStream1;
		System.IO.MemoryStream tempStream2;

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GetChartTitle()
		{
			Steema.TeeChart.Chart myChart = new Steema.TeeChart.Chart();
			return Content(myChart.Header.Text);
		}
		
		public void GetChartImage()
		{
			lock (renderLock)
			{
				Steema.TeeChart.Chart wChart = new Steema.TeeChart.Chart();

				Steema.TeeChart.Themes.AndrosTheme xpTheme = new Steema.TeeChart.Themes.AndrosTheme(wChart);
				xpTheme.Apply();


				wChart.Aspect.View3D = false;
				
				wChart.Chart.Series.Add(new Steema.TeeChart.Styles.Line());
				wChart.Chart.Series[0].FillSampleValues();

				tempStream1 = new System.IO.MemoryStream();
				wChart.Chart.Export.Image.PNG.Save(tempStream1);
				tempStream1.Flush();
				Response.ContentType = "Image/PNG";
				Response.Body.Write(tempStream1.ToArray(), 0, (int)tempStream1.Length);

				tempStream1.Close();
			}
		}
		
		public void GetHTML5Chart(int? type)
		{
			lock (renderLock)
			{
				{
					Steema.TeeChart.Chart wChart3 = new Steema.TeeChart.Chart();

					List<string> customCode = new List<string>();

					/*string[] customCode = new string[] {
									" chart1.applyTheme(\"minimal\");" };*/

					//********* enhance view, client code ***********

					string[] customCodeS = new string[] {
							" ",
							" ",

							"//tooltip",
							"tip=new Tee.ToolTip(chart1);",
							"tip.render=\"dom\";",
							"tip.autoHide=true;",
							"tip.domStyle = \"padding-left:8px; padding-right:8px; padding-top:2px; padding-bottom:4px; margin-left:5px; margin-top:0px; \";",
							"tip.domStyle = tip.domStyle + \"background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; \";",
							"tip.domStyle = tip.domStyle + \"border-style:solid;border-color:#A3A3AF;border-width:1; z-index:1000;\";",
							"chart1.tools.add(tip);",
							"tip.onhide=function() { scaling=0; poindex=-1; }",

							"tip.ongettext=function( tool, text, series, index) { ",
							"  var s = '<font face=\"verdana\" color=\"black\" size=\"1\"><strong>'+ series.title+'</strong></font>';",
							"	    s = s + '<br/><font face=\"verdana\" color=\"darkblue\" size=\"1\">Series point: <strong>'+ index.toFixed(0)+'</strong></font>';",
							"      s =	s +'<br/><font face=\"verdana\" color=\"red\" size=\"1\">Value: '+series.data.values[index].toFixed(2)+'</font>';  ",
							"   return s;",
							"}"
				};
					//********* end client code *********************

					customCode.AddRange(customCodeS);

					customCode.Add(wChart3.Export.Image.JScript.ChartName + ".applyTheme(\"minimal\");");

					if (type == 0)
						wChart3.Series.Add(new Steema.TeeChart.Styles.Pie());
					else if (type == 1)
					{
						wChart3.Series.Add(new Steema.TeeChart.Styles.Bar());

						List<string> extFunc = new List<string>();

						extFunc.Add("var animation;");
						extFunc.Add("var loopCounter = 0;");

						extFunc.Add("function manualLoop()");
						extFunc.Add("{");
						extFunc.Add("animation.animate(" + wChart3.Export.Image.JScript.ChartName + ");");
						extFunc.Add("loopCounter++;");
						extFunc.Add("if (loopCounter < 10)");
						extFunc.Add("  setTimeout(manualLoop, 9000);");
						extFunc.Add("}");

						wChart3.Export.Image.JScript.ExternalCode = extFunc.ToArray();

						wChart3.Export.Image.JScript.SourceUnits.Add("teechart-animations.js");

						customCode.Add("   //animation");
						customCode.Add("   animation = new Tee.SeriesAnimation();");
						customCode.Add("   animation.duration = 3900;");
						customCode.Add("   animation.kind = \"each\";");
						customCode.Add("   fadeAnimation = new Tee.FadeAnimation();");
						customCode.Add("   fadeAnimation.duration = 5000;");
						customCode.Add("   fadeAnimation.fade.series = true;");
						customCode.Add("   fadeAnimation.fade.marks = true;");
						customCode.Add("   animation.mode = \"linear\"; ");
						customCode.Add("   fadeAnimation.mode = \"linear\";");
						customCode.Add("   animation.items.push(fadeAnimation);");
						customCode.Add("   ");
						customCode.Add("   animation.animate(chart1);");

						customCode.Add("  setTimeout(manualLoop, 6000); ");

						customCode.Add(wChart3.Export.Image.JScript.ChartName + ".axes.bottom.labels.format.font.fill = \"rgba(0,0,0,0.6)\";");
						customCode.Add(wChart3.Export.Image.JScript.ChartName + ".axes.bottom.labels.format.font.setSize(\"10px\");");
						customCode.Add(wChart3.Export.Image.JScript.ChartName + ".series.items[0].marks.transparent = true;");
					}
					else
					{
						Steema.TeeChart.Styles.Line line = new Steema.TeeChart.Styles.Line();
						wChart3.Series.Add(line);
					}

					if (wChart3.Series[0] is Steema.TeeChart.Styles.Line)
						wChart3.Series[0].FillSampleValues(100);
					else
						wChart3.Series[0].FillSampleValues();

					wChart3.Export.Image.JScript.CustomCode = customCode.ToArray();

					tempStream2 = new System.IO.MemoryStream();
					wChart3.Export.Image.JScript.Width = 740;
					wChart3.Export.Image.JScript.Height = 300;
					wChart3.Export.Image.JScript.Save(tempStream2);

					tempStream2.Position = 0;

					byte[] output = ReadFully(tempStream2);

					Response.ContentType = "text/html";
					Response.Body.Write(output, 0, output.Length);

				}
			}
		}

		public static byte[] ReadFully(System.IO.MemoryStream input)
		{
			byte[] buffer = new byte[16 * 1024];
			using (MemoryStream ms = new MemoryStream())
			{
				int read;
				while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
				{
					ms.Write(buffer, 0, read);
				}
				return ms.ToArray();
			}
		}


		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}


		public void GetInterpolatedChart(int? type)
		{

			lock (renderLock)
			{
				{
					Steema.TeeChart.Chart wChart3 = new Steema.TeeChart.Chart();

					List<string> customCode = new List<string>();
					List<string> externalCode = new List<string>();
					List<string> externalHTML = new List<string>();

					string[] externalHTMLS = new string[] {
					"<font face=\"verdana\" size=1><span id=\"xpos\"></span><br/>",
					"<span id=\"yposBar\"></span></font><br>"
				};

					string[] externalCodeS = new string[] {
					" ",
					" var posXLabel, posYLabel;",
					" ",
					" function interpolateLineSeries(s, xval) {",
					"  var yValues=s.data.values;",
					"  var len=yValues.length;",
					"  var xValues=[];",
					"",
					"  if (s.data.x)",
					"    xValues=s.data.x;",
					"  else {",
					"    for (i=0;i<len;i++)",
					"      xValues[i]=i;",
					"  }",
					"",
					"  var index;",
					"  for (index=0;index<len;index++) {",
					"    if (xValues[index]>xval)",
					"      break;",
					"  }",
					"",
					"  if (index<1)",
					"    index=1;",
					"  else",
					"    if (index>=len)",
					"      index=len-1;",
					"",
					"  var dx=xValues[index] - xValues[index-1];",
					"  var dy=yValues[index] - yValues[index-1];",
					"",
					"  if (dx!=0)",
					"    return dy*(xval - xValues[index-1])/dx + yValues[index-1];",
					"  else",
					"    return 0;",
					"}",

				};

					string[] customCodeS = new string[] {
							" ",
							" ",

							"  var ypos=document.getElementById('yposBar'); ",
							"  for (i=0;i<3;i++) {",
							"    if (i>0) {",
							"	  var br = document.createElement('br');",
							"      ypos.appendChild(br);",
							"	}",
							"	posYLabel=document.createElement('span');",
							"	posYLabel.id='ypos'+i;",
							"	ypos.appendChild(posYLabel);",
							"  }",

							"  ",
							"//tooltip",
							"tip=new Tee.ToolTip(chart1);",
							"tip.render=\"dom\";",
							"tip.domStyle = \"padding-left:8px; padding-right:8px; padding-top:2px; padding-bottom:4px; margin-left:5px; margin-top:0px; \";",
							"tip.domStyle = tip.domStyle + \"background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; \";",
							"tip.domStyle = tip.domStyle + \"border-style:solid;border-color:#A3A3AF;border-width:1; z-index:1000;\";",
							"chart1.tools.add(tip);",
							"tip.onhide=function() { scaling=0; poindex=-1; }",

							"tip.ongettext=function( tool, text, series, index) { ",
							"  var s = '<font face=\"verdana\" color=\"black\" size=\"1\"><strong>'+ series.title+'</strong></font>';",
							"	    s = s + '<br/><font face=\"verdana\" color=\"darkblue\" size=\"1\">Series point: <strong>'+ index.toFixed(0)+'</strong></font>';",
							"      s =	s +'<br/><font face=\"verdana\" color=\"red\" size=\"1\">Value: '+series.data.values[index].toFixed(2)+'</font>';  ",
							"   return s;",
							"}",
							"  ",

							"  var t=new Tee.CursorTool(chart1); ",
							"  t.direction='vertical';",
							"  t.format.stroke.size=1;",
							"  t.format.stroke.fill='gray';",
							"  chart1.tools.add(t);",
							"  var xValue;",
							"  ",
							"  posXLabel=document.getElementById('xpos');  ",
							"  t.onchange=function(p) {",
							"    xValue=chart1.axes.bottom.fromPos(p.x);",
							"	   posXLabel.textContent='X Value = '+xValue.toFixed(2);",
							"	   for (var i=0; i<chart1.series.items.length; i++){",
							"	     posYLabel=document.getElementById('ypos'+i);",
							"	     posYLabel.textContent=chart1.series.items[i].title+' Y Value = '+interpolateLineSeries(chart1.series.items[i],xValue).toFixed(2);",
							"	   }",
							"",
							"	   // changeTheme(chart1, 'minimal');",
							"	   chart1.draw();",
							"  };",
							"",

							"chart1.ondraw=function() {",
							"    var xs=this.axes.bottom.calc(xValue);",
							"",
							"    for (var i=0;i<this.series.items.length;i++) {",
							"      var ys=this.axes.left.calc(interpolateLineSeries(this.series.items[i],xValue));",
							"      var f=new Tee.Format(this);",
							"      f.fill=this.series.items[i].format.fill;",
							"      f.ellipse(xs,ys,8,8);",
							"    }",
							"  }",
							"  "
							
        };
					//********* end client code *********************

					customCode.AddRange(customCodeS);

					customCode.Add(" chart1.applyTheme(\"minimal\");");

					Steema.TeeChart.Styles.Line line1 = new Steema.TeeChart.Styles.Line();
					Steema.TeeChart.Styles.Line line2 = new Steema.TeeChart.Styles.Line();
					Steema.TeeChart.Styles.Points p3 = new Steema.TeeChart.Styles.Points();

					line1.Pointer.Visible = true;
					line2.Pointer.Visible = true;

					p3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;

					wChart3.Series.Add(line1);
					wChart3.Series.Add(line2);
					wChart3.Series.Add(p3);

					wChart3.Legend.Visible = false;

					for (int i = 0; i < 3; i++)
					{
						wChart3.Series[i].FillSampleValues(50);
					}

					wChart3.Export.Image.JScript.CustomCode = customCode.ToArray();
					wChart3.Export.Image.JScript.ExternalCode = externalCodeS.ToArray();
					wChart3.Export.Image.JScript.BodyHTML = externalHTMLS.ToArray();

					tempStream2 = new System.IO.MemoryStream();
					wChart3.Export.Image.JScript.Width = 950;
					wChart3.Export.Image.JScript.Height = 300;
					wChart3.Export.Image.JScript.Save(tempStream2);

					tempStream2.Position = 0;

					byte[] output = ReadFully(tempStream2);

					Response.ContentType = "text/html";
					Response.Body.Write(output, 0, output.Length);

				}
			}
		}


		public void GetPieChartx()
		{
			{
				Steema.TeeChart.Chart wChart2 = new Steema.TeeChart.Chart();

				wChart2.Series.Add(new Steema.TeeChart.Styles.Pie());
				wChart2.Series[0].FillSampleValues();

				tempStream2 = new System.IO.MemoryStream();
				wChart2.Export.Image.PNG.Save(tempStream2);
				tempStream2.Flush();

				Response.ContentType = "Image/png";
				Response.Body.Write(tempStream2.ToArray(), 0, (int)tempStream2.Length);

				tempStream2.Close();
			}
		}

		public ActionResult GetScatterChart(int? w, int? h)
		{
			lock (renderLock)
			{
				{

					int width = (w > 0) ? (int)w : 400;
					int height = (h > 0) ? (int)h : 300;

					Steema.TeeChart.Chart wChart2 = new Steema.TeeChart.Chart();

					wChart2.Series.Add(new Steema.TeeChart.Styles.Points());
					wChart2.Series[0].FillSampleValues();

					wChart2.Draw();

					wChart2.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
					wChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

					tempStream2 = new System.IO.MemoryStream();
					wChart2.Export.Image.PNG.Width = width;
					wChart2.Export.Image.PNG.Height = height;

					wChart2.Export.Image.PNG.Save(tempStream2);

					tempStream2.Position = 0;

					return base.File(tempStream2, "image/png");
				}
			}
		}

		public ActionResult GetGanttGauge(int? w, int? h)
		{
			lock (renderLock)
			{
				{

					int width = (w > 0) ? (int)w : 400;
					int height = (h > 0) ? (int)h : 300;

					Steema.TeeChart.Chart wChart2 = new Steema.TeeChart.Chart();

					//Steema.TeeChart.Utils.UseCaches = false;
					wChart2.Header.Text = "Circular Gauge";

					wChart2.Aspect.View3D = false;
					wChart2.Series.Add(new Steema.TeeChart.Styles.Gantt());
					wChart2.Series[0].FillSampleValues(30);

					wChart2.Draw();

					wChart2.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
					wChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

					tempStream2 = new System.IO.MemoryStream();
					wChart2.Export.Image.PNG.Width = width;
					wChart2.Export.Image.PNG.Height = height;

					wChart2.Export.Image.PNG.Save(tempStream2);

					tempStream2.Position = 0;

					return base.File(tempStream2, "image/png");
				}
			}
		}

		public ActionResult GetEqualizerChart(int? w, int? h)
		{
			lock (renderLock)
			{
				{

					int width = (w > 0) ? (int)w : 400;
					int height = (h > 0) ? (int)h : 300;

					Steema.TeeChart.Chart wChart2 = new Steema.TeeChart.Chart();

					Steema.TeeChart.Utils.UseCaches = false;
					wChart2.Header.Text = "Equalizer Gauge";

					Steema.TeeChart.Themes.BlackIsBackTheme rpTheme = new Steema.TeeChart.Themes.BlackIsBackTheme(wChart2);
					rpTheme.Apply();

					wChart2.Aspect.View3D = false;
					wChart2.Series.Add(new Steema.TeeChart.Styles.Equalizer());
					wChart2.Series[0].FillSampleValues(40);

					wChart2.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
					wChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

					tempStream2 = new System.IO.MemoryStream();
					wChart2.Export.Image.PNG.Width = width;
					wChart2.Export.Image.PNG.Height = height;

					wChart2.Export.Image.PNG.Save(tempStream2);

					tempStream2.Position = 0;

					return base.File(tempStream2, "image/png");
				}
			}
		}

	}
}
