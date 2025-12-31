using Microsoft.AspNetCore.Mvc;

namespace Interview1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ADMINLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
