using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicClassLibrary
{
    public class DeceaseArgs : EventArgs
    {
        public int CurrentYear { get; }
        public DeceaseArgs(int year)
        {
            CurrentYear = year;           
        }

    }
}
