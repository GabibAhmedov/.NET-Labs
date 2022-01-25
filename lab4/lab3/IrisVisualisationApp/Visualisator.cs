using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;
using VectorException;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace IrisVisualisationApp
{
    public class Visualisator
    {
        
        public void  CreateGistorgramm(Chart chart, DataFormer data)
        {
            chart.Series.Clear();
            int tmpIndex;
            if (chart.Name== "sepal_length")
            {
                tmpIndex = 0;
            }
            else
            if (chart.Name== "sepal_width")
            {
                tmpIndex = 1;
            }
            else
            if (chart.Name== "petal_length")
            {
                tmpIndex = 2;
            }
            else
            {
                tmpIndex = 3;
            }

            var dataPoint1 = new DataPoint();
            var dataPoint2 = new DataPoint();
            var dataPoint3 = new DataPoint();
            chart.Series.Add(data.Indicator1);
            chart.Series.Add(data.Indicator2);
            chart.Series.Add(data.Indicator3);
            chart.Titles.Add(chart.Name);
            //chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;      
            dataPoint1.SetValueY(data.AvgVector1[tmpIndex]);
            dataPoint2.SetValueY(data.AvgVector2[tmpIndex]);
            dataPoint3.SetValueY(data.AvgVector3[tmpIndex]);
            chart.Series[data.Indicator1].Points.Add(dataPoint1);
            chart.Series[data.Indicator2].Points.Add(dataPoint2);
            chart.Series[data.Indicator3].Points.Add(dataPoint3);           
        }

        public void CreatePieChart(Chart chart, DataFormer data)
        {
            var statistic = new Dictionary<string, double>();

            chart.Series.Clear();
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Add(new Series(data.Indicator1));
            chart.Series[data.Indicator1].ChartType = SeriesChartType.Pie;
            chart.Series[0].Points.AddY(data.DistBetween12);
            chart.Series[0].Points.AddY(data.DistBetween13);
            chart.Series[0].Points.AddY(data.DistBetween23);

            chart.Series[0].Points[0].LegendText= data.Indicator1+" - " +data.Indicator2;
            chart.Series[0].Points[1].LegendText = data.Indicator1 + " - " + data.Indicator3;
            chart.Series[0].Points[2].LegendText = data.Indicator2 + " - " + data.Indicator3;


            //flowLayoutPanelchart.Controls.Add(chart);

        }
    }
}
