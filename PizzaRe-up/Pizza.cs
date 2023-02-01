using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRe_up
{
    public class Pizza
    {
        /// <summary>
        /// Ingredients for the pizza(s).
        /// </summary>
        public string Ingredients { get; set; }

        /// <summary>
        /// Sauces for the pizza(s).
        /// </summary>
        public string Sauces { get; set; }

        /// <summary>
        /// Prices for the pizza(s).
        /// </summary>
        public double Price { get; set; }
    }
}
