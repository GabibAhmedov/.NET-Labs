using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClustersPresentation
{
    class ClusterVisualisator
    {
        
       public void ClusterVisualisation(Chart chart,ClusterDataFormer data,List<IMathVector> centroids)
        {
            DataPoint[] dataPoint1 = new DataPoint[data.ClusterPointsList.Count];
            for (int i = 0; i < data.ClusterPointsList.Count; i++)
            {
                //chart.Titles.Add(chart.Name);
                /*dataPoint1[i] = new DataPoint();
                dataPoint1[i].SetValueXY(data.ClusterPointsList[i][0], data.ClusterPointsList[i][1]);  */
                chart.Series[0].Points.AddXY(data.ClusterPointsList[i][0], data.ClusterPointsList[i][1]);
                //chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;                   
            }
            for (int i = 0; i < centroids.Count; i++)
            {
                
                chart.Series[0].Points.AddXY(centroids[i][0], centroids[i][1]);
                chart.Series[0].Points[chart.Series[0].Points.Count-1].Color= System.Drawing.Color.Red;
                chart.Series[0].Points[chart.Series[0].Points.Count-1].MarkerSize = 6;
            }
        }

    }
}
