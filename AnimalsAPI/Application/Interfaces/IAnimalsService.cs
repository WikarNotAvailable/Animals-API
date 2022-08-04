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
        Task<IEnumerable<AnimalDto>> GetAllAnimalsAsync(int pageNumber, int pageSize);
        Task<int> GetAllAnimalsCountAsync();
        Task<AnimalDto> GetAnimalAsync(Guid id);
        Task<AnimalDto> AddAnimalAsync(CreateAnimalDto newAnimal);
        Task UpdateAnimalAsync(Guid id, UpdateAnimalDto updateAnimal);
        Task DeleteAnimalAsync(Guid id);
    }
}
