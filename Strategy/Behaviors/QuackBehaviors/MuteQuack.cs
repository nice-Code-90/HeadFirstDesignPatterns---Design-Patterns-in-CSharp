﻿using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behaviors.QuackBehaviors
{
    /// <summary>
    /// MuteQuack
    /// </summary>
    public class MuteQuack : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}