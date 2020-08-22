using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Waqar.BookStore.Model;
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
        public List<BookModel> GetAllBook() {

            return _bookRepository.GetAllBook();
        }

        public BookModel GetSingleBook(int BookID)
        {

            return _bookRepository.GetSingleBook(BookID);
        }
        public List<BookModel> SearchBook(string Title,string Author)
        {

            return _bookRepository.SearchBook(Title,Author);
        }
    }
}
