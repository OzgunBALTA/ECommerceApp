using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Layout
{
    public class Navbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
