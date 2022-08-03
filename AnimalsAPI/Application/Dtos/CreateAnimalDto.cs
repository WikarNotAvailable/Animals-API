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
    //dto record for creating animals
    public record CreateAnimalDto : IMap 
    {
        public string specie { get; init; }
        public string name { get; init; }
        public string race { get; init; }
        public int age { get; init; }
        public string gender { get; init; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateAnimalDto, Animal>();
        }
    }
}
