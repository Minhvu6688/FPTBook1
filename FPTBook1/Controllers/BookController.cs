using FPTBook1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using FPTBook1.Models;

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
        [HttpGet]
        public IActionResult AddBook()
        {
            var category = context.Categories.ToList();
            ViewBag.Categories = category;
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            context.Add(book);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult BookDetail(int? id)
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
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = context.Book.Find(id);
            var category = context.Categories.ToList();
            ViewBag.Categories = category;
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Book.Update(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }
        [HttpGet]
        public IActionResult Cart(int id)
        {
            var Book = context.Book
           .Include(p => p.Categories)
           .FirstOrDefault(m => m.Id == id)
       ;
            return View(Book);
        }
    }
}
