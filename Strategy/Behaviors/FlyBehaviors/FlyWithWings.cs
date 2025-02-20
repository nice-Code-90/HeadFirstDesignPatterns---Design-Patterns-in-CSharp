using Strategy.Interfaces;

namespace Strategy.Behaviors.FlyBehaviors
{
    /// <summary>
	/// FlyWithWings
	/// </summary>
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}