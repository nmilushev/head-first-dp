using StrategyPattern.QuackBehaviors;
using System;

namespace StrategyPattern.Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            base.QuackBehavior = new Quack();
            base.FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a real Mallard duck");
        }
    }
}
