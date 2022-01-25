using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Core;


namespace PresentationApp
{
    public partial class UserInterface : Form
    {
        public const string connectionString = "User ID=postgres;Password=GA18042002;Server=localhost;Port=5432;Database=ExhibDb;";
        
        public UserInterface()
        {
            InitializeComponent();
            //optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            //optionsBuilder.UseNpgsql(connectionString);
            //context = new DataContext(optionsBuilder.Options);
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
                optionsBuilder.UseNpgsql(connectionString);
                var context = new DataContext(optionsBuilder.Options);

                var dbEditor = new DbEditor(context);
                dbEditor.AddNewVisitor(Convert.ToInt32(VisitorIdTB.Text), VisitorNameTB.Text, Convert.ToInt32(VisitorDiscountTB.Text));
            }
             catch (Exception exc)
            {
                var TED = new ThreadExceptionDialog(exc);
                TED.ShowDialog();
            }
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }

        private void VisitorIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            RelationVisualisator relationVisualisator = new RelationVisualisator(context);
            relationVisualisator.DisplayRelation(dataGridView1, Table.Visitors);
        }
        private void button6_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            RelationVisualisator relationVisualisator = new RelationVisualisator(context);
            relationVisualisator.DisplayRelation(dataGridView1, Table.Exhibitions);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbEditor = new DbEditor(context);
            dbEditor.RemoveTuple(Convert.ToInt32(VisitorIdTB.Text), Table.Visitors);
        }
        private void button5_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbEditor = new DbEditor(context);
            dbEditor.RemoveTuple(Convert.ToInt32(ExhibitionIdTb.Text), Table.Exhibitions);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbEditor = new DbEditor(context);
            dbEditor.AddNewExhibition
            (
                Convert.ToInt32(ExhibitionIdTb.Text), ExhibitionNameTb.Text,
                DateTime.ParseExact(ExhibitionDateTb.Text, "dd.MM.yyyy",
                System.Globalization.CultureInfo.InvariantCulture)
            );
        }

        private void button7_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbEditor = new DbEditor(context);
            dbEditor.AddNewTicket(Convert.ToInt32(TicketIdTB.Text),
                Convert.ToInt32(TicketVisitorIdTB.Text),
                Convert.ToInt32(TicketExhinbitonIdTB.Text),
                Convert.ToDouble(TicketPriceTB.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            RelationVisualisator relationVisualisator = new RelationVisualisator(context);
            relationVisualisator.DisplayRelation(dataGridView1, Table.Tickets);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbEditor = new DbEditor(context);
            dbEditor.RemoveTuple(Convert.ToInt32(TicketIdTB.Text), Table.Tickets);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbEditor = new DbEditor(context);
            dbEditor.EditVisitor(Convert.ToInt32(VisitorIdTB.Text), VisitorNameTB.Text, Convert.ToInt32(VisitorDiscountTB.Text));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbEditor = new DbEditor(context);
            dbEditor.EditExhibition(
                Convert.ToInt32(ExhibitionIdTb.Text), ExhibitionNameTb.Text,
                DateTime.ParseExact(ExhibitionDateTb.Text, "dd.MM.yyyy",
                System.Globalization.CultureInfo.InvariantCulture)
            );
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbEditor = new DbEditor(context);
            dbEditor.EditTicket(Convert.ToInt32(TicketIdTB.Text),
                Convert.ToInt32(TicketVisitorIdTB.Text),
                Convert.ToInt32(TicketExhinbitonIdTB.Text),
                Convert.ToDouble(TicketPriceTB.Text)
            );
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbAnalyst = new DbAnalyst(context);
            AnalysisResultTB.Text= dbAnalyst.TheAmountOfTicketsSoldToTheExhibition(Convert.ToInt32(AnalysisIdTB.Text)).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbAnalyst = new DbAnalyst(context);
            AnalysisResultTB.Text = dbAnalyst.TheAmountOfUniqueExhibitionsVisitedByTheVisitor(Convert.ToInt32(AnalysisIdTB.Text)).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            var context = new DataContext(optionsBuilder.Options);

            var dbAnalyst = new DbAnalyst(context);
            AnalysisResultTB.Text = dbAnalyst.TheAverageDiscountOfTheVistorsOfTheExhibition(Convert.ToInt32(AnalysisIdTB.Text)).ToString();
        }
    }
}