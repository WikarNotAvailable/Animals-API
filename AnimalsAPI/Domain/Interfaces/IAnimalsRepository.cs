﻿using Domain.Entities;
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
        IEnumerable<Animal> GetAnimals();
        Animal GetAnimal(Guid _id);
        void AddAnimal(Animal animal);
        void UpdateAnimal(Animal animal);
        void DeleteAnimal(Animal animal);
    }
}
