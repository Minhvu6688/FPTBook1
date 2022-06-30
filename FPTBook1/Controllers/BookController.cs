using FPTBook1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace FPTBook1.Controllers
{
    public class BookController : Controller
    {

        private readonly ApplicationDbContext context;
        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            var Book = context.Book
                .Include(p => p.Categories)
                .ToList();
            return View(Book);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var Book = context.Book.Find(id);
            context.Remove(Book);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Add(int? id)
        {
            if (id == null)
                return NotFound();
            var Book = context.Book.Find(id);
            context.Add(Book);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Book = context.Book
                .Include(p => p.Categories)
                .FirstOrDefault(m => m.Id == id)
            ;
            return View(Book);
        }
    }
}
