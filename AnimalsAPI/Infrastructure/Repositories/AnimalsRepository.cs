using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    //Handling AnimalsRepository set in a SQL database   
    public class AnimalsRepository : IAnimalsRepository
    {
        private readonly AnimalsContext context;

        public AnimalsRepository(AnimalsContext _context)
        {
            context = _context;
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return context.animals;
        }
        public Animal GetAnimal(Guid _id)
        {
            return context.animals.SingleOrDefault(animal => animal.id == _id);
        }

        public void AddAnimal(Animal animal)
        {
            context.animals.Add(animal);
            context.SaveChanges(); 
        }

        public void UpdateAnimal(Animal animal)
        {
            context.animals.Update(animal);
            context.SaveChanges();
        }
        public void DeleteAnimal(Animal animal)
        {
            context.animals.Remove(animal);
            context.SaveChanges();
        }
    }
}
