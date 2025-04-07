using LibraryManagmentProject.Models;
using LibraryManagmentProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentProject.Forms
{
    public partial class RentBookForm : Form
    {
        BookWithCopies book = new BookWithCopies();
        int userId = 0;
        BookCopyRepository bookCopyRepository = new();
        public RentBookForm(BookWithCopies book, int userId)
        {
            InitializeComponent();
            rentNameLabel.Text += book.BookId;
            maxCopies.Text += book.Copies;
            this.book = book;
            this.userId = userId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amountOfCopiesToRent = int.Parse(amountOfCopiesInput.Text);
            if (amountOfCopiesToRent > book.Copies)
            {
                MessageBox.Show("Too much Copies to Rent! Take less");
            }

            DateTime returnDate = returnDatePicker.Value;
            DateTime todayDate = DateTime.Now;
            if (returnDate.Date < todayDate)
            {
                MessageBox.Show("Wrong Date!");
            }
            else
            {
                bookCopyRepository.updateBookCopies(book.BookId, amountOfCopiesToRent, userId, returnDate);
                this.DialogResult = DialogResult.OK;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void maxCopies_Click(object sender, EventArgs e)
        {

        }
    }
}
