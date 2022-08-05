using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    //Service operating on a animals repository, animals controller is using its functions
    public class AnimalsService : IAnimalsService
    {
        private readonly IAnimalsRepository repository;
        private readonly IMapper mapper;
        public AnimalsService(IAnimalsRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;  
        }
        public IQueryable<AnimalDto> GetAllAnimals()
        {
            var animals = repository.GetAll();
            return mapper.ProjectTo<AnimalDto>(animals);
        }

        public async Task<IEnumerable<AnimalDto>> GetAllAnimalsAsync(int pageNumber, int pageSize, string sortField, bool ascending, string filterBy)
        {
            var animals = await repository.GetAllAnimalsAsync(pageNumber, pageSize, sortField, ascending, filterBy);
            return mapper.Map<IEnumerable<AnimalDto>>(animals);
        }
        public async Task<int> GetAllAnimalsCountAsync(string filterBy)
        {
            return await repository.GetAllCountAsync(filterBy);
        }
        public async Task<AnimalDto> GetAnimalAsync(Guid id)
        {
            var animal = await repository.GetAnimalAsync(id);
            return mapper.Map<AnimalDto>(animal);
        }
        public async Task<AnimalDto> AddAnimalAsync(CreateAnimalDto newAnimal)
        {
            var animal = mapper.Map<Animal>(newAnimal);
            await repository.AddAnimalAsync(animal);
            return mapper.Map<AnimalDto>(animal);
        }
        public async Task UpdateAnimalAsync(Guid id, UpdateAnimalDto updateAnimal)
        {
            var existingAnimal = await repository.GetAnimalAsync(id);
            var animal = mapper.Map(updateAnimal, existingAnimal);
            await repository.UpdateAnimalAsync(animal);
        }

        public async Task DeleteAnimalAsync(Guid id)
        {
            var existingAnimal = await repository .GetAnimalAsync(id);
            await repository.DeleteAnimalAsync(existingAnimal);
        }

   
    }
}
