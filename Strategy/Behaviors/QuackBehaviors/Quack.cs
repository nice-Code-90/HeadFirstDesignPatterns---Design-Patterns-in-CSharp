using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behaviors.QuackBehaviors
{
    public class Quack : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Quack");
        }
    }
}