using FactoryMethodExample.Factories;
using System;

namespace FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        { 
            IAnimalFactory factory = new BalancedFactory();
            for(var i = 0; i < 10; i++)
            {
                var animal = factory.CreateAnimal();
                animal.Speak();
            }
        }
    }
}
