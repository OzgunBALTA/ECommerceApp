using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Product product)
        {
            var result = await _productService.AddAsync(product);
            if (result.Success)
            {
                return Ok(product);
            }

            return BadRequest(product);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var result = await _productService.DeleteAsync(product.Data);
            if (result.Success)
            {
                return Ok(product);
            }

            return BadRequest(product);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(Product product)
        {
            var result = await _productService.UpdateAsync(product);
            if (result.Success)
            {
                return Ok(product);
            }

            return BadRequest(product);
        }

        [HttpPost("changestatus/{id}")]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var result = await _productService.ChangeStatusAsync(product.Data);
            if (result.Success)
            {
                return Ok(product);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }

        [HttpGet("getproductsbycategoryid/{id}")]
        public async Task<IActionResult> GetProductsByCategoryId(int id)
        {
            var result = await _productService.GetByCategoryIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }

        [HttpGet("getallwithcategory")]
        public async Task<IActionResult> GetAllWithCategory()
        {
            var result = await _productService.GetAllWithCategoryAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }

        [HttpGet("getproductswithcategorybycategoryid/{id}")]
        public async Task<IActionResult> GetProductsWithCategoryByCategoryId(int id)
        {
            var result = await _productService.GetProductsWithCategoryByCategoryIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }

        [HttpGet("getproductsstatustrue")]
        public async Task<IActionResult> GetProductsStatusTrue()
        {
            var result = await _productService.GetProductsStatusTrueAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }

        [HttpGet("getproductsstatustruebycategoryid/{id}")]
        public async Task<IActionResult> GetProductsStatusTrueByCategoryId(int id)
        {
            var result = await _productService.GetProductsStatusTrueByCategoryIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }
    }
}
