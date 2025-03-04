using AbstractFactory.PizzaStore.Ingredients.Interfaces;
using AbstractFactory.PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; protected set; }
        public ISauce Sauce { get; protected set; }
        public IVeggies[] Veggies { get; protected set; }
        public ICheese Cheese { get; protected set; }
        public IPepperoni Pepperoni { get; protected set; }
        public IClams Clam { get; protected set; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}