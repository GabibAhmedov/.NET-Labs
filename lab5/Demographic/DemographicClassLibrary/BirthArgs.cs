using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicClassLibrary
{
    public class BirthArgs : EventArgs
    {
        public int CurrentYear { get; }
        public BirthArgs(int year)
        {
            CurrentYear = year;
        }
    }
}
