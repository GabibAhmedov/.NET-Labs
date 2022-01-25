using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinearAlgebra;



namespace IrisVisualisationApp
{
    public partial class IrisApp : Form
    {
        public IrisApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string path = FilePathTextBox.Text;
            var data = new DataFormer();
            data.ArrangeData(path);
            var Spec = data.GetSpecies2;
            var calculator = new Calculator();
            calculator.CalculateAverages(data.GetSpecies1, data.GetSpecies2, data.GetSpecies3,data);
            calculator.CalculateDistance(data.AvgVector1, data.AvgVector2, data.AvgVector3, data);
            var visualisator = new Visualisator();
            visualisator.CreateGistorgramm(sepal_length,data);
            visualisator.CreateGistorgramm(sepal_width,data);
            visualisator.CreateGistorgramm(petal_length, data);
            visualisator.CreateGistorgramm(petal_width, data);
            visualisator.CreatePieChart(PieDist,data);
            Start.Visible = false;
            
           /* for (int i = 0; i < data.AvgVector1.Dimensions; i++)
            {
                textBox1.Text = textBox1.Text + " " + data.AvgVector1[i];
            }
            textBox1.Text = textBox1.Text + "enter";
            for (int i = 0; i < data.AvgVector2.Dimensions; i++)
            {
                textBox1.Text = textBox1.Text + " " + data.AvgVector2[i];
            }
            textBox1.Text = textBox1.Text + "enter";
            for (int i = 0; i < data.AvgVector3.Dimensions; i++)
            {
                textBox1.Text = textBox1.Text + " " + data.AvgVector3[i];
            }
            textBox1.Text = textBox1.Text + "enter";*/
            //textBox1.Text = data.AvgVector1 + "enter" + data.AvgVector2 + "enter" + data.AvgVector3; 

        }

        private void IrisApp_Load(object sender, EventArgs e)
        {
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
