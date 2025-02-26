using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PizzaStore.Pizzas
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara Pizza Sauce";
            Toppings.Add("Fresh Mozzarella");
            Toppings.Add("Parmesan");
        }
    }
}