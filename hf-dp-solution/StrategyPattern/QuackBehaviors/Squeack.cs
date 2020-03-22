using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.QuackBehaviors
{
    class Squeack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeack");
        }
    }
}
