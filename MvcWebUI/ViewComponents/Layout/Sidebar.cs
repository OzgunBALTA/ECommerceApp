using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ApiServices.Abstract;

namespace MvcWebUI.ViewComponents.Layout
{
    public class Sidebar : ViewComponent
    {
        ICategoryApiService _categoryApiService;

        public Sidebar(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _categoryApiService.GetCategoriesStatusTrueAsync();
            return View(result);
        }
    }
}
