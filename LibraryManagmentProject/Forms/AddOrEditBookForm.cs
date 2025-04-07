using LibraryManagmentProject.Models;
using LibraryManagmentProject.Repositories;
using LibraryManagmentProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentProject
{
    public partial class AddOrEditBookForm : Form
    {
        BookRepository bookRepository;
        BookCopyRepository bookCopyRepository;
        BookService bookService = new();

        public AddOrEditBookForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }



        private int bookId = 0; // Assuming 0 for new book, as it will be auto-incremented in the database
        public void EditBookData(BookWithCopies book)
        {
            titleText.Text = "Editing Book with id = " + book.BookId;
            AddNewBookButton.Text = "Edit Book";

            tbTitle.Text = book.BookTitle;
            tbAuthor.Text = book.AuthorName;
            thPb.Text = book.YearOfPublication.ToString();
            tbGenre.Text = book.Genre;
            tbIsbn.Text = book.ISBN;
            amountOfCopiesInput.Text = book.Copies.ToString();

            this.bookId = book.BookId;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                BookId = this.bookId,
                BookTitle = tbTitle.Text,
                AuthorName = tbAuthor.Text,
                YearOfPublication = int.Parse(thPb.Text),
                Genre = tbGenre.Text,
                ISBN = tbIsbn.Text
            };


            if (this.bookId != 0)
            {
                // Edit existing book
                BookWithCopies bookWithCopies = new BookWithCopies
                {
                    BookId = this.bookId,
                    BookTitle = tbTitle.Text,
                    AuthorName = tbAuthor.Text,
                    YearOfPublication = int.Parse(thPb.Text),
                    Genre = tbGenre.Text,
                    ISBN = tbIsbn.Text,
                    Copies = int.Parse(amountOfCopiesInput.Text)
                };
                bookService.UpdateBook(bookWithCopies);
            }
            else
            {
                // Add new book
                int amount = int.Parse(amountOfCopiesInput.Text);
                bookService.AddBooks(book, amount);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddOrEditBookForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
