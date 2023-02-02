using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ApiServices.Abstract;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiService _productApiService;

        public ProductController(IProductApiService productApiService)
        {
            _productApiService = productApiService;
        }

        public IActionResult Index()
        {

            return View();
        }

        [Route("getallproducts")]
        public async Task<IActionResult> GetProducts()
        {

            var result = await _productApiService.GetProductsStatusTrue();
            return Json(result);
        }

        [Route("getproductsbycategoryid/{id}")]
        public async Task<IActionResult> GetProductsByCategoryId(int id)
        {
            var result = await _productApiService.GetProductsStatusTrueByCategoryIdAsync(id);
            return Json(result);
        }
    }
}
