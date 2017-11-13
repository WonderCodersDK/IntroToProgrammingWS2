using System.Collections.Generic;

namespace bookstore
{
    public class Book
    {
        #region Properties
        public int YearOfPublish;
        public string Title;
        public string Author;
        public double Price;
        public string Publisher;
        #endregion

        #region Constructors
        public Book()
        {
            YearOfPublish = 0;
            Price = 0.00;
            Title = "";
            Author = "Unknown";
            Publisher = "Unknown";  
        }

        public Book(int year, string title, string author, string publisher, double price) 
        {
            YearOfPublish = year;
            Title = title;
            Author = author;
            Publisher= publisher;
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