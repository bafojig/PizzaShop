using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class Pizza : Item
    {
        public string size;
        public List<string> toppings;
        public string crust;
        public string cheese;
    }
}
