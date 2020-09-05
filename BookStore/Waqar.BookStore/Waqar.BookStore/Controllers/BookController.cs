using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Waqar.BookStore.Models;
using Waqar.BookStore.Repository;

namespace Waqar.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<ViewResult> GetAllBook(bool isSuccess = false, int bookID = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookID = bookID;
            var data = await _bookRepository.GetAllBook();
            return View(data);
        }

        //public BookModel GetSingleBook(int BookID)
        //{

        //    return _bookRepository.GetSingleBook(BookID);
        //}
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetSingleBook(id);

            return View(data);
        }
        public List<BookModel> SearchBook(string Title, string Author)
        {

            return _bookRepository.SearchBook(Title, Author);
        }

        public ViewResult AddNewBook()
        {

            ModelState.Clear();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookmodel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookmodel);
                if (id > 0)
                {

                    return RedirectToAction("GetAllBook", new { isSuccess = true, bookID = id });
                }
            }
            return View();

        }




    }
}
