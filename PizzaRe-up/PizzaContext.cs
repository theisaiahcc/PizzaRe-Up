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

        public async Task Add(Pizza p)
        {
            using PizzaContext DbContext = new();
            await DbContext.Pizzas.AddAsync(p);
            await DbContext.SaveChangesAsync();
        }

        public async Task Update(Pizza p, int id)
        {
            using PizzaContext DbContext = new PizzaContext();
            Pizza? pizza = await DbContext.Pizzas.FindAsync(id);

            // Create type object of type Pizza
            Type type = typeof(Pizza);
            // Get the properties of that type
            PropertyInfo[] properties = type.GetProperties();
            // Iterate through each property
            foreach (PropertyInfo property in properties)
            {
                // If the property is not the ID, set the current value of the property to updated pizza
                if (property.Name != "PizzaId")
                {
                    DbContext.Entry(pizza).Property(property.Name).CurrentValue = property.GetValue(p);
                }
            }
            await DbContext.SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PizzaRe-up;Trusted_Connection=True");
        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
