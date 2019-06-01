using System;
using System.Linq;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book( string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (char.IsDigit(value.Substring(value.IndexOf(" ") + 1)[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }

                author = value;
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
