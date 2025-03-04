using AbstractFactory.PizzaStore.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore.Ingredients
{
    public class PlumTomatoSauce : ISauce
    {
        public string Name => "Plum Tomato Sauce";
    }
}