using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.QuackBehaviors
{
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack quack");
        }
    }
}
