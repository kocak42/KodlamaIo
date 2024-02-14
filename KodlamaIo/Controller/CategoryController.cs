using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaIo.Controller
{
    public class CategoryController: ControllerBase
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
