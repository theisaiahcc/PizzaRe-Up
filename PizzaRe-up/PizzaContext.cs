using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRe_up
{
    internal class PizzaContext : DbContext
    {
        public PizzaContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True");
        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
