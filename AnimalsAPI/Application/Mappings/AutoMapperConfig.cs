﻿using Application.Dtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    //the basest configuration of automapper
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Animal, AnimalDto>();
                cfg.CreateMap<CreateAnimalDto, Animal>();
                cfg.CreateMap<UpdateAnimalDto, Animal>();
            })
            .CreateMapper();
    }
}
