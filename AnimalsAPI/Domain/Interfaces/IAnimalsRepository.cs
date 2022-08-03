using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    //Interface for Animals repository
    public interface IAnimalsRepository
    {
        Task <IEnumerable<Animal>> GetAnimalsAsync();
        Task <Animal> GetAnimalAsync(Guid _id);
        Task AddAnimalAsync(Animal animal);
        Task UpdateAnimalAsync(Animal animal);
        Task DeleteAnimalAsync(Animal animal);
    }
}
