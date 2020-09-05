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
                language = model.language

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
                        language = book.language
                    });

                }

                return books;

            }

            return DataSource();
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
                    language = book.language

                };

                return bookDetail;
            }

            return null;

        }
        public List<BookModel> SearchBook(string Title, string Author)
        {
            return DataSource().Where(x => x.Title.Contains(Title) || x.Author.Contains(Author)).ToList();
        }

        private List<BookModel> DataSource()
        {

            return new List<BookModel>()
      { new BookModel() {BookID=1, Title="Java", Author="Uzair", Description="This is the description of Java Book",Category="Programming",language="English", TotalPages=137 },
      new BookModel() {BookID=2, Title="Azure DevOps", Author="Khalid", Description="This is the description of Azure DevOps Book",Category="DevOps",language="Chinese", TotalPages=432  },
      new BookModel() {BookID=3, Title="Networking", Author="Kashif", Description="This is the description of Networking Book",Category="Network",language="English", TotalPages=543  },
      new BookModel() {BookID=4, Title="Assambly", Author="Ali", Description="This is the description of Assambly Book",Category="Machine Learning",language="English", TotalPages=567  },
      new BookModel() {BookID=5, Title="PHP", Author="Kashif", Description="This is the description of PHP Book",Category="Devolper",language="English", TotalPages=342  },
      new BookModel() {BookID=6, Title=".NET Core MVC ", Author="ishafaq", Description="This is the description of .Net Core MVC Book",Category="Framework",language="English", TotalPages=765  }

      };

        }

    }
}
