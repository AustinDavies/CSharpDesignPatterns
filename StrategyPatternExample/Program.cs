using StrategyPatternExample.Animals;
using StrategyPatternExample.Flyables;
using System;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.SetFlyStrategy(new CanFly());
            animal.Fly();

            animal.SetFlyStrategy(new NoFly());
            animal.Fly();

            Console.ReadKey();
        }
    }
}
