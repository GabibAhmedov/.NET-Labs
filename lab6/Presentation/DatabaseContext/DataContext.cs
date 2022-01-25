using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;


namespace DatabaseContext
{
  
    public class DataContext : DbContext
    {
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }

        public string connectionString = "User ID=postgres;Password=GA18042002;Server=localhost;Port=5432;Database=ExhibDb2;";


       public DataContext(DbContextOptions<DataContext> options) : base(options)
       {

       }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        
    }
}
