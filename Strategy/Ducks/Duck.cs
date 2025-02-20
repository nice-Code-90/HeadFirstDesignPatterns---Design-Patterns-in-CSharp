using Strategy.Interfaces;

namespace Strategy.Ducks
{
    /// <summary>
	/// abstract base class of Ducks
	/// </summary>
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quacking();
        }

        public static void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();
    }
}