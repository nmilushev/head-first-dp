﻿using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.QuackBehaviors
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
