using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{

    
    public class AnimalsRepository : IAnimalsRepository
    {
        private static readonly List<Animal> animals = new()
        {
            new Animal("Dog", "Florek", "Shih-tzu", 7, "Male")
        };

        public IEnumerable<Animal> GetAnimals()
        {
            return animals;
        }
        public Animal GetAnimal(Guid _id)
        {
            return animals.SingleOrDefault(animal => animal.id == _id);
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void UpdateAnimal(Animal animal)
        {
            int index = animals.FindIndex(existingAnimal => existingAnimal.id == animal.id);
            animals[index] = animal;
        }
    }
}
