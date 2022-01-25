using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataExtraction;
using LinearAlgebra;

namespace ClustersPresentation
{
    class ClusterDataFormer
    {
        private IDataExtractor _dataExtractor;
        private List<IMathVector> _clusterPointsList = new List<IMathVector>();

        public ClusterDataFormer(IDataExtractor dataExtractor)
        {
            _dataExtractor = dataExtractor;
        }

        public List<IMathVector> ClusterPointsList
        {
            get
            {
                return _clusterPointsList;
            }
            
        }
        public void ArrangeData()
        {
            string[] separatingStrings = { "<<", "    " };            
            string[] text = _dataExtractor.ExtractData();
            for (int i = 0; i < text.Length; i++)
            {
                _clusterPointsList.Add(new MathVector(text[i].Split(separatingStrings,StringSplitOptions.RemoveEmptyEntries)));
            }
        }

    }
}
