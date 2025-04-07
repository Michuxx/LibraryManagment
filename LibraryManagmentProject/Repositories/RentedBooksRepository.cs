using LibraryManagmentProject.Models;
using Microsoft.Data.SqlClient;

namespace LibraryManagmentProject.Repositories
{
    public class RentedBooksRepository
    {
        private readonly string connectionString;
        public RentedBooksRepository()
        {
            SQLCONNECT sqlConnect = new SQLCONNECT();
            connectionString = sqlConnect.connectionString;

        }
        public List<RentedBook> RentedBooks(int id)
        {
            var rentedBooks = new List<RentedBook>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var rentedBooksCommand = new SqlCommand(
                    "SELECT " +
                    "Books.BookId, " +
                    "BookCopies.CopyId, " + // Added missing comma
                    "Books.Title, " +
                    "Books.Author, " +
                    "Books.Genre, " +
                    "Books.ISBN, " +
                    "BookCopies.BorrowedDate, " +
                    "BookCopies.ReturnDate " +
                    "FROM BookCopies " +
                    "INNER JOIN Books " + // Added missing space
                    "ON BookCopies.BookId = Books.BookID " + // Fixed table name typo
                    "WHERE UserId = @UserId", connection);
                    rentedBooksCommand.Parameters.AddWithValue("@UserId", id);


                    using (var reader = rentedBooksCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentedBook rentedBook = new RentedBook()
                            {
                                BookId = reader.GetInt32(0),
                                CopyId = reader.GetInt32(1),
                                BookTitle = reader.GetString(2),
                                AuthorName = reader.GetString(3),
                                Genre = reader.GetString(4),
                                ISBN = reader.GetString(5),
                                BorrowedDate = reader.GetDateTime(6),
                                ReturnDate = reader.GetDateTime(7)
                            };

                            rentedBooks.Add(rentedBook);
                        }
                    }
                    return rentedBooks;
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
                return rentedBooks;
            }
        }
    }
}
