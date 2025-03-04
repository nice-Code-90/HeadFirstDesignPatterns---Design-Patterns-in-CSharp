using AbstractFactory.PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore.Ingredients
{
    public class FreshClams : IClams
    {
        public string Name => "Fresh Clams";
    }
}