using FPTBook1.Data;
using FPTBook1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FPTBook1.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext context;
        public CartController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult detail()
        {
            var cart = context.Carts.ToList();
            return View(cart);
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cart = context.Carts
                .Include(b => b.Book)
                .Include(c => c.Cart_Date)
                .FirstOrDefault(o => o.Id == id);
            return View(cart);
        }

        public IActionResult Create(int? id)
        {
            var book = context.Book.Where(b => b.Id == id);
            ViewBag.Books = book;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cart cart)
        {
            cart.Cart_Date = System.DateTime.Now;
            context.Carts.Add(cart);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cart = context.Carts.Find(id);
            context.Carts.Remove(cart);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Buy(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cart = context.Carts.Find(id);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
