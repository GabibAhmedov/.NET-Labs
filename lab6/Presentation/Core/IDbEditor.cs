using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    interface IDbEditor
    {
        void AddNewVisitor(int id, string name, int discount);
        void AddNewTicket(int id, int visitorId, int exhibitionId, double price);
        public void AddNewExhibition(int id, string name, DateTime date);
        void RemoveTuple(int id, Table table);

        void EditVisitor(int id, string name, int discount);

        void EditExhibition(int id, string name, DateTime date);

        void EditTicket(int id, int visitorId, int exhibitionId, double price);


    }
}
