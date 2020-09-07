using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Waqar.BookStore.Data;
using Waqar.BookStore.Models;

namespace Waqar.BookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _Context = null;

        public BookRepository(BookStoreContext context)
        {

            _Context = context;
        }

        public async Task<int> AddNewBook(BookModel model)
        {
            var NewBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages,
                UpdatedOn = DateTime.UtcNow,
                Category = model.Category,
                LanguageID = model.LanguageID

            };
            await _Context.Books.AddAsync(NewBook);
            await _Context.SaveChangesAsync();

            return NewBook.BookID;
        }
        public async Task<List<BookModel>> GetAllBook()
        {
            var books = new List<BookModel>();
            var allBooks = await _Context.Books.ToListAsync();
            if (allBooks?.Any() == true)
            {
                foreach (var book in allBooks)
                {
                    books.Add(new BookModel()
                    {
                        BookID=book.BookID,
                        Author = book.Author,
                        CreatedOn = book.CreatedOn,
                        Description = book.Description,
                        Title = book.Title,
                        TotalPages = book.TotalPages,
                        UpdatedOn = book.UpdatedOn,
                        Category = book.Category,
                        LanguageID = book.LanguageID
                    });

                }

                return books;

            }

            return null;
        }
        public async Task<BookModel> GetSingleBook(int bookID)
        {
            var book = await _Context.Books.FindAsync(bookID);

            if (book != null)
            {
                var bookDetail = new BookModel() {
                    BookID=book.BookID,
                    Author = book.Author,
                    CreatedOn = book.CreatedOn,
                    Description = book.Description,
                    Title = book.Title,
                    TotalPages = book.TotalPages,
                    UpdatedOn = book.UpdatedOn,
                    Category = book.Category,
                    LanguageID = book.LanguageID

                };

                return bookDetail;
            }

            return null;

        }
        public List<BookModel> SearchBook(string Title, string Author)
        {
            return null ;
        }

        

    }
}
