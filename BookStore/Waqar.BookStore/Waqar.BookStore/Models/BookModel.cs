using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Waqar.BookStore.Models
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }

        public string language { get; set; }

        public int TotalPages { get; set; }

    }
}
