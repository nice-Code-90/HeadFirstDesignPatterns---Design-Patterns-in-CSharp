using Decorator.StarbuzzCoffee.Interfaces;

namespace Decorator.StarbuzzCoffee.Decorators
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage Beverage;

        protected CondimentDecorator(IBeverage beverage)
        {
            Beverage = beverage;
        }

        public abstract string GetDescription();

        public abstract double Cost();
    }
}