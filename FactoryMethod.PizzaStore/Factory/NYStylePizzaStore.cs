﻿using FactoryMethod.PizzaStore.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaStore.Factory
{
    public class NYStylePizzaStore : PizzaStore
    {
        // Factory method implementation
        protected override Pizza CreatePizza(string type)
        {
            Pizza? pizza = null;
            if (type == "cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new NYStyleClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new NYStyleVeggiePizza();
            }
            return pizza;
        }
    }
}