using Factory.PizzaStore.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PizzaStore.Factory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }
}