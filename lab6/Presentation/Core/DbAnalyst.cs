using System;
using System.Collections.Generic;
using System.Text;
using DatabaseModels;
using DatabaseContext;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class DbAnalyst:IDbAnalyst
    {
        private DataContext _context;

        public DbAnalyst(DataContext context)
        {
            _context = context;
        }

        public int TheAmountOfTicketsSoldToTheExhibition(int id)
        {         
            return _context.Tickets.Count(t => t.ExhibitionId == id);
        }

        public int TheAmountOfUniqueExhibitionsVisitedByTheVisitor(int id)
        {        
            var visitor = _context.Visitors.Include(v => v.Tickets).ThenInclude(t => t.Exhibition).FirstOrDefault(v => v.Id == id);
            var count = visitor.Tickets.Select(t => t.Exhibition).Distinct().Count();
            return count;/*(from ticket in _context.Tickets
                    from exhibition in _context.Exhibitions
                    where ticket.VisitorId == id
                    where exhibition.Id == ticket.ExhibitionId && exhibition.Date < DateTime.Now
                    select ticket.ExhibitionId).Distinct().Count(); */
        }
        public int TheAverageDiscountOfTheVistorsOfTheExhibition(int id)
        {
            var exhibition = _context.Exhibitions.Include(e => e.Tickets).ThenInclude(t=>t.Visitor).FirstOrDefault(e => e.Id == id);
            var discount = exhibition.Tickets.Select(t => t.Visitor).Distinct().Average(v=>v.Discount);
            return Convert.ToInt32(discount);


        }
    }
}
