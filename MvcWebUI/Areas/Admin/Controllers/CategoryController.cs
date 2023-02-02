using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ApiServices.Abstract;
using MvcWebUI.Models;

namespace MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryApiService _categoryApiService;

        public CategoryController(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetCategories()
        {
            var result = await _categoryApiService.GetAllAsync();
            return Json(result);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryModel categoryModel)
        {
            categoryModel.Status = true;
            await _categoryApiService.AddAsync(categoryModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryApiService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var result = await _categoryApiService.GetAsync(id);

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(CategoryModel categoryModel)
        {
            await _categoryApiService.UpdateAsync(categoryModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangeStatus(int id)
        {
            await _categoryApiService.ChangeStatusAsync(id);
            return RedirectToAction("Index");
        }
    }
}
