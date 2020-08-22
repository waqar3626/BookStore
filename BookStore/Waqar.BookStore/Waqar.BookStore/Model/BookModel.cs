using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Waqar.BookStore.Model
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
