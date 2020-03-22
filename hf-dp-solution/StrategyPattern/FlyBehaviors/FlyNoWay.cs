using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.FlyBehaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }
}
