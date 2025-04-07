using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentProject.Models
{
    public class BookWithCopies : Book
    {
        public int Copies { get; set; }
        public BookWithCopies()
        {
            
        }
        
    }
}
