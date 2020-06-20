using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Book: Item
    {
        public bool returnSrok { get; private set; }
        public string Author { get; set; } 
        public string Title { get; set; } 
        //public string Publisher { get; set; } 
        public Publisher Pub1 { get; set; }
        public int Pages { get; set; } 
        public int Year { get; set; }
        private static double price;
        public static double Price
        {
            get { return price; }
            set { if (value >= 9) price = value; }
        }

        public Book(string author, string title, Publisher Pub, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Pub1 = Pub;
            this.Pages = pages;
            this.Year = year;
        }
        public Book(string author, string title, Publisher Pub, int pages,
            int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.Author = author;
            this.Title = title;
            this.Pub1 = Pub;
            this.Pages = pages;
            this.Year = year;
        }
        public Book() { }
        static Book()
        {
            Price = 9;
        }
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }
        public void SetBook(string author, string title, Publisher Pub, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Pub1 = Pub;
            this.Pages = pages;
            this.Year = year;
        }
        public static void SetPrice(double price)
        {
            Book.Price = price;
        }

        public override string ToString()
        {
            string bs = String.Format("Книга:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}\n Издательство: {5}",
                Author, Title, Year, Pages, Book.price, Pub1.ToString());
            return bs;
        }
        new public void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public override void Return()
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }
    }
}
