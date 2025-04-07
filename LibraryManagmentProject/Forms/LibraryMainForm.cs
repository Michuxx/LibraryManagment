using LibraryManagmentProject.Forms;
using LibraryManagmentProject.Models;
using LibraryManagmentProject.Repositories;
using LibraryManagmentProject.Services;
using Microsoft.IdentityModel.Logging;
using System.Data;
using System.Globalization;

namespace LibraryManagmentProject
{
    public partial class LibraryMainForm : Form
    {
        private User loggedUser;
        BookRepository bookRepository = new BookRepository();
        BookCopyRepository bookCopyRepository = new BookCopyRepository();
        BookService bookService = new BookService();


        public LibraryMainForm(User user)
        {
            InitializeComponent();
            loggedUser = user;
            welcomeLabel.Text = "Welcome " + loggedUser.UserName;
            SearchCriteria();
            ReadBooks();
        }

        private void SearchCriteria()
        {
            if (!showRented.Checked)
            {
                searchComboBox.Items.Clear();
                searchComboBox.Items.Add("BookId");
                searchComboBox.Items.Add("BookTitle");
                searchComboBox.Items.Add("AuthorName");
                searchComboBox.Items.Add("YearOfPublication");
                searchComboBox.Items.Add("Genre");
                searchComboBox.Items.Add("ISBN");
                searchComboBox.Items.Add("Copies");
                searchComboBox.SelectedIndex = 0;
            }
            else
            {
                searchComboBox.Items.Clear();
                searchComboBox.Items.Add("BookId");
                searchComboBox.Items.Add("RentedBookId");
                searchComboBox.Items.Add("BookTitle");
                searchComboBox.Items.Add("AuthorName");
                searchComboBox.Items.Add("Genre");
                searchComboBox.Items.Add("ISBN");
                searchComboBox.Items.Add("BorrowedDate");
                searchComboBox.Items.Add("WhenToReturn");
                searchComboBox.SelectedIndex = 0;
            }
        }

        private void ReadBooks()
        {
            bookService.CreateBooksTable(this.booksTable);
        }

        private void editBookButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                var bookEntity = this.booksTable.SelectedRows[0].Cells[0].Value.ToString();

                if (bookEntity != null || bookEntity.Length != 0)
                {
                    var bookId = int.Parse(bookEntity);
                    var book = bookRepository.GetBookWithCopies(bookId);
                    if (book == null) return;

                    AddOrEditBookForm addOrEditBookForm = new AddOrEditBookForm();
                    addOrEditBookForm.EditBookData(book);

                    if (addOrEditBookForm.ShowDialog() == DialogResult.OK)
                    {
                        if (showRented.Checked)
                        {
                            showRented.Checked = false;
                        }
                        else
                        {
                            ReadBooks();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to Edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a book to Edit.");
                return;
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddOrEditBookForm addNewBookForm = new AddOrEditBookForm();
            if (addNewBookForm.ShowDialog() == DialogResult.OK)
            {
                if (showRented.Checked)
                {
                    showRented.Checked = false;
                }
                else
                {
                    ReadBooks();
                }
            }
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            var bookEntity = this.booksTable.SelectedRows[0].Cells[0].Value.ToString();

            if (bookEntity != null || bookEntity.Length != 0)
            {
                var bookId = int.Parse(bookEntity);
                bookCopyRepository.DeleteAllBookCopies(bookId);
                bookRepository.DeleteBook(bookId);
                ReadBooks();
            }
            else
            {
                MessageBox.Show("Please select a book to Delete.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Show();
        }

        private void rentBookButton_Click(object sender, EventArgs e)
        {
            var bookEntity = this.booksTable.SelectedRows[0].Cells[0].Value.ToString();
            var bookCopies = int.Parse(this.booksTable.SelectedRows[0].Cells[6].Value.ToString());
            if ((bookEntity != null || bookEntity.Length != 0) && bookCopies != 0)
            {
                var bookId = int.Parse(bookEntity);
                var book = bookRepository.GetBookWithCopies(bookId);

                if (book == null) return;

                RentBookForm rentBookForm = new RentBookForm(book, loggedUser.UserId);

                if (rentBookForm.ShowDialog() == DialogResult.OK)
                {
                    ReadBooks();
                }
            }
            else
            {
                MessageBox.Show("Please select a book with more than 0 copies to Rent.");
            }
        }



        private void showRented_CheckedChanged(object sender, EventArgs e)
        {
            switch (showRented.CheckState)
            {
                case CheckState.Checked:
                    bookService.CreateRentedBooksTable(loggedUser.UserId, this.booksTable);

                    deleteBookButton.Enabled = false;
                    rentBookButton.Enabled = false;
                    returnBookButton.Enabled = true;
                    SearchCriteria();
                    showRented.Text = "Hide your rented Books";
                    break;
                case CheckState.Unchecked:

                    returnBookButton.Enabled = false;
                    rentBookButton.Enabled = true;
                    deleteBookButton.Enabled = true;
                    SearchCriteria();
                    showRented.Text = "Show your rented Books";
                    ReadBooks();
                    break;
                case CheckState.Indeterminate:
                    returnBookButton.Enabled = false;
                    ReadBooks();
                    break;
            }

        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            var rentedBookEntity = this.booksTable.SelectedRows[0].Cells[1].Value.ToString();

            if (rentedBookEntity != null || rentedBookEntity.Length != 0)
            {
                var rentedBookId = int.Parse(rentedBookEntity);

                bookCopyRepository.ReturnBook(rentedBookId);

                bookService.CreateRentedBooksTable(loggedUser.UserId, this.booksTable);
            }
            else
            {
                MessageBox.Show("Please select a book to Delete.");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text;
            string searchCriteria = searchComboBox.SelectedItem.ToString();
            DataTable booksTable = this.booksTable.DataSource as DataTable;

            bookService.FilterTable(booksTable, searchCriteria, searchValue);
        }

    }
}
