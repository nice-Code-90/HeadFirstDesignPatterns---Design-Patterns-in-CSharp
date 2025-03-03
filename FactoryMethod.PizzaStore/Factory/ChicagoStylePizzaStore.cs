using FactoryMethod.PizzaStore.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaStore.Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        // Factory method implementation
        protected override Pizza CreatePizza(string type)
        {
            Pizza? pizza = null;
            if (type == "cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new ChicagoStyleVeggiePizza();
            }
            return pizza;
        }
    }
}