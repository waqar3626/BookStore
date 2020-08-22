using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waqar.BookStore.Model;

namespace Waqar.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBook() {

            return DataSource();
        }
        public BookModel GetSingleBook(int BookID)
        {
            return DataSource().Where(x => x.BookID == BookID).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string Title, string Author)
        {
            return DataSource().Where(x => x.Title.Contains(Title) || x.Author.Contains(Author)).ToList();
        }

        private List<BookModel> DataSource() {

            return new List<BookModel>()
      { new BookModel() {BookID=1, Title="Java", Author="Uzair" },
      new BookModel() {BookID=2, Title="C++", Author="Khalid" },
      new BookModel() {BookID=3, Title="Networking", Author="Kashif" },
      new BookModel() {BookID=4, Title="Assambly", Author="Ali" }

      };
        
        }

    }
}
