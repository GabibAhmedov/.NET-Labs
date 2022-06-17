using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorExeption
{
    public class VectorExeption:Exception
    {
        public VectorExeption(string message) : base(message)
        {

        }
    }
}
    