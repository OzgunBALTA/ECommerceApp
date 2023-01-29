using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Layout
{
    public class Navbar : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
