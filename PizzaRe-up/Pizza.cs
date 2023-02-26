using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRe_up
{
    public class Pizza
    {

        public Pizza(string Ingredients) 
        {
            this.Ingredients = Ingredients;
            Sauce = "red";
            Price = 0;
            Crust = "regular";
            Size = 'M';
            CustomerName = "";
        }
        /// <summary>
        /// Represents pizza ingredients and customerName inside class.
        /// </summary>
        /// <param name="Ingredients"></param>
        /// <param name="Sauce"></param>
        /// <param name="Price"></param>
        /// <param name="Crust"></param>
        /// <param name="Size"></param>
        /// <param name="customerName"></param>
        public Pizza(string Ingredients, string Sauce, double Price, string Crust, char Size, string customerName)
        {
            this.Ingredients = Ingredients;
            this.Sauce = Sauce;
            this.Price = Price;
            this.Crust = Crust;
            this.Size = Size;
            CustomerName = customerName;
        }

        /// <summary>
        /// PizzaId is for which pizza is unique to the id.
        /// Ex: If an order is handed out, each order has a unique id given to the customer.
        /// </summary>
        [Key]
        [Column("PizzaId", Order = 1)]
        public int PizzaId { get; set; }

        /// <summary>
        /// Ingredients for the pizza(s).
        /// Ex: Bacon, Mushrooms, Jalepenos, etc.
        /// </summary>
        public string Ingredients { get; set; }

        /// <summary>
        /// Sauce for the pizza(s).
        /// </summary>
        public string Sauce { get; set; }

        /// <summary>
        /// Prices for the pizza(s).
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Crust selections for the pizza(s).
        /// </summary>
        public string Crust { get; set; }

        /// <summary>
        /// Size selections for the pizza(s).
        /// </summary>
        public char Size { get; set; }

        /// <summary>
        /// The customer name for the order.
        /// </summary>
        public string CustomerName { get; set; }

        public override string ToString()
        {
            return CustomerName + "Size: " + Size + "Pizza: " + Ingredients;
        }
    }
}
