using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Layout
{
    public class Footer : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
