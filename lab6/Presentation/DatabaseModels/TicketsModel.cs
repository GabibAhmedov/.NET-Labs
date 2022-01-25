using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DatabaseModels
{
    public class Ticket
    {
        public int Id { get; set; }
        [ForeignKey("VisitorId")]
        public int VisitorId { get; set; }
        [ForeignKey("ExhibitionId")]
        public int ExhibitionId { get; set; }
        [Required]
        public double Price { get; set; }

        public Visitor Visitor { get; set; }
        public Exhibition Exhibition { get; set; }

    }
}
