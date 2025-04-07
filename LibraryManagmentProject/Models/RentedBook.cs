using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentProject.Models
{
    public class RentedBook
    {
        public int BookId { get; set; }
        public int CopyId { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public RentedBook()
        {

        }
    }
}
