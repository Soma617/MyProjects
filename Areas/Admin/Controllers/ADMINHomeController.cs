using Microsoft.AspNetCore.Mvc;

namespace Interview1.Area.Admin.ADMINcontroller
{
    [Area("Admin")]
    public class ADMINHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
