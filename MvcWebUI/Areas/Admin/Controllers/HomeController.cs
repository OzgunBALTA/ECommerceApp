using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Product");
        }
    }
}
