using Strategy.Behaviors.FlyBehaviors;
using Strategy.Behaviors.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    /// <summary>
    /// RubberDuck class
    /// </summary>
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}