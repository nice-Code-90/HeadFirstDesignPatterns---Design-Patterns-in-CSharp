using Decorator.StarbuzzCoffee.Interfaces;

namespace Decorator.StarbuzzCoffee.Coffees
{
    public class Decaf : IBeverage
    {
        public string GetDescription()
        {
            return "Decaf Coffee";
        }

        public double Cost()
        {
            return 1.05;
        }
    }
}