using Decorator.StarbuzzCoffee.Interfaces;

namespace Decorator.StarbuzzCoffee.Coffees
{
    public class DarkRoast : IBeverage
    {
        public string GetDescription()
        {
            return "Dark Roast Coffee";
        }

        public double Cost()
        {
            return 0.99;
        }
    }
}