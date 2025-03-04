using AbstractFactory.PizzaStore.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore.Ingredients
{
    public class Onion : IVeggies
    {
        public string Name
        {
            get
            {
                return "Onion";
            }
        }
    }
}