using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicClassLibrary
{
    public class YearTickArgs : EventArgs
    {
        public int CurrentYear { get; }
        public int CurrentPopulation { get; }
        public Engine Model { get; }
        public YearTickArgs(int year, int currentPopulation)
        {
            CurrentYear = year;
            CurrentPopulation = currentPopulation;           
        }
    }
}
