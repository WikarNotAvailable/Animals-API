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
    public class AnimalsService : IAnimalsService
    {
        private readonly IAnimalsRepository repository;
        private readonly IMapper mapper;
        public AnimalsService(IAnimalsRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;  
        }

        public IEnumerable<AnimalDto> GetAllAnimals()
        {
            var animals = repository.GetAnimals();
            return mapper.Map<IEnumerable<AnimalDto>>(animals);
        }
        public AnimalDto GetAnimal(Guid id)
        {
            var animal = repository.GetAnimal(id);
            return mapper.Map<AnimalDto>(animal);
        }
        public AnimalDto AddAnimal(CreateAnimalDto newAnimal)
        {
            var animal = mapper.Map<Animal>(newAnimal);
            repository.AddAnimal(animal);
            return mapper.Map<AnimalDto>(animal);
        }
    }
}
