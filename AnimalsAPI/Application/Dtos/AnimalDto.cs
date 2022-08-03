using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    //dto class used for get requests to avoid returning piece of data straight from the database
    public record AnimalDto : IMap
    {
        public Guid id { get; init; }
        public string specie { get; init; }
        public string name { get; init; }
        public string race { get; init; }
        public int age { get; init; }
        public string gender { get; init; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Animal, AnimalDto>();
        }
    }
}
