using System.Collections.Generic;
using System.Text;

namespace bookstore
{
    public class Bookstore
    {
        public List<Book> Books;

        public Bookstore()
        {
            Books = new List<Book>();
        }

        public Bookstore(List<Book> books) {
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