using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Model
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public string Publisher { get; set; }

        public int Price { get; set; }

        public Book(string name, string author, string publisher, int price)
        {
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
            this.Price = price;
        }
    }
}
