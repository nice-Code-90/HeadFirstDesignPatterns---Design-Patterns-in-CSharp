﻿using AbstractFactory.PizzaStore.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }
    }
}