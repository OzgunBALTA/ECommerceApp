using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ApiServices.Abstract;
using System.Drawing.Printing;

namespace MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryApiService _categoryApiService;

        public CategoryController(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("getcategories")]
        public async Task<IActionResult> GetCategories()
        {
            var result = await _categoryApiService.GetCategoriesStatusTrueAsync();
            return Json(result);
        }
    }
}
