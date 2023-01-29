using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Layout
{
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
