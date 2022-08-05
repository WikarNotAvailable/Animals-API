using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.ExtensionMethods;
using Microsoft.EntityFrameworkCore;
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
        public IQueryable<Animal> GetAll()
        {
            return context.animals.AsQueryable();
        }

        public async Task<IEnumerable<Animal>> GetAllAnimalsAsync(int pageNumber, int pageSize, string sortField, bool ascending, string filterBy)
        {
            return await context.animals.Where(m => m.name.ToLower().Contains(filterBy.ToLower()))
                .OrderByPropertyName(sortField, ascending)
                .Skip((pageNumber - 1)* pageSize)
                .Take(pageSize)
                 .ToListAsync();
        }
        public async Task<int> GetAllCountAsync(string filterBy)
        {
            return await context.animals.Where(m => m.name.ToLower().Contains(filterBy.ToLower()))
                .CountAsync();
        }
        public async Task<Animal> GetAnimalAsync(Guid _id)
        {
            return await context.animals.SingleOrDefaultAsync(animal => animal.id == _id);
        }

        public async Task AddAnimalAsync(Animal animal)
        {
            context.animals.Add(animal);
            await context.SaveChangesAsync();
            await Task.CompletedTask;
        }

        public async Task UpdateAnimalAsync(Animal animal)
        {
            context.animals.Update(animal);
            await context.SaveChangesAsync();
        }
        public async Task DeleteAnimalAsync(Animal animal)
        {
            context.animals.Remove(animal);
            await context.SaveChangesAsync();
        }

 
    }
}
