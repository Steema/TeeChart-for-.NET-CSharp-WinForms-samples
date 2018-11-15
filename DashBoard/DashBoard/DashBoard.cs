using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DashBoard
{
	public class XmlDashBoard
	{
		public XmlDashBoard()
		{
			Cells = new List<Cell>();
			Title = "Steema Dashboard";
		}

		public void AddCell(string name, int row, int rowSpan, int column, int columnSpan, CellType cellType, string content = null)
		{
			Cells.Add(new Cell() { Name = name, Row = row, RowSpan = rowSpan, Column = column, ColumnSpan = columnSpan, CellType = cellType, Content = content});
		}

		public string Title { get; set; }

		[XmlElement("Cell", typeof(Cell))]
		public List<Cell> Cells { get; set; }

	}


  public class DashExportWeb
  {
    private bool _useNativeCanvas = false;
    private XmlDashBoard _dash;
    public DashExportWeb(XmlDashBoard dash)
    {
      _dash = dash;
    }


    public void Save(string directory)
    {
      StringBuilder page = new StringBuilder();

      void Append(string s)
      {
        page.Append(s + Environment.NewLine);
      }

      void WriterHeader()
      {
        Append("<!DOCTYPE html>");
        Append("<html lang=\"en\">");
        Append("<head>");
        Append("  <title>" + _dash.Title + "</title>");
        Append("  <meta charset=\"utf-8\">");
        Append("  <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.2/css/bootstrap.min.css\">");
        Append("  <script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>");
        Append("  <script src=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.2/js/bootstrap.min.js\"></script>");
        Append("  <script src=\"https://www.steema.com/files/public/teechart/html5/latest/src/teechart.js\"></script>");
        Append("  <script src=\"https://www.steema.com/files/public/teechart/html5/latest/src/teechart-extras.js\" ></script>");
        Append("  <script src=\"https://www.steema.com/files/public/teechart/html5/latest/src/date.format.js\"></script>");
        Append("  <script src=\"https://www.steema.com/files/public/teechart/html5/latest/src/teechart-maps.js\"></script>");
        Append("  <script src=\"./js/contents.js\"></script>");
        Append("");
        Append("  <script type=\"text/javascript\">");
        Append("  window.onload = function () { drawElements(); }");
        Append("  </script>");
        //Append("  <style>");
        //Append("  @media (max-width: 575px) {");
        //Append("    .col-12 {");
        //Append("	  min-height: 200px;");
        //Append("    }");
        //Append("  }");
        //Append("  </style>");
        Append("</head>");
      }

      void WriteGrids(List<Cell> chartCells)
      {

        foreach (Cell cell in chartCells)
        {
          using (StreamWriter writer = File.CreateText(directory + @"\htm\" + cell.Name + ".htm"))
          {
            writer.Write(cell.Content);
          }
        }
      }

      void WriteChartsJS(List<Cell> chartCells)
      {
        string DoctorContent(Cell cell)
        {
          string result = "  " + cell.Name + "Canvas=document.getElementById(\"canvas_" + cell.Name + "\");" + Environment.NewLine;

          if (_useNativeCanvas)
          {
            //List<string> content = cell.Content.Split('\n').ToList();
            //content = content.Where(x => !string.IsNullOrEmpty(x)).ToList();
            result += "  resize" + cell.Name + "();";
          }
          else
          {
            string content = cell.Content;
            content = content.Replace("chart1.draw()", "resize" + cell.Name + "()");
            content = content.Replace("chart1", cell.Name + "Chart");
            content = content.Replace("\"" + cell.Name + "\"", cell.Name + "Canvas");
            result += content;
          }
          return result;
        }

        foreach (Cell cell in chartCells)
        {
          using (StreamWriter writer = File.CreateText(directory + @"\js\" + cell.Name + ".js"))
          {
            writer.WriteLine("var " + cell.Name + "Chart, " + cell.Name + "Canvas;");
            writer.WriteLine("");
            writer.WriteLine("window.addEventListener('resize', resize" + cell.Name + ");");
            writer.WriteLine("");
            writer.WriteLine("function resize" + cell.Name + "() {");
            writer.WriteLine("  if (" + cell.Name + "Canvas != null) {");
            writer.WriteLine("    var parentStyle = window.getComputedStyle(" + cell.Name + "Canvas.parentElement, null);");
            writer.WriteLine("    var tmpW = Math.floor(" + cell.Name + "Canvas.parentElement.offsetWidth-(parseFloat(parentStyle.paddingLeft)+parseFloat(parentStyle.paddingRight)+parseFloat(parentStyle.borderLeftWidth)+parseFloat(parentStyle.borderRightWidth)));");
            //writer.WriteLine("    var tmpH = Math.floor(" + cell.Name + "Canvas.parentElement.offsetHeight-(parseFloat(parentStyle.paddingTop)+parseFloat(parentStyle.paddingBottom)+parseFloat(parentStyle.borderTopWidth)+parseFloat(parentStyle.borderBottomWidth)));");
            writer.WriteLine("    var tmpH = tmpW * 2/3;");
            writer.WriteLine("");
            if (!_useNativeCanvas)
              writer.WriteLine("    " + cell.Name + "Chart.bounds = new Tee.Rectangle(0, 0, tmpW, tmpH);");
            //writer.WriteLine("    " + cell.Name + "Canvas.style.position=\"absolute\";");
            writer.WriteLine("    " + cell.Name + "Canvas.width = tmpW;");
            writer.WriteLine("    " + cell.Name + "Canvas.height = tmpH;");
            writer.WriteLine("");
            if (!_useNativeCanvas)
              writer.WriteLine("    " + cell.Name + "Chart.draw();");
            writer.WriteLine("  }");
            writer.WriteLine("}");
            writer.WriteLine("");
            writer.WriteLine("function draw" + cell.Name + "() {");
            writer.WriteLine(DoctorContent(cell));
            writer.WriteLine("}");
          }
        }
      }

      void WriteContentsJS()
      {
        using (StreamWriter writer = File.CreateText(directory + @"\js\contents.js"))
        {
          for (int i = 0; i < _dash.Cells.Count; i++)
          {
            Cell cell = _dash.Cells[i];
            if (cell.CellType == CellType.Chart)
            {
              writer.WriteLine("var imported" + i + " = document.createElement('script');");
              writer.WriteLine("imported" + i + ".src = './js/" + cell.Name + ".js';");
              writer.WriteLine("document.head.appendChild(imported" + i + ");");
              writer.WriteLine("");
            }
          }

          writer.WriteLine("");
          writer.WriteLine("function drawElements() {");

          foreach (Cell cell in _dash.Cells)
          {
            if (cell.CellType == CellType.Chart)
            {
              writer.WriteLine("  draw" + cell.Name + "();");
            }
          }

          writer.WriteLine("}");
        }
      }

      void WriteBody()
      {
        Append("");
        Append("<body>");
        Append("<nav class=\"navbar navbar-inverse\">");
        Append("  <div class=\"container-fluid\">");
        Append("    <div class=\"navbar-header\">");
        Append("      <a class=\"navbar-brand\" href=\"#\">" + _dash.Title + "</a>");
        Append("    </div>");
        Append("  </div>");
        Append("</nav>");
        Append("");
        Append("<div class=\"container-fluid\">");

        var rows = _dash.Cells.GroupBy(x => x.Row);

        foreach (var row in rows)
        {
          int colSpan = row.Sum(z => z.ColumnSpan);
          int colCount = row.Count();

          int actualSpan = 12 / colSpan;

          Append("  <div class=\"row\">");

          foreach (Cell cell in row)
          {
            Append("    <div class=\"col-12 col-sm-" + (cell.ColumnSpan * actualSpan) + "\">");

            if (cell.CellType == CellType.Chart)
            {
              if (_useNativeCanvas)
                Append("	  <canvas id=\"canvas_" + cell.Name + "\" height=100 style=\"border:1px solid #00FF00;\"></canvas>");
              else
                Append("	  <canvas id=\"canvas_" + cell.Name + "\" height=100></canvas>");
            }
            else
            {
              if (_useNativeCanvas)
                Append("	  <canvas id=\"canvas_" + cell.Name + "\" height=100 style=\"border:1px solid #00FF00;\"></canvas>");
              else
                Append("	   <iframe style=\"width:100%; height:100%;\" src=\"htm\\" + cell.Name + ".htm\"></iframe>");
            }
            Append("    </div>");
          }

          Append("  </div><br>");
          Append("");
        }


        Append("</div>");
        Append("");
        Append("</body>");
      }

      if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
      if (!Directory.Exists(directory + @"\js")) Directory.CreateDirectory(directory + @"\js");
      if (!Directory.Exists(directory + @"\css")) Directory.CreateDirectory(directory + @"\css");
      if (!Directory.Exists(directory + @"\htm")) Directory.CreateDirectory(directory + @"\htm");

      WriterHeader();

      WriteGrids(_dash.Cells.Where(x => x.CellType == CellType.Grid).ToList());

      WriteChartsJS(_dash.Cells.Where(x => x.CellType == CellType.Chart).ToList());

      WriteContentsJS();

      WriteBody();

      Append("</html>");

      using (StreamWriter writer = File.CreateText(directory + @"\index.html"))
      {
        writer.Write(page.ToString());
      }

      Process.Start(directory + @"\index.html");
    }
  }
  public enum CellType
	{
		Chart,
		Grid
	}

	public struct Cell
	{
		public string Name { get; set; }

		public int Row { get; set; }

		public int RowSpan { get; set; }

		public int Column { get; set; }

		public int ColumnSpan { get; set; }

		public CellType CellType { get; set; }

		public string Content { get; set; }
	}
}
