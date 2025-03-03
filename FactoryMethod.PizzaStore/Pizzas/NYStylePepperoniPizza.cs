using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaStore.Pizzas
{
    internal class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            Name = "NY Style Pepperoni Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Garlic");
            Toppings.Add("Onion");
            Toppings.Add("Mushrooms");
            Toppings.Add("Red Pepper");
        }
    }
}