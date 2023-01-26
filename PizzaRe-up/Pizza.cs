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
        public string PepperoniIng { get; set; }

        public string SausageIng { get; set; }

        public string HamIng { get; set; }

        public string BaconIng { get; set; }

        public string ChickenIng { get; set; }

        /// <summary>
        /// Vegetables for the pizza(s).
        /// </summary>
        public string PeppersVg { get; set; }

        public string MushroomsVg { get; set; }

        public string OlivesVg { get; set; }

        public string JalapenosVg { get; set; }

        /// <summary>
        /// Sauces for the pizza(s).
        /// </summary>
        public string RedSauce { get; set; }

        public string WhiteSauce { get; set; }

        /// <summary>
        /// Prices for the pizza(s).
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// The specialty pizza name(s).
        /// </summary>
        public string PizzaNames { get; set; }

    }
}
