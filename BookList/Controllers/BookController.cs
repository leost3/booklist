using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookList.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;


        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Books.ToList()  );
        }

        //GET book/create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            if(ModelState.IsValid)
            {
                _db.Add(book);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }else
            {
                return View(book);
            }
        }

    }
}