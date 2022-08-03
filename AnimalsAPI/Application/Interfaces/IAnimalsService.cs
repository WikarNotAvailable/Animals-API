using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    //interface used of animals service
    public interface IAnimalsService
    {
        IEnumerable<AnimalDto> GetAllAnimals();
        AnimalDto GetAnimal(Guid id);
        AnimalDto AddAnimal(CreateAnimalDto newAnimal);
        void UpdateAnimal(Guid id, UpdateAnimalDto updateAnimal);
        void DeleteAnimal(Guid id);
    }
}
