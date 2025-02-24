using Decorator.StarbuzzCoffee.Interfaces;

namespace Decorator.StarbuzzCoffee.Coffees
{
    public class HouseBlend : IBeverage
    {
        public string GetDescription()
        {
            return "House Blend Coffee";
        }

        public double Cost()
        {
            return 0.89;
        }
    }
}