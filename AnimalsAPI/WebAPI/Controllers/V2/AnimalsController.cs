﻿using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.V2
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiVersion("2.0")]
    [ApiController]
    [Route("animals")]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalsService animalsService;
        public AnimalsController(IAnimalsService _animalsService)
        {
            animalsService = _animalsService;
        }
        [HttpGet]
        public ActionResult<AnimalDto> GetAllAnimals()
        {
            var animals = animalsService.GetAllAnimals();
            return Ok(
                new { 
                        Posts = animals,
                        Count = animals.Count()
                    });
        }
        [HttpGet("{id}")]
        public ActionResult<AnimalDto> GetAnimal(Guid id)
        {
            var animal = animalsService.GetAnimal(id);
            if (animal == null)
            {
                return NotFound();
            }
            return animal;
        }
        [HttpPost]
        public ActionResult<AnimalDto> AddAnimal(CreateAnimalDto newAnimal)
        {
            var animal = animalsService.AddAnimal(newAnimal);
            return Created($"/animals/{animal.id}", animal);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateAnimal(Guid id, UpdateAnimalDto updateAnimal)
        {
            var animal = animalsService.GetAnimal(id);
            if (animal == null)
                return NotFound();

            animalsService.UpdateAnimal(id, updateAnimal);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            animalsService.DeleteAnimal(id);
            return NoContent();
        }
    }
}
