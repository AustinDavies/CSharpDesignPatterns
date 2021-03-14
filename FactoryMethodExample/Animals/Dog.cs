using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample.Animals
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bark!");
        }
    }
}
