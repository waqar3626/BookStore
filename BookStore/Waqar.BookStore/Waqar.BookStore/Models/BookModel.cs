using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Waqar.BookStore.Enums;
using Waqar.BookStore.Data;

namespace Waqar.BookStore.Models
{
    public class BookModel
    {
        public int BookID { get; set; }

        [Required(ErrorMessage = "Please provide a valid Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please provide a valid Author")]

        public string Author { get; set; }

        [Required(ErrorMessage = "Please provide a valid Description")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Please provide a valid Category")]

        public string Category { get; set; }
       
        [Required(ErrorMessage = "Please provide a valid Language")]
        public int LanguageID { get; set; }
        [Required(ErrorMessage = "Please provide a valid Total Pages")]

        public int TotalPages { get; set; }
        
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

       
    }
}
