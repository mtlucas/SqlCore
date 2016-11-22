using System;
using System.Linq;
using SqlCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SqlCore.Controllers
{
    public class BlogsController : Controller
    {
        private BloggingContext _context;

        public BlogsController(BloggingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Index Hit!");
            return View(_context.Blog.ToList());
        }

        public IActionResult Create()
        {
            Console.WriteLine("Create Hit!");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Create Post!");
                _context.Blog.Add(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }

    }

}
