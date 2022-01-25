using System;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DatabaseModels
{
    public class Visitor
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Discount { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
