using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.V2
{
    // Second version of animals controller, mostly for testing purposes
    /*
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
        public async Task<ActionResult<AnimalDto>> GetAllAnimals()
        {
            var animals = await animalsService.GetAllAnimalsAsync();
            return Ok(
                new
                {
                    Posts = animals,
                    Count = animals.Count()
                });
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AnimalDto>> GetAnimal(Guid id)
        {
            var animal = await animalsService.GetAnimalAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            return animal;
        }
        [HttpPost]
        public async Task<ActionResult<AnimalDto>> AddAnimal(CreateAnimalDto newAnimal)
        {
            var animal = await animalsService.AddAnimalAsync(newAnimal);
            return Created($"/animals/{animal.id}", animal);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAnimal(Guid id, UpdateAnimalDto updateAnimal)
        {
            var animal = await animalsService.GetAnimalAsync(id);
            if (animal == null)
                return NotFound();

            await animalsService.UpdateAnimalAsync(id, updateAnimal);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAnimal(Guid id)
        {
            await animalsService.DeleteAnimalAsync(id);
            return NoContent();
        }
    }
}
    */
}
