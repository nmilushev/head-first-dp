﻿using StrategyPattern.Ducks;
using StrategyPattern.FlyBehaviors;

namespace StrategyPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}
