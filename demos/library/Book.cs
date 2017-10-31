using System;

namespace library
{
    public class Book
    {
        public int Number { get; set; }
        public string Title { get; set; }

        public Book()
        {
            // do we need to present what an empty constructor is ???
        }

        public Book(int number, string title) 
        {
            Number = number;
            Title = title;
        }
    }
}