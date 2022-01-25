using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DemographicFileOperations;
using DemographicClassLibrary;


namespace Demographic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF1 = new OpenFileDialog();
            string InitialAgePath = AgeFilePathTextBox.Text;
            try
            {
                System.Windows.Forms.MessageBox.Show("Input initial age distribution");
                if (OPF1.ShowDialog() == DialogResult.OK)
                {
                    InitialAgePath = OPF1.FileName;
                }
                AgeFilePathTextBox.Text = InitialAgePath;

                OpenFileDialog OPF2 = new OpenFileDialog();
                string DeathChancePath = DeathFilePathTextBox.Text;
                System.Windows.Forms.MessageBox.Show("Input death rules");
                if (OPF2.ShowDialog() == DialogResult.OK)
                {
                    DeathChancePath = OPF2.FileName;
                }
                DeathFilePathTextBox.Text = DeathChancePath;
            


            var data = new DataFormer(new FileReader(InitialAgePath, DeathChancePath));
            data.ArrangeData();
            var Imitation = new Engine(
                data._InitialAgeDictionary,
                data._DeathRulesMaleDictionary,
                data._DeathRulesFemaleDictionary,
                Convert.ToInt32(StartYearTextBox.Text),
                Convert.ToInt32(FinishYearTextBox.Text),
                Convert.ToInt32(PopulationNumberTextBox.Text)
                );
            Imitation.InitiateModel();
            var visualisator = new Visualisator();
            
            Imitation.StartModel();
            visualisator.DrawBarChart(MaleAgeDistribution,Imitation,"male");
            visualisator.DrawBarChart(FemaleAgeDistribution,Imitation, "female");

            visualisator.DrawLineChart(PopulationChange, Imitation, "all");
            visualisator.DrawLineChart(PopulationChangeMales, Imitation, "male");
            visualisator.DrawLineChart(PopulationChangeFemales, Imitation, "female");

            }
            catch (Exception exc)
            {
                var TED = new ThreadExceptionDialog(exc);
                TED.ShowDialog();
            }

        }
    }
}
