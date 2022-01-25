using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DatabaseModels;
using DatabaseContext;
using System.Data;
using System.Data.SqlClient;


namespace Core
{
    public class RelationVisualisator
    {
        private DataContext _context;
        public RelationVisualisator(DataContext context)
        {
            _context = context;
        }


       public void DisplayRelation(DataGridView table,Table relation)
       {
            if (relation == Table.Visitors)
            {
                DataTable tableT = new DataTable();
                tableT.Columns.Add("Id", typeof(int));
                tableT.Columns.Add("Name", typeof(string));
                tableT.Columns.Add("Discount", typeof(int));
                foreach (Visitor visitor in _context.Visitors)
                {

                    tableT.Rows.Add(visitor.Id, visitor.Name, visitor.Discount);
                }
                table.DataSource = tableT;
                table.Refresh();
            }

            if (relation == Table.Tickets)
            {
                DataTable tableT = new DataTable();
                tableT.Columns.Add("Id", typeof(int));
                tableT.Columns.Add("VisitorId", typeof(int));
                tableT.Columns.Add("ExhibitionId", typeof(int));
                tableT.Columns.Add("Price", typeof(double));
                foreach (Ticket ticket in _context.Tickets)
                {

                    tableT.Rows.Add(ticket.Id, ticket.VisitorId, ticket.ExhibitionId,ticket.Price);
                }
                table.DataSource = tableT;
                table.Refresh();
            }

            if (relation == Table.Exhibitions)
            {
                DataTable tableT = new DataTable();
                tableT.Columns.Add("Id", typeof(int));
                tableT.Columns.Add("Name", typeof(string));
                tableT.Columns.Add("Date", typeof(DateTime));              
                foreach (Exhibition exhibition in _context.Exhibitions)
                {

                    tableT.Rows.Add(exhibition.Id, exhibition.Name, exhibition.Date);
                }
                table.DataSource = tableT;
                table.Refresh();
            }        
       }

    }
}
