using LibraryManagmentProject.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentProject.Repositories
{
    public class BookCopyRepository
    {
        private readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Trust Server Certificate=True";

        public void AddBookCopies(int bookId, int amountOfCopies)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("INSERT INTO BookCopies (BookId) VALUES (@BookId)", connection);
                    command.Parameters.AddWithValue("@BookId", bookId);
                    for (int i = 0; i < amountOfCopies; i++)
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
        }

        public int AmountOfFreeCopies(BookWithCopies book)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var amountOfFreeCopiesCommand = new SqlCommand("SELECT COUNT(*) FROM BookCopies " +
                                "WHERE BookId = @BookId " +
                                "AND UserId IS NULL"
                                , connection);
                    amountOfFreeCopiesCommand.Parameters.AddWithValue("@BookId", book.BookId);
                    return (int)amountOfFreeCopiesCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void DeleteCertainAmountOfCopies(BookWithCopies book, int diffOfCopies)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var deleteCopiesCommand = new SqlCommand("DELETE TOP (@DiffOfCopies) FROM BookCopies " +
                                "WHERE BookId = @BookId AND UserId IS NULL", connection);
                deleteCopiesCommand.Parameters.AddWithValue("@DiffOfCopies", diffOfCopies);
                deleteCopiesCommand.Parameters.AddWithValue("@BookId", book.BookId);
                deleteCopiesCommand.ExecuteNonQuery();
            }
        }

        public void DeleteAllBookCopies(int bookId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var deleteAllBookCopiesCommand = new SqlCommand("DELETE FROM BookCopies WHERE BookId = @BookId", connection);
                deleteAllBookCopiesCommand.Parameters.AddWithValue("@BookId", bookId);
                deleteAllBookCopiesCommand.ExecuteNonQuery();
            }
        }

        public void updateBookCopies(int bookId, int amountOfCopies, int userId, DateTime returnDate)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var updateCommand = new SqlCommand("UPDATE TOP (@AmountOfCopies) BookCopies " +
                        "SET UserId = @userId, " +
                        "BorrowedDate = GETDATE(), " +
                        "ReturnDate = @returnDate " +
                        "WHERE BookId = @BookId " +
                        "AND UserId IS NULL", connection);
                    updateCommand.Parameters.AddWithValue("@BookId", bookId);
                    updateCommand.Parameters.AddWithValue("@userId", userId);
                    updateCommand.Parameters.AddWithValue("@returnDate", returnDate);
                    updateCommand.Parameters.AddWithValue("@AmountOfCopies", amountOfCopies);
                    updateCommand.ExecuteNonQuery();
                   
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
        }
        public void ReturnBook(int copyId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var returnCommand = new SqlCommand("UPDATE BookCopies " +
                        "SET UserId = NULL, " +
                        "BorrowedDate = NULL, " +
                        "ReturnDate = NULL " +
                        "WHERE CopyId = @CopyId", connection);
                    returnCommand.Parameters.AddWithValue("@CopyId", copyId);
                    returnCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
        }
    }


}
