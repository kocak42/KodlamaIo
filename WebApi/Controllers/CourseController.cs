using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost("add")]
        public IActionResult Add(Course course)
        {
            _courseService.Add(course);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Course course)
        {
            _courseService.Delete(course);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Course course)
        {
            _courseService.Update(course);
            return Ok();
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _courseService.GetById(id);
            return Ok(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseService.GetAll();
            return Ok(result);
        }
    }
}
