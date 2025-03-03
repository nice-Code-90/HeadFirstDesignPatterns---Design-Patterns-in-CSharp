using FactoryMethod.PizzaStore.Factory;

public class FactoryMethodPizzaStore
{
    public static void Main(string[] args)
    {
        var nyStore = new NYStylePizzaStore();
        var chicagoStore = new ChicagoStylePizzaStore();
        var pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine($"Ethan ordered a {pizza.Name}\n");
        pizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine($"Joel ordered a {pizza.Name}\n");
        pizza = nyStore.OrderPizza("clam");
        Console.WriteLine($"Ethan ordered a {pizza.Name}\n");
        pizza = chicagoStore.OrderPizza("clam");
        Console.WriteLine($"Joel ordered a {pizza.Name}\n");
        pizza = nyStore.OrderPizza("pepperoni");
        Console.WriteLine($"Ethan ordered a {pizza.Name}\n");
        pizza = chicagoStore.OrderPizza("pepperoni");
        Console.WriteLine($"Joel ordered a {pizza.Name}\n");
        pizza = nyStore.OrderPizza("veggie");
        Console.WriteLine($"Ethan ordered a {pizza.Name}\n");
        pizza = chicagoStore.OrderPizza("veggie");
        Console.WriteLine($"Joel ordered a {pizza.Name}\n");
    }
}