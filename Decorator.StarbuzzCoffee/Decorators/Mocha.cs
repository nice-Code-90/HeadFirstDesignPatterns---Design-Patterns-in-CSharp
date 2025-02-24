using Decorator.StarbuzzCoffee.Interfaces;

namespace Decorator.StarbuzzCoffee.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Mocha";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.20;
        }
    }
}