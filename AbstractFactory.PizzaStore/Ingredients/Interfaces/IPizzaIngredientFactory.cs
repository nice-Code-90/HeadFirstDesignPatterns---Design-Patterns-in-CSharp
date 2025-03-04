﻿using AbstractFactory.PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore.Ingredients.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();

        ISauce CreateSauce();

        ICheese CreateCheese();

        IVeggies[] CreateVeggies();

        IPepperoni CreatePepperoni();

        IClams CreateClam();
    }
}