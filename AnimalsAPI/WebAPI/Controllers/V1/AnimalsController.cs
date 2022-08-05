using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Filters;
using WebAPI.Helpers;
using WebAPI.Wrappers;

namespace WebAPI.Controllers.V1
{
    // First version of animals controller

    [ApiController]
    [ApiVersion("1.0")]
    [Route("animals")]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalsService animalsService;
        public AnimalsController(IAnimalsService _animalsService)
        {
            animalsService = _animalsService;
        }
        [HttpGet("GetSortFields")]
        public ActionResult GetSortFields()
        {
            return Ok(SortingHelper.GetSortFields().Select(x => x.Key));
        }
        [HttpGet]
        public async Task <ActionResult<IEnumerable<AnimalDto>>> GetAllAnimals([FromQuery]PaginationFilter paginationFilter, [FromQuery] SortingFilter sortingFilter, [FromQuery] string filterBy = "")
        {
            var validPaginationFilter = new PaginationFilter(paginationFilter.pageNumber, paginationFilter.pageSize);
            var validSortingFilter = new SortingFilter(sortingFilter.sortField, sortingFilter.ascending);

            var animals = await animalsService.GetAllAnimalsAsync(validPaginationFilter.pageNumber, validPaginationFilter.pageSize,
                                                                  validSortingFilter.sortField, validSortingFilter.ascending,
                                                                  filterBy);

            var totalRecords = await animalsService.GetAllAnimalsCountAsync(filterBy);

            return Ok(PaginationHelper.CreatePagedResponse(animals, validPaginationFilter, totalRecords));
        }
        [HttpGet("[action]")]
        [EnableQuery]
        public IQueryable<AnimalDto> GetAll()
        {
            return animalsService.GetAllAnimals();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AnimalDto>> GetAnimal(Guid id)
        {
            var animal = await animalsService.GetAnimalAsync(id);
            if(animal == null)
            {
                return NotFound();
            }
            return Ok(new Response<AnimalDto>(animal));
        }
        [HttpPost]
        public async Task<ActionResult<AnimalDto>> AddAnimal(CreateAnimalDto newAnimal)
        {
            var animal = await animalsService.AddAnimalAsync(newAnimal);
            return Created($"/animals/{animal.id}", new Response<AnimalDto>(animal));
        }
        [HttpPut("{id}")]
        public async Task <ActionResult> UpdateAnimal(Guid id, UpdateAnimalDto updateAnimal)
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
