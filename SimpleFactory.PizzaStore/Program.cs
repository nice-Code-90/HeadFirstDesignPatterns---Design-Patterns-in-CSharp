using Factory.PizzaStore;
using Factory.PizzaStore.Factory;

public class SimplefactoryPizzaStore
{
    public static void Main(string[] args)
    {
        var factory = new SimplePizzaFactory();
        var store = new PizzaStore(factory);
        var pizza = store.OrderPizza("cheese");
        Console.WriteLine($"We ordered a {pizza.Name}\n");
        pizza = store.OrderPizza("veggie");
        Console.WriteLine($"We ordered a {pizza.Name}\n");
        pizza = store.OrderPizza("clam");
        Console.WriteLine($"We ordered a {pizza.Name}\n");
        pizza = store.OrderPizza("pepperoni");
        Console.WriteLine($"We ordered a {pizza.Name}\n");
    }
}