using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DemographicClassLibrary;

namespace DemographicClassLibrary
{
    public class Visualisator
    {


       public static void  DrawLineChart(Chart chart, Engine data,int currentYear )
       {
           chart.Series[0].Points.AddXY(currentYear, data.GetPopulation);
       }

       public void DrawBarChart(Chart chart, Engine data,string sex)
        {
            chart.Series.Clear();
            string[] seriesArray = { "0-18", "19-45", "45-65", "65-100" };
            List<int> pointsArray;
            if (sex == "male")
            {               
                pointsArray = new List<int>();
                int point = data.GetPeople.Count(p => p.Sex == "male" && (data.GetFinalYear - p.DateOfBirth) >= 0 && (data.GetFinalYear - p.DateOfBirth) <= 18);
                pointsArray.Add(point);
                point = data.GetPeople.Count(p => p.Sex == "male" && (data.GetFinalYear - p.DateOfBirth) >= 19 && (data.GetFinalYear - p.DateOfBirth) <= 45);
                pointsArray.Add(point);
                point = data.GetPeople.Count(p => p.Sex == "male" && (data.GetFinalYear - p.DateOfBirth) >= 46 && (data.GetFinalYear - p.DateOfBirth) <= 65);
                pointsArray.Add(point);
                point = data.GetPeople.Count(p => p.Sex == "male" && (data.GetFinalYear - p.DateOfBirth) >= 66 && (data.GetFinalYear - p.DateOfBirth) <= 100);
                pointsArray.Add(point);
            }
            else
            {                
                pointsArray = new List<int>();
                int point = data.GetPeople.Count(p => p.Sex == "female" && (data.GetFinalYear - p.DateOfBirth) >= 0 && (data.GetFinalYear - p.DateOfBirth) <= 18);
                pointsArray.Add(point);
                point = data.GetPeople.Count(p => p.Sex == "female" && (data.GetFinalYear - p.DateOfBirth) >= 19 && (data.GetFinalYear - p.DateOfBirth) <= 45);
                pointsArray.Add(point);
                point = data.GetPeople.Count(p => p.Sex == "female" && (data.GetFinalYear - p.DateOfBirth) >= 46 && (data.GetFinalYear - p.DateOfBirth) <= 65);
                pointsArray.Add(point);
                point = data.GetPeople.Count(p => p.Sex == "female" && (data.GetFinalYear - p.DateOfBirth) >= 66 && (data.GetFinalYear - p.DateOfBirth) <= 100);
                pointsArray.Add(point);
            }

            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = chart.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }

        }
    }
}
