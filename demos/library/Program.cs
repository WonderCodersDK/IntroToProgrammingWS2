using System;
using System.Collections.Generic;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            // Genres
            var fantasy = new Genre("Fantasy");
            var adventure = new Genre("Adventure");

            var genres1 = new List<Genre>();
            genres1.Add(fantasy);

            var genres2 = new List<Genre>();
            genres2.Add(fantasy);
            genres2.Add(adventure);

            // Books
            var book1 = new Book(1, "Harry Potter", "J. K. Rowling", genres1, 5.00);
            var book2 = new Book(2, "Lord of the rings", "J. R. R. Tolken", genres2, 10.00);

            // Our Librady
            var books = new List<Book>();
            books.Add(book1);
            books.Add(book2);

            var library = new Library(books);

            Console.WriteLine(library.ToString());
        }
    }
}