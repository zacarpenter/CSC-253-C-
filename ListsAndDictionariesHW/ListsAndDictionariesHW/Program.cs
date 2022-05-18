using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionariesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book() { ISBN = 1234, Author = "George Orwell", Title = "1984", Publisher = "Signet Classics", CopyrightDate = "01/01/1961" };
            Book book2 = new Book() { ISBN = 5678, Author = "Douglas Adams", Title = "The Hitchhikers Guide to the Galaxy", Publisher = "Mass Market Paperback", CopyrightDate = "10/12/1979" };
            Book book3 = new Book() { ISBN = 9111, Author = "George R.R. Martin", Title = "A Game of Thrones", Publisher = "Mass Market Paperback", CopyrightDate = "08/01/1996" };
            Book book4 = new Book() { ISBN = 1213, Author = "Donna Tartt", Title = "The Goldfinch", Publisher = "Random House", CopyrightDate = "07/28/2016" };
            Book book5 = new Book() { ISBN = 1415, Author = "J.K. Rowling", Title = "Harry Potter and the Sorcerer's Stone", Publisher = "Scholastic Press", CopyrightDate = "10/01/1998" };

            // List
            List<Book> bookList = new List<Book>();
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);

            foreach (Book book in bookList)
            {
                Console.WriteLine("ISBN: " + book.ISBN.ToString());
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Publisher: " + book.Publisher);
                Console.WriteLine("Copyright Date: " + book.CopyrightDate);
                Console.WriteLine("-----------------------------------");
            }

            // Pause
            Console.ReadLine();

            // Dictionary
            Dictionary<int, Book> bookDictionary = new Dictionary<int, Book>();
            bookDictionary.Add(book1.ISBN, book1);
            bookDictionary.Add(book2.ISBN, book2);
            bookDictionary.Add(book3.ISBN, book3);
            bookDictionary.Add(book4.ISBN, book4);
            bookDictionary.Add(book5.ISBN, book5);

            foreach (Book book in bookDictionary.Values)
            {
                Console.WriteLine(" ----------------------------------- ");
                Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book.Author, book.Title, book.Publisher, book.CopyrightDate);
                Console.WriteLine(" ----------------------------------- ");
            }

            // SEARCH
            Console.WriteLine("Search for an ISBN: ");
            int isbn = Convert.ToInt32(Console.ReadLine());

            if (bookDictionary.ContainsKey(isbn))
            {
                if (isbn == book1.ISBN)
                {
                    Console.WriteLine(" ----------------------------------- ");
                    Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book1.Author, book1.Title, book1.Publisher, book1.CopyrightDate);
                    Console.WriteLine(" ----------------------------------- ");
                }
                else if (isbn == book2.ISBN)
                {
                    Console.WriteLine(" ----------------------------------- ");
                    Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book2.Author, book2.Title, book2.Publisher, book2.CopyrightDate);
                    Console.WriteLine(" ----------------------------------- ");
                }
                else if (isbn == book3.ISBN)
                {
                    Console.WriteLine(" ----------------------------------- ");
                    Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book3.Author, book3.Title, book3.Publisher, book3.CopyrightDate);
                    Console.WriteLine(" ----------------------------------- ");
                }
                else if (isbn == book4.ISBN)
                {
                    Console.WriteLine(" ----------------------------------- ");
                    Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book4.Author, book4.Title, book4.Publisher, book4.CopyrightDate);
                    Console.WriteLine(" ----------------------------------- ");
                }
                else if (isbn == book5.ISBN)
                {
                    Console.WriteLine(" ----------------------------------- ");
                    Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book5.Author, book5.Title, book5.Publisher, book5.CopyrightDate);
                    Console.WriteLine(" ----------------------------------- ");
                }
            }
            // Mr. Sommerfeldt, how do I error check if someone put in say a string instead of int?
            else 
            {
                Console.WriteLine("ISBN not found.");
            }

            // Pause
            Console.ReadLine();


            // REMOVE
            Console.WriteLine("Remove a book from the list: ");
            int isbnRemove = Convert.ToInt32(Console.ReadLine());

            if (bookDictionary.ContainsKey(isbnRemove))
            {
                if (isbnRemove == book1.ISBN)
                {
                    bookDictionary.Remove(book1.ISBN);

                    foreach (Book book in bookDictionary.Values)
                    {
                        Console.WriteLine(" ----------------------------------- ");
                        Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book.Author, book.Title, book.Publisher, book.CopyrightDate);
                        Console.WriteLine(" ----------------------------------- ");
                    }
                }
                else if (isbnRemove == book2.ISBN)
                {
                    bookDictionary.Remove(book2.ISBN);

                    foreach (Book book in bookDictionary.Values)
                    {
                        Console.WriteLine(" ----------------------------------- ");
                        Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book.Author, book.Title, book.Publisher, book.CopyrightDate);
                        Console.WriteLine(" ----------------------------------- ");
                    }
                }
                else if (isbnRemove == book3.ISBN)
                {
                    bookDictionary.Remove(book3.ISBN);

                    foreach (Book book in bookDictionary.Values)
                    {
                        Console.WriteLine(" ----------------------------------- ");
                        Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book.Author, book.Title, book.Publisher, book.CopyrightDate);
                        Console.WriteLine(" ----------------------------------- ");
                    }
                }
                else if (isbnRemove == book4.ISBN)
                {
                    bookDictionary.Remove(book4.ISBN);

                    foreach (Book book in bookDictionary.Values)
                    {
                        Console.WriteLine(" ----------------------------------- ");
                        Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book.Author, book.Title, book.Publisher, book.CopyrightDate);
                        Console.WriteLine(" ----------------------------------- ");
                    }
                }
                else if (isbnRemove == book5.ISBN)
                {
                    bookDictionary.Remove(book5.ISBN);

                    foreach (Book book in bookDictionary.Values)
                    {
                        Console.WriteLine(" ----------------------------------- ");
                        Console.WriteLine(" Author: {0}\n Title: {1}\n Publisher: {2}\n Copyright Date: {3}", book.Author, book.Title, book.Publisher, book.CopyrightDate);
                        Console.WriteLine(" ----------------------------------- ");
                    }
                }
            }
            else
            {
                Console.WriteLine("ISBN not found.");
            }

            // Pause
            Console.ReadLine();

        } // end Main
    } // end class


    class Book
    {
        public int ISBN { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string CopyrightDate { get; set; }
    } // end class Book

} // end namespace
