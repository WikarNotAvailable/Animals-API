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
    }
}
