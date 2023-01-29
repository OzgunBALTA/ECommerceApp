using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ApiServices.Abstract;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiService _productApiService;

        public ProductController(IProductApiService productApiService)
        {
            _productApiService = productApiService;
        }

        public async Task<IActionResult> Index()
        {

            var result = await _productApiService.GetProductsStatusTrue();
            return View(result);
        }

        public async Task<IActionResult> GetProductsByCategoryId(int id)
        {
            var result = await _productApiService.GetProductsStatusTrueByCategoryIdAsync(id);
            return View(result);
        }
    }
}
