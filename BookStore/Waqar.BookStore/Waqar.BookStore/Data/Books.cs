using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Waqar.BookStore.Data
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }

        public int LanguageID { get; set; }

        

        public int TotalPages { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public Languages Language { get; set; }

        
    }
}
