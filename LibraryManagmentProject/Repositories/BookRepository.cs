using LibraryManagmentProject.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentProject.Repositories
{
    public class BookRepository
    {
        private readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Trust Server Certificate=True";

        public List<Book> GetBooks()
        {
            var books = new List<Book>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT * FROM Books", connection);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book();

                            book.BookId = reader.GetInt32(0);
                            book.BookTitle = reader.GetString(1);
                            book.AuthorName = reader.GetString(2);
                            book.YearOfPublication = reader.GetInt32(3);
                            book.Genre = reader.GetString(4);
                            book.ISBN = reader.GetString(5);

                            books.Add(book);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

            return books;
        }

        public Book GetBook(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT * FROM Books WHERE BookId = @BookId", connection);
                    command.Parameters.AddWithValue("@BookId", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Book book = new Book();
                            book.BookId = reader.GetInt32(0);
                            book.BookTitle = reader.GetString(1);
                            book.AuthorName = reader.GetString(2);
                            book.YearOfPublication = reader.GetInt32(3);
                            book.Genre = reader.GetString(4);
                            book.ISBN = reader.GetString(5);
                            return book;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }


        public int AddBook(Book book)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("INSERT INTO Books (Title, Author, PublishedYear, Genre, ISBN) OUTPUT Inserted.BookID " +
                        "VALUES (@BookTitle, @AuthorName, @YearOfPublication, @Genre, @ISBN)", connection);
                    command.Parameters.AddWithValue("@BookTitle", book.BookTitle);
                    command.Parameters.AddWithValue("@AuthorName", book.AuthorName);
                    command.Parameters.AddWithValue("@YearOfPublication", book.YearOfPublication);
                    command.Parameters.AddWithValue("@Genre", book.Genre);
                    command.Parameters.AddWithValue("@ISBN", book.ISBN);
                    return (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public void UpdateBookWithoutCopies(BookWithCopies book)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("UPDATE Books SET Title = @BookTitle, Author = @AuthorName, " +
                        "PublishedYear = @YearOfPublication, Genre = @Genre, ISBN = @ISBN WHERE BookId = @BookId", connection);
                    command.Parameters.AddWithValue("@BookId", book.BookId);
                    command.Parameters.AddWithValue("@BookTitle", book.BookTitle);
                    command.Parameters.AddWithValue("@AuthorName", book.AuthorName);
                    command.Parameters.AddWithValue("@YearOfPublication", book.YearOfPublication);
                    command.Parameters.AddWithValue("@Genre", book.Genre);
                    command.Parameters.AddWithValue("@ISBN", book.ISBN);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
        }

        public BookWithCopies? GetBookWithCopies(int bookId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(
                        "SELECT " +
                        "Books.BookID, " +
                        "Books.Title, " +
                        "Books.Author, " +
                        "Books.PublishedYear, " +
                        "Books.Genre, " +
                        "Books.ISBN, " +
                        "Count(BookCopies.CopyID) " +
                        "FROM Books " +
                        "LEFT JOIN BookCopies ON Books.BookID = BookCopies.BookID " +
                        "AND BookCopies.UserId IS NULL " +
                        "WHERE Books.BookID = @BookId " +
                        "GROUP BY " +
                        "Books.BookID, Books.Title, Books.Author, Books.PublishedYear, Books.Genre, Books.ISBN",
                        connection);
                    command.Parameters.AddWithValue("@BookId", bookId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            BookWithCopies bookWithCopies = new BookWithCopies()
                            {
                                BookId = reader.GetInt32(0),
                                BookTitle = reader.GetString(1),
                                AuthorName = reader.GetString(2),
                                YearOfPublication = reader.GetInt32(3),
                                Genre = reader.GetString(4),
                                ISBN = reader.GetString(5),
                                Copies = reader.GetInt32(6)
                            };

                            return bookWithCopies;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public List<BookWithCopies> GetBooksWithCopies()
        {
            var booksWithCopies = new List<BookWithCopies>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(
                        "SELECT " +
                        "Books.BookID, " +
                        "Books.Title, " +
                        "Books.Author, " +
                        "Books.PublishedYear, " +
                        "Books.Genre, " +
                        "Books.ISBN, " +
                        "Count(BookCopies.CopyID) " +
                        "FROM Books " +
                        "LEFT JOIN BookCopies ON Books.BookID = BookCopies.BookID " +
                        "AND BookCopies.UserId IS NULL " + 
                        "GROUP BY " +
                        "Books.BookID, Books.Title, Books.Author, Books.PublishedYear, Books.Genre, Books.ISBN",
                        connection);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BookWithCopies bookWithCopies = new BookWithCopies()
                            {
                                BookId = reader.GetInt32(0),
                                BookTitle = reader.GetString(1),
                                AuthorName = reader.GetString(2),
                                YearOfPublication = reader.GetInt32(3),
                                Genre = reader.GetString(4),
                                ISBN = reader.GetString(5),
                                Copies = reader.GetInt32(6)
                            };

                            booksWithCopies.Add(bookWithCopies);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

            return booksWithCopies;
        }



        public void DeleteBook(int bookId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("DELETE FROM Books WHERE BookId = @BookId", connection);
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.ExecuteNonQuery();
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

