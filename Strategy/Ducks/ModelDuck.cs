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
    /// ModelDuck class
    /// </summary>
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}