using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>()
            {
                new Book() { ISBN="1234-45-34-3939", Title = "The Long Road", Publisher="New York", Price=25.00, Copyright=2016 },

                new Book() { ISBN="988-65-34-9012", Title = "The Warrior", Publisher="McGraw", Price=55.00, Copyright=2013 },

                new Book() { ISBN="8712-45-84-2539", Title = "Yesterday", Publisher="New York", Price=67.00, Copyright=2016 },

                new Book() { ISBN="1234-78-99-3478", Title = "Programming Essentials", Publisher="Dalton", Price=35.00, Copyright=2015 },

                new Book() { ISBN="8356-89-33-3251", Title = "Hello World", Publisher="Chicago Press", Price=115.00, Copyright=2016 }
            };

            // #1 Display ISBN, Title, Publisher for all books where Publisher is New York
            var publishedNY = bookList.Where(x => x.Publisher == "New York");
            foreach (var books in publishedNY)
            {
                Console.WriteLine("ISBN: {0} -- {1} is published by: {2}", books.ISBN, books.Title, books.Publisher);
            }

            // #2 Display all fields for all books in descending order by Copyright
            var descending = bookList.OrderByDescending(x => x.Copyright);
            Console.WriteLine("------------------------------------------------------------");
            foreach (var books in descending)
            {
                Console.WriteLine("{0} {1} {2} {3:C} {4}", books.ISBN, books.Title, books.Publisher, books.Price, books.Copyright);
            }

            // #3 Display all fields for all books in descending order by Copyright Where Publisher is New York
            var descending2 = bookList.OrderByDescending(x => x.Copyright).Where(x => x.Publisher == "New York");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var books in descending2)
            {
                Console.WriteLine("{0} {1} {2} {3:C} {4}", books.ISBN, books.Title, books.Publisher, books.Price, books.Copyright);
            }

            // #4 Display ISBN, Title for all books with copyright greater than 2015
            var copyright2015 = bookList.Where(x => x.Copyright > 2015);
            Console.WriteLine("------------------------------------------------------------");
            foreach (var books in copyright2015)
            {
                Console.WriteLine("{0} {1}", books.ISBN, books.Title);
            }

            // #5 Order the list in descending order by Title and display the ISBN, Title of the first book in the list  
            var descending3 = bookList.OrderByDescending(x => x.Title).First();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0} {1}", descending3.ISBN, descending3.Title);


            // #6 Use LINQ to calculate the sum of the price for all books and display average cost
            double sum = bookList.Sum(x => x.Price);
            double average = bookList.Average(x => x.Price);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Sum: {0:C}", sum);
            Console.WriteLine("Average: {0:C}", average);

            // #7 Use LINQ to calculate a 3% markup of the price for each book and display the title and markup price
            var markupPrice = from book in bookList
                              select new { newPrice = (book.Price * .03) + book.Price, book.Title };
            Console.WriteLine("------------------------------------------------------------");
            foreach (var book in markupPrice)
            {
                Console.WriteLine("Markup price: {0:C} for {1}", book.newPrice, book.Title);
            }

            // Pause
            Console.ReadLine();

        } // end Main
    } // end class

    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public int Copyright { get; set; }
    } // end class Book

} // end namespace
