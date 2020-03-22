using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.FlyBehaviors
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket!");
        }
    }
}
