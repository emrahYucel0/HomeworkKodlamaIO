using Business.Abstracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LayeredArchitectureSimple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _courseService.GetAllAsync());
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _courseService.GetByIdAsync(id));
        }

        [HttpGet("GetAllWithCategory")]
        public async Task<IActionResult> GetAllWithCategoryAsync()
        {
            return Ok(await _courseService.GetAllWithCategoryAsync());
        }

        [HttpGet("GetAllWithInstructor")]
        public async Task<IActionResult> GetAllWithInstructorAsync()
        {
            return Ok(await _courseService.GetAllWithInstructorAsync());
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] Course course)
        {
            return Ok(await _courseService.AddAsync(course));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] Course course)
        {
            return Ok(await _courseService.UpdateAsync(course));
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _courseService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
