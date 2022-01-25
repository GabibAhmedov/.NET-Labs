using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicFileOperations
{
    public interface IDataExtractor
    {
        List<string[]> ExtractData();
    }
}
