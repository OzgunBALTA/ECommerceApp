using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ApiServices.Abstract;
using MvcWebUI.Models;

namespace MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
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

        public async Task<IActionResult> GetProducts()
        {
            var result = await _productApiService.GetAllAsync();
            return Json(result);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductModel productModel)
        {
            productModel.Status = true;
            await _productApiService.AddAsync(productModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productApiService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var result = await _productApiService.GetAsync(id);

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductModel productModel)
        {
            await _productApiService.UpdateAsync(productModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangeStatus(int id)
        {
            await _productApiService.ChangeStatusAsync(id);
            return RedirectToAction("Index");
        }
    }
}
