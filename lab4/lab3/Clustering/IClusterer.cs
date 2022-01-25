using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace Clustering
{
    interface IClusterer
    {
        void InitClusters();
        IEnumerable<Cluster> Clusters { get; }
        Cluster DetermineClusterMembership(IMathVector vector);
    }
    class Cluster
    {
        public Cluster(IMathVector clusterCenter, int id)
        {
            Id = id;
            ClusterCenter = clusterCenter;
        }

        public int Id { get; }
        public IMathVector ClusterCenter { get; }
    }


}
