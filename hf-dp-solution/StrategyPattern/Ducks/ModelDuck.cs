using StrategyPattern.FlyBehaviors;
using StrategyPattern.QuackBehaviors;
using System;

namespace StrategyPattern.Ducks
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            base.FlyBehavior = new FlyNoWay();
            base.QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
