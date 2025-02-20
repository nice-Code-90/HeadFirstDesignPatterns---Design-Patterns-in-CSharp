using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Strategy.Behaviors.QuackBehaviors
{
    /// <summary>
    /// Squeak
    /// </summary>
    public class Squeak : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Squeak");
        }
    }
}