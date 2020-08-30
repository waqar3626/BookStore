using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waqar.BookStore.Models;

namespace Waqar.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBook() {

            return DataSource();
        }
        public BookModel GetSingleBook(int bookID)
        {
           return DataSource().Where(x => x.BookID == bookID).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string Title, string Author)
        {
            return DataSource().Where(x => x.Title.Contains(Title) || x.Author.Contains(Author)).ToList();
        }

        private List<BookModel> DataSource() {

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
