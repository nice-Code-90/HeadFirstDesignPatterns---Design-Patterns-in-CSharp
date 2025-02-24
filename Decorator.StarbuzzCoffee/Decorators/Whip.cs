using Decorator.StarbuzzCoffee.Interfaces;

namespace Decorator.StarbuzzCoffee.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Whip";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.10;
        }
    }
}