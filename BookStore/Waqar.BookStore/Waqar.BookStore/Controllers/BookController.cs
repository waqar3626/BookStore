using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Waqar.BookStore.Models;
using Waqar.BookStore.Repository;

namespace Waqar.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository=null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBook() {

            var data= _bookRepository.GetAllBook();
            return View(data);
        }

        //public BookModel GetSingleBook(int BookID)
        //{

        //    return _bookRepository.GetSingleBook(BookID);
        //}
        public ViewResult GetBook(int BookID)
        { 
            var data = _bookRepository.GetSingleBook(BookID);
           
            return View(data);
        }
        public List<BookModel> SearchBook(string Title,string Author)
        {

            return _bookRepository.SearchBook(Title,Author);
        }
    }
}
