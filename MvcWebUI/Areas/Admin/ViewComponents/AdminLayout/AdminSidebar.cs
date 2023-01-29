using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ApiServices.Abstract;

namespace MvcWebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class AdminSidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
