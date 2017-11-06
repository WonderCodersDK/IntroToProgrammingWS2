using System.Collections.Generic;
using System.Text;

namespace library
{
    public class Library 
    {
        public List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public Library(List<Book> books) {
            Books = books;
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            foreach(var book in Books) 
            {
                output.AppendLine(book.ToString());
            }

            return output.ToString();
        }
    }
}