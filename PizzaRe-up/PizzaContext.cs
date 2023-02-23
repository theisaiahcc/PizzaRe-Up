using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace PizzaRe_up
{
    internal class PizzaContext : DbContext
    {
        public PizzaContext()
        {

        }

        public void Add(Pizza p)
        {
            using PizzaContext DbContext = new();
            DbContext.Pizzas.Add(p);
            DbContext.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PizzaRe-up;Trusted_Connection=True");
        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
