using Decorator.StarbuzzCoffee.Interfaces;

namespace Decorator.StarbuzzCoffee.Decorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Soy";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.15;
        }
    }
}