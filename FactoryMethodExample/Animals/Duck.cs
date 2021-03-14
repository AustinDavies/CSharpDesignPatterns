using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample.Animals
{
    public class Duck : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Quack!");
        }
    }
}
