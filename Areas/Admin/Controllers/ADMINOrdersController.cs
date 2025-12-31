using Interview1.DataDbContext;
using Interview1.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Interview1.Areas.Admin.Controllers
{
    [Area("Admin")] /* 告訴MVC路由，這個需要加 /Admin */
    public class ADMINOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ADMINOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.Orders.ToList();
            return View(orders);
        }


        public IActionResult Details(Guid id)
        {
            var order =
                (from o in _context.Orders
                 where o.OrderId == id
                 select o).FirstOrDefault();
            // LINQ語法 => 在Orders資料表中，找出所有OrderId等於參數id的第一筆訂單，找不到就顯示null

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult Edit(Guid id)
        {
            var order = (from o in _context.Orders
                         where o.OrderId == id
                         select o).FirstOrDefault();

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost]
        public IActionResult Edit(Order model)
        {
            var order = (from o in _context.Orders
                         where o.OrderId == model.OrderId
                         select o).FirstOrDefault();

            if (order == null)
            {
                return NotFound();
            }

            order.OrderDate = model.OrderDate;
            order.MemberId = model.MemberId;
            order.TotalAmount = model.TotalAmount;
            order.OrderStatus = model.OrderStatus;
            order.PaymentMethod = model.PaymentMethod;
            order.ShippingStatus = model.ShippingStatus;
            order.Note = model.Note;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            var order = (from o in _context.Orders
                         where o.OrderId == id
                         select o).FirstOrDefault();

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}
