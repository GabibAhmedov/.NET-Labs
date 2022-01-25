using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataExtraction;
using Clustering;
using LinearAlgebra;

namespace ClustersPresentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path="";
            OpenFileDialog OPF = new OpenFileDialog();

            if (OPF.ShowDialog() == DialogResult.OK)
            {

                path = OPF.FileName;
            }
            var data = new ClusterDataFormer(new FileReader(path));
            data.ArrangeData();
          
            int numAttributes = 2;
            int numClusters = 15;
            int maxCount = 100;
            var clustering = new Clusterer(data.ClusterPointsList,numClusters,numAttributes, maxCount);

            int iteration = 0;      
            int numTuples = data.ClusterPointsList.Count;
            clustering.Initiate();
            clustering.InitClusters();
            while (clustering.changed == true  && iteration < maxCount)
            {
                ++iteration;
                clustering.Assign();
                clustering.UpdateMeans();
                clustering.UpdateCentroids();
            }
            



            ClusterVisualisator clusterVisualisator = new ClusterVisualisator();

            clusterVisualisator.ClusterVisualisation(chart1, data, clustering.Centroids);
           for (int i=0;i<numClusters;i++)
           {
               textBox1.Text += i.ToString() +":"+ clustering.Centroids[i][0].ToString() + " " + clustering.Centroids[i][1].ToString();
               textBox1.Text += "//";
           }

            /*
            for (int i = 0; i < data.ClusterPointsList.Count-4500; i++)
            {
                textBox1.Text= textBox1.Text + " " + clustering[i].ToString();
            }*/
        }
    }
}
