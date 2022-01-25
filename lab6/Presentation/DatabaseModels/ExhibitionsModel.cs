using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels
{
    public class Exhibition
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
     
    }
}
