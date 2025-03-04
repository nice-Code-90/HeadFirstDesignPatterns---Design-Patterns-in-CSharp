using AbstractFactory.PizzaStore.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore.Ingredients
{
    public class MozzarellaCheese : ICheese
    {
        public string Name => "Mozzarella Cheese";
    }
}