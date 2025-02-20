using Strategy.Behaviors.FlyBehaviors;
using Strategy.Ducks;

public class MiniDuckSimulator
{
    public static void Main(string[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.PerformQuack();
        mallard.PerformFly();

        Duck model = new ModelDuck();
        model.PerformFly();
        model.SetFlyBehavior(new FlyRocketPowered());
        model.PerformFly();
    }
}