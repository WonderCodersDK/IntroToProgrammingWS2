using System.Collections.Generic;

namespace library
{
    public class Book
    {
        #region Properties
        public long Number;
        public string Title;
        public string Author;
        public List<Genre> Genres;
        public double Price;
        #endregion

        #region Constructors
        public Book()
        {
            Number = 0;
            Price = 0.00;
            Title = string.Empty;
            Author = string.Empty;
            Genres = new List<Genre>();  
        }

        public Book(long number, string title, string author, List<Genre> genres, double price) 
        {
            Number = number;
            Title = title;
            Author = author;
            Genres = genres;
            Price = price;
        }
        #endregion

        #region Methods
        public override string ToString() {
            return string.Format("{0}: {1}, by {2} with price {3}",
                Number, Title, Author, Price);
        }
        #endregion
    }
}