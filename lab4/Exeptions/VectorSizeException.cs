using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorException
{
   public class VectorSizeException:VectorException
    {
        public VectorSizeException(string message) : base(message)
        {

        }
    }
}
