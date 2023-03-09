using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        public void Update(Pizza p, int id)
        {
            using PizzaContext DbContext = new PizzaContext();
            Pizza pizza = DbContext.Pizzas.Find(id);

            Type type = typeof(Pizza);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.Name != "PizzaId")
                {
                    DbContext.Entry(pizza).Property(property.Name).CurrentValue = property.GetValue(p);
                }
            }
            DbContext.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PizzaRe-up;Trusted_Connection=True");
        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
