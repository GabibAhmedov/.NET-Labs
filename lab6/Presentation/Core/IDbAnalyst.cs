using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    interface IDbAnalyst
    {
        public int TheAmountOfTicketsSoldToTheExhibition(int id);
        public int TheAmountOfUniqueExhibitionsVisitedByTheVisitor(int id);
        public int TheAverageDiscountOfTheVistorsOfTheExhibition(int id);
    }
}
