using System;
using System.Collections.Generic;

namespace bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Genres
            ///var fantasy = new Genre("Fantasy");
            //var adventure = new Genre("Adventure");

            //var genres1 = new List<Genre>();
            //genres1.Add(fantasy);

            // Books
            var book1 = new Book(1, "Harry Potter", "J. K. Rowling", genres1, 5.00);
            var book2 = new Book(2, "Lord of the rings", "J. R. R. Tolken", genres2, 10.00);

            // Our Librady
            var books = new List<Book>();
            books.Add(book1);
            books.Add(book2);

            var bookstore = new Bookstore(books);

            Console.WriteLine(bookstore.ToString());
        }
    }
}