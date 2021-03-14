using StrategyPatternExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExample.Flyables
{
    public class NoFly : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Unable to fly...");
        }
    }
}
