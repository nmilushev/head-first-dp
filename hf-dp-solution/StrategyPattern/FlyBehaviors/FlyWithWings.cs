using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
}
