using StrategyPatternExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExample.Animals
{
    public class Animal
    {
        private IFlyStrategy FlyStrategy { get; set; }

        public void SetFlyStrategy(IFlyStrategy flyStrategy)
        {
            FlyStrategy = flyStrategy;
        }

        public void Fly()
        {
            FlyStrategy.Fly();
        }
    }
}
