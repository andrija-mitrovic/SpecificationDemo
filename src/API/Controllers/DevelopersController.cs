using Application.Common.Interfaces;
using Application.Common.Specifications;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        public readonly IGenericRepository<Developer> _repository;

        public DevelopersController(IGenericRepository<Developer> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var developers = await _repository.GetAllAsync();
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var developer = await _repository.GetByIdAsync(id);
            return Ok(developer);
        }

        [HttpGet("specify")]
        public async Task<IActionResult> Specify()
        {
            var specification = new DeveloperWithAddressSpecification(5, 90000);
            //var specification = new DeveloperByIncomeSpecification();
            var developers = _repository.Find(specification);
            return Ok(developers);
        }
    }
}
