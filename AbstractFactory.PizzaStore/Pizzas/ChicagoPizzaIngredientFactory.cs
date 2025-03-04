using AbstractFactory.PizzaStore.Ingredients;
using AbstractFactory.PizzaStore.Ingredients.Interfaces;
using AbstractFactory.PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore.Pizzas
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new BlackOlives(), new Spinach(), new Eggplant() };
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FrozenClams();
        }
    }
}