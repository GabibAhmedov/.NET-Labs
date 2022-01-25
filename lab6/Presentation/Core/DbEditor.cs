using System;
using DatabaseModels;
using DatabaseContext;

namespace Core
{
    public class DbEditor : IDbEditor
    {
        private DataContext _context;
        public DbEditor(DataContext context)
        {
            _context = context;
        }

        public void AddNewVisitor(int id, string name, int discount)
        {
            if (name == "")
                name = null;
            
            if (id == 0)
            {
                var visitor = new Visitor { Discount = discount, Name = name };
                _context.Add(visitor);
            }
            else
            {
                var visitor = new Visitor { Id = id, Discount = discount, Name = name };
                _context.Add(visitor);
            }
            _context.SaveChanges();
        }

        public void AddNewExhibition(int id, string name, DateTime date)
        {
            if (id == 0)
            {
                var exhibition = new Exhibition { Date = date, Name = name };
                _context.Add(exhibition);
            }
            else
            {
                var exhibition = new Exhibition { Id = id, Date = date, Name = name  };
                _context.Add(exhibition);
            }
            _context.SaveChanges();
        }
        public void AddNewTicket(int id, int visitorId, int exhibitionId, double price)
        {
            if (id == 0)
            {
                var ticket = new Ticket { VisitorId= visitorId, ExhibitionId=exhibitionId,Price=price };
                _context.Add(ticket);
            }
            else
            {
                var ticket = new Ticket { Id = id, VisitorId = visitorId, ExhibitionId = exhibitionId, Price = price };
                _context.Add(ticket);
            }
            _context.SaveChanges();
        }
        

        public void RemoveTuple(int id, Table table )
        {
            if (table == Table.Visitors)
            {
                _context.Remove(_context.Visitors.Find(id));
            }
            if (table == Table.Tickets)
            {
                _context.Remove(_context.Tickets.Find(id));
            }
            if (table == Table.Exhibitions)
            {
                _context.Remove(_context.Exhibitions.Find(id));
            }
            _context.SaveChanges();
        }

        public void EditVisitor(int id, string name, int discount)
        {           
            _context.Visitors.Find(id).Name=name;
            _context.Visitors.Find(id).Discount = discount;
            _context.SaveChanges();       
        }

        public void EditExhibition(int id, string name, DateTime date)
        {
            _context.Exhibitions.Find(id).Name = name;
            _context.Exhibitions.Find(id).Date = date;
            _context.SaveChanges();
        }

        public void EditTicket(int id, int visitorId, int exhibitionId, double price)
        {
            _context.Tickets.Find(id).VisitorId = visitorId;
            _context.Tickets.Find(id).ExhibitionId= exhibitionId;
            _context.Tickets.Find(id).Price = price;
            _context.SaveChanges();
        }
    }
}
