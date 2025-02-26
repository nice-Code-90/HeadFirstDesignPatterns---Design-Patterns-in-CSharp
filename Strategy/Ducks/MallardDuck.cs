﻿using Strategy.Behaviors.FlyBehaviors;
using Strategy.Behaviors.QuackBehaviors;

namespace Strategy.Ducks
{
    /// <summary>
	/// MallardDuck class
	/// </summary>
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}