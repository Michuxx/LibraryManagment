using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentProject.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public int YearOfPublication { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        // Constructor
        public Book()
        {
            
        }

        
    }
}
