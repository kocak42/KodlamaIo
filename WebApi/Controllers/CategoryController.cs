using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            _categoryService.Add(category);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Category category)
        {
            _categoryService.Delete(category);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            _categoryService.Update(category);
            return Ok();
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            return Ok(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return Ok(result);
        }
    }
}
