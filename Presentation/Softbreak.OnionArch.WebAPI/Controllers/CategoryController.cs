using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Softbreak.OnionArch.APPLICATION.Dtos.Categories;
using Softbreak.OnionArch.APPLICATION.Managers;

namespace Softbreak.OnionArch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            List<CategoryDto> categories = await _categoryManager.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            CategoryDto category = await _categoryManager.GetByIdAsync(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDto categoryDto)
        {
            string message = await _categoryManager.CreateAsync(categoryDto);
            return Ok(message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryDto categoryDto)
        {
            string message = await _categoryManager.UpdateAsync(categoryDto);
            return Ok(message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            CategoryDto category = await _categoryManager.GetByIdAsync(id);
            string message = await _categoryManager.RemoveAsync(category);
            return Ok(message);
        }
    }
}
