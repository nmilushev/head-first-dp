using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior { get; set; }
        public IFlyBehavior FlyBehavior { get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            this.FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            this.QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks floar, even decoys!");
        }
    }
}
