using System;
using System.Diagnostics;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace NETStandardFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            CreateChart(args.Length == 0 ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : args[0]);

        }

        static void CreateChart(string path)
        {
            var chartName = "chart" + DateTime.Now.Ticks.ToString() + ".png";
            var chartPath = path + "\\" + chartName;
            var chart = new TChart();
            chart.Series.Add(typeof(Bar)).FillSampleValues();

            chart.Export.Image.PNG.Save(chartPath);

            var process = new Process
            {
                StartInfo = new ProcessStartInfo(chartPath) { UseShellExecute = true }
            };
            process.Start();
        }
    }
}
