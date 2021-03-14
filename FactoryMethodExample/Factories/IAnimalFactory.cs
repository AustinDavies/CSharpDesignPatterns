using FactoryMethodExample.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample.Factories
{
    public interface IAnimalFactory
    {
        Animal CreateAnimal();
    }
}
