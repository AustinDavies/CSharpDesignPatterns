using FactoryMethodExample.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FactoryMethodExample.Factories
{
    public class BalancedFactory : IAnimalFactory
    {
        private ICollection<Type> AnimalTypesCreated { get; set; }
        public BalancedFactory()
        {
            AnimalTypesCreated = new HashSet<Type>();
        }
        public Animal CreateAnimal()
        {
            var animalTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => !x.IsAbstract && x.IsSubclassOf(typeof(Animal)))
                .ToList();

            var animalTypeToCreate = animalTypes
                    .Where(x => !AnimalTypesCreated.Contains(x))
                    .FirstOrDefault() ?? animalTypes.FirstOrDefault();

            var createdAnimal = ActivateAnimal(animalTypeToCreate);
            RecordAnimalTypeCreation(createdAnimal);

            return createdAnimal;
        }

        private Animal ActivateAnimal(Type animal)
        {
            if (animal == null)
                return null;

            return Activator.CreateInstance(animal) as Animal;
        }

        private void RecordAnimalTypeCreation(Animal animal)
        {
            if (animal == null)
                return;

            var animalType = animal.GetType();
            var countBeforeAddition = AnimalTypesCreated.Count();

            AnimalTypesCreated.Add(animalType);
            
            if (AnimalTypesCreated.Count == countBeforeAddition)
            {
                AnimalTypesCreated.Clear();
                AnimalTypesCreated.Add(animalType);
            }
        }
    }
}
