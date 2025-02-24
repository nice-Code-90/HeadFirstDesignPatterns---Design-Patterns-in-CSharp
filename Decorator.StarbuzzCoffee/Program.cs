using Decorator.StarbuzzCoffee.Coffees;
using Decorator.StarbuzzCoffee.Decorators;
using Decorator.StarbuzzCoffee.Interfaces;

public class StarbuccCoffee
{
    public static void Main(string[] args)
    {
        IBeverage beverage = new Espresso();
        Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");
        IBeverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");
        IBeverage beverage3 = new HouseBlend();
        beverage3 = new Soy(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);
        Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.Cost()}");
    }
}