using Business.Abstracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LayeredArchitectureSimple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : Controller
    {
        private readonly IInstructorService _instructorService;
        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _instructorService.GetAllAsync());
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _instructorService.GetByIdAsync(id));
        }

        [HttpGet("GetAllWithCourses")]
        public async Task<IActionResult> GetAllWithCoursesAsync()
        {
            return Ok(await _instructorService.GetAllWithCoursesAsync());
        }

        [HttpGet("GetByFullName")]
        public async Task<IActionResult> GetByFullName(string firstName, string lastName)
        {
            return Ok(await _instructorService.GetByFullNameAsync(firstName,lastName));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] Instructor instructor)
        {
            return Ok(await _instructorService.AddAsync(instructor));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] Instructor instructor)
        {
            return Ok(await _instructorService.UpdateAsync(instructor));
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _instructorService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
