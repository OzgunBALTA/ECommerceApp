using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Category category)
        {
            var result = await _categoryService.AddAsync(category);
            if (result.Success)
            {
                return Ok(category);
            }

            return BadRequest(category);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var result = await _categoryService.DeleteAsync(category.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(Category category)
        {
            var result = await _categoryService.UpdateAsync(category);
            if (result.Success)
            {
                return Ok(category);
            }

            return BadRequest(result);
        }

        [HttpPost("changestatus/{id}")]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var result = await _categoryService.ChangeStatusAsync(category.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _categoryService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }

        [HttpGet("getcategoriesstatustrue")]
        public async Task<IActionResult> GetCategoriesStatusTrue()
        {
            var result = await _categoryService.GetCategoriesStatusTrueAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }
    }
}
