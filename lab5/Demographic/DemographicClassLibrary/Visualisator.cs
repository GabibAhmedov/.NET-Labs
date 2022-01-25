using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DemographicClassLibrary
{
    public class Visualisator
    {     
        public Visualisator()
        {
      
        }

        public void DrawLineChart(Chart chart, Engine data, string sex)
        {
     
            if (sex == "male")
            {
                for (int i = data.GetStartYear; i <= data.GetFinalYear; i++)
                {
                    chart.Series[0].Name = "Male population change";
                    chart.Series[0].Points.AddXY(i, data.GetPeople.Count(p => p.Sex == "male" && p.DateOfBirth <= i && (p.DateOfDecease == -1 || p.DateOfDecease >= i)));
                }
            }
            if (sex == "female")
            {
                for (int i = data.GetStartYear; i <= data.GetFinalYear; i++)
                {
                    chart.Series[0].Name = "Female population change";
                    chart.Series[0].Points.AddXY(i, data.GetPeople.Count(p => p.Sex == "female" && p.DateOfBirth <= i && (p.DateOfDecease == -1 || p.DateOfDecease >= i)));

                }
            }
            else
            {
                for (int i = data.GetStartYear; i <= data.GetFinalYear; i++)
                {
                    chart.Series[0].Name= "Population change";
                    chart.Series[0].Points.AddXY(i, data.GetPeople.Count(p =>p.DateOfBirth <= i && (p.DateOfDecease == -1 || p.DateOfDecease >= i)));

                }
            }

        }

        public void DrawBarChart(Chart chart, Engine data, string sex)
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
