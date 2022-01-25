using LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clustering
{
    public class Clusterer//:IClusterer
    {
        private List<IMathVector> rawData = new List<IMathVector>();
        private List<IMathVector> means = new List<IMathVector>();
        private List<IMathVector> centroids = new List<IMathVector>();
        public bool changed { get; set; }
        int randomSeed = 14;
        private int[] clustering;
        int numClusters;
        int numAtributes;
        int maxCount;

        public List<IMathVector> Centroids
        {
            get { return centroids; }
        }

        //public IEnumerable<Cluster> Clusters => throw new NotImplementedException();

        public Clusterer(List<IMathVector> _rawData, int _numClusters, int _numAtributes, int _maxCount)
        {
            rawData = _rawData;
            numClusters = _numClusters;
            numAtributes = _numAtributes;
            maxCount = _maxCount;
            clustering = new int[_rawData.Count];
            changed = true;


        }
        public void UpdateMeans()
        {
            int numClusters = means.Count;
            for (int k = 0; k < means.Count; ++k)
                for (int j = 0; j < means[k].Dimensions; ++j)
                    means[k][j] = 0.0;
            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < rawData.Count; ++i)
            {
                int cluster = clustering[i];
                ++clusterCounts[cluster];
                for (int j = 0; j < rawData[i].Dimensions; ++j)
                    means[cluster][j] += rawData[i][j];
            }
            for (int k = 0; k < means.Count; ++k)
                for (int j = 0; j < means[k].Dimensions; ++j)
                    means[k][j] /= clusterCounts[k];

        }
     
        public void Initiate()
        {
            
            Random random = new Random(randomSeed);
            int maxVal1 = int.MinValue;
            int maxVal2 = int.MinValue;
            for (int i = 0; i < rawData.Count; ++i)
            {               
                    if (rawData[i][0] > maxVal1)
                        maxVal1 =Convert.ToInt32(rawData[i][0]);            
            }
            for (int i = 0; i < rawData.Count; ++i)
            {
                if (rawData[i][1] > maxVal2)
                    maxVal2 = Convert.ToInt32(rawData[i][1]);
            }

            
            for (int k = 0; k < numClusters; ++k)
               means.Add(new MathVector(random.Next(0,maxVal1), random.Next(0, maxVal2)));

            List<IMathVector> result = new List<IMathVector>();
            for (int k = 0; k < numClusters; ++k)
                centroids.Add(new MathVector(random.Next(0, maxVal1), random.Next(0, maxVal2)));
           
        }

        public void UpdateCentroids()
        {
            for (int k = 0; k < centroids.Count; ++k)
            {
                int numAttributes = means[0].Dimensions;
                IMathVector centroid = new MathVector(numAttributes, 500000.0);
                double minDist = double.MaxValue;
                for (int i = 0; i < rawData.Count; ++i)
                {
                    int c = clustering[i];
                    if (c != k) continue;
                    double currDist = rawData[i].CalcDistance(means[k]);
                    if (currDist < minDist)
                    {
                        minDist = currDist;
                        for (int j = 0; j < centroid.Dimensions; ++j)
                            centroid[j] = rawData[i][j];
                    }
                }               
                    centroids[k] = centroid;
            }
        }
        public void Assign()
        {
            int numClusters = centroids.Count;
            changed = false;
            IMathVector distances = new MathVector(numClusters, 0.0);
            for (int i = 0; i < rawData.Count; ++i)
            {
                for (int k = 0; k < numClusters; ++k)
                    distances[k] = rawData[i].CalcDistance(centroids[k]);
                int newCluster = MinIndex(distances);
                if (newCluster != clustering[i])
                {
                    changed = true;
                    clustering[i] = newCluster;
                }
            }
            
        }

        public int MinIndex(IMathVector distances)
        {
            int indexOfMin = 0;
            double smallDist = distances[0];
            for (int k = 0; k < distances.Dimensions; ++k)
            {
                if (distances[k] < smallDist)
                {
                    smallDist = distances[k]; indexOfMin = k;
                }
            }
            return indexOfMin;
        }
         public int[] InitClusters()
        {
            Random random = new Random(randomSeed);
            int[] clustering = new int[rawData.Count];
            for (int i = 0; i < numClusters; ++i)
            {
                clustering[i] =i;
            }
            for (int i = numClusters; i < clustering.Length; ++i)
            clustering[i] = random.Next(0, numClusters);
            return clustering;
        }
        /*
        public void InitClusters()
        {
            throw new NotImplementedException();
        }

        public Cluster DetermineClusterMembership(IMathVector vector)
        {
            throw new NotImplementedException();
        }*/
    }
}
