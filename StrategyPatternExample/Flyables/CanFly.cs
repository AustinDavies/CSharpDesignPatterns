using StrategyPatternExample.Interfaces;
using System;

namespace StrategyPatternExample.Flyables
{
    public class CanFly : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Started flying...");
        }
    }
}
