using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interview1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ADMINMembersController : Controller
    {
        // GET: ADMINMembersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ADMINMembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ADMINMembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ADMINMembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ADMINMembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ADMINMembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ADMINMembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ADMINMembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
