using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRe_up
{
    public class Pizza
    {
        public Pizza(int PizzaId, string Ingredients, string Sauces, double Price, string Crust, char Size)
        {
            this.PizzaId = PizzaId;
            this.Ingredients = Ingredients;
            this.Sauces = Sauces;
            this.Price = Price;
            this.Crust = Crust;
            this.Size = Size;
        }

        /// <summary>
        /// Ingredients for the pizza(s).
        /// </summary>
        [Key]
        public int PizzaId { get; set; }

        public string Ingredients { get; set; }

        /// <summary>
        /// Sauces for the pizza(s).
        /// </summary>
        public string Sauces { get; set; }

        /// <summary>
        /// Prices for the pizza(s).
        /// </summary>
        public double Price { get; set; }

        public string Crust { get; set; }

        public char Size { get; set; }
    }
}
