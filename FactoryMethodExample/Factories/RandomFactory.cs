using FactoryMethodExample.Animals;
using System;
using System.Linq;
using System.Reflection;

namespace FactoryMethodExample.Factories
{
    public class RandomFactory : IAnimalFactory
    {
        public Animal CreateAnimal()
        {
            var animalTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => !x.IsAbstract && x.IsSubclassOf(typeof(Animal)))
                .ToList();

            var randomIndex = new Random().Next(0, animalTypes.Count);

            return Activator.CreateInstance(animalTypes.ElementAt(randomIndex)) as Animal;
        }
    }
}
