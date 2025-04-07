using LibraryManagmentProject.Models;
using LibraryManagmentProject.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentProject.Services
{
    public class BookService
    {
        private readonly BookRepository bookRepository;
        private readonly BookCopyRepository bookCopyRepository;
        private readonly RentedBooksRepository rentedBooksRepository;


        public BookService()
        {
            bookRepository = new BookRepository();
            bookCopyRepository = new BookCopyRepository();
            rentedBooksRepository = new RentedBooksRepository();
        }

        public void AddBooks(Book book, int amount)
        {
            var newBookID = bookRepository.AddBook(book);
            bookCopyRepository.AddBookCopies(newBookID, amount);
        }

        public void CreateRentedBooksTable(int id, DataGridView booksTable)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("BookId", typeof(int));
            dt.Columns.Add("RentedBookId", typeof(int));
            dt.Columns.Add("BookTitle", typeof(string));
            dt.Columns.Add("AuthorName", typeof(string));
            dt.Columns.Add("Genre", typeof(string));
            dt.Columns.Add("ISBN", typeof(string));
            dt.Columns.Add("BorrowedDate", typeof(DateTime));
            dt.Columns.Add("WhenToReturn", typeof(DateTime));

            var rentedBooks = rentedBooksRepository.RentedBooks(id);

            foreach (var book in rentedBooks)
            {
                dt.Rows.Add(book.BookId, book.CopyId, book.BookTitle, book.AuthorName, book.Genre, book.ISBN, book.BorrowedDate.Date, book.ReturnDate.Date);
            }

            booksTable.DataSource = dt;
        }

        public void CreateBooksTable(DataGridView booksTable)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("BookId", typeof(int));
            dt.Columns.Add("BookTitle", typeof(string));
            dt.Columns.Add("AuthorName", typeof(string));
            dt.Columns.Add("YearOfPublication", typeof(int));
            dt.Columns.Add("Genre", typeof(string));
            dt.Columns.Add("ISBN", typeof(string));
            dt.Columns.Add("Copies", typeof(int));


            var books = bookRepository.GetBooksWithCopies();


            foreach (var book in books)
            {
                dt.Rows.Add(book.BookId, book.BookTitle, book.AuthorName, book.YearOfPublication, book.Genre, book.ISBN, book.Copies);
            }

            booksTable.DataSource = dt;
        }



        public void UpdateBook(BookWithCopies book)
        {
            try
            {
                bookRepository.UpdateBookWithoutCopies(book);
                int amountOfFreeCopies = bookCopyRepository.AmountOfFreeCopies(book);
                int diffOfCopies = book.Copies - amountOfFreeCopies;
                if (book.Copies > amountOfFreeCopies)
                {
                    bookCopyRepository.AddBookCopies(book.BookId, diffOfCopies);
                }
                else if (book.Copies == 0)
                {
                    bookCopyRepository.DeleteAllBookCopies(book.BookId);

                }
                else if (book.Copies == amountOfFreeCopies || book.Copies < 0)
                {
                    return;
                }
                else
                {
                    diffOfCopies = Math.Abs(diffOfCopies);
                    bookCopyRepository.DeleteCertainAmountOfCopies(book, diffOfCopies);
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
        }

        public void FilterTable(DataTable booksTable, string searchCriteria, string searchValue)
        {
            if (booksTable != null)
            {
                DataColumn column = booksTable.Columns[searchCriteria];
                if (column.DataType == typeof(string))
                {
                    booksTable.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", searchCriteria, searchValue);
                }
                else if (column.DataType == typeof(int))
                {
                    if (int.TryParse(searchValue, out int intValue))
                    {
                        booksTable.DefaultView.RowFilter = string.Format("{0} = {1}", searchCriteria, intValue);
                    }
                    else
                    {
                        booksTable.DefaultView.RowFilter = string.Empty;
                    }
                }
                else if (column.DataType == typeof(DateTime))
                {
                    booksTable.DefaultView.RowFilter = string.Format("CONVERT({0}, System.String) LIKE '%", searchCriteria) + searchValue + "%'";
                }
                else
                {
                    booksTable.DefaultView.RowFilter = string.Empty;
                }
            }
        }
    }
}
