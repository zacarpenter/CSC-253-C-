using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_LINQ_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> bookList = new List<Book>() {
            new Book() { ISBN = "90202101", Title = "Chamber of Secrets", Author = "Rowling", Pages = 328, CategoryID = 1 } ,
            new Book() { ISBN = "34812346", Title = "A Brief History of Time", Author = "Hawking", Pages = 310, CategoryID = 3 } ,
            new Book() { ISBN = "45634631", Title = "The Road Less Traveled", Author = "Peck", Pages = 175, CategoryID = 4 },
            new Book() { ISBN = "89101202", Title = "Where the Wild Things Are", Author = "Sendak", Pages = 333, CategoryID = 1 } ,
            new Book() { ISBN = "30203032", Title = "It", Author = "King", Pages = 390, CategoryID = 2 } ,
            new Book() { ISBN = "50235488", Title = "A Man on the Moon", Author = "Chaikin", Pages = 212, CategoryID = 3 } ,
            new Book() { ISBN = "87240402", Title = "Dracula", Author = "Stoker", Pages = 287, CategoryID = 2 } ,
            new Book() { ISBN = "58019199", Title = "The Four Agreements", Author = "Ruiz", Pages = 410, CategoryID = 4 }
            };

            List<Category> categoryList = new List<Category>() {
            new Category(){ CategoryID = 1, CategoryName="Children"},
            new Category(){ CategoryID = 2, CategoryName="Horror"},
            new Category(){ CategoryID = 3, CategoryName="Non Fiction"},
            new Category(){ CategoryID = 4, CategoryName="Self Help"}
            };

            // 1. Display title where pages are greater than 300 and category is 3 or 4 (greater than 2)

            var titleByPagesCat = bookList.Where(p => p.Pages > 300)
                                .Select(p => p)
                                .Where(ct => ct.CategoryID > 2)
                                .Select(p => p.Title);
            Console.WriteLine("Titles in Categories 3 and 4 with more than 300 pages:\n");

            foreach (var title in titleByPagesCat)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine("--------------------------");
            Console.ReadLine();

            // 2. Display title of all books between 300 - 400 pages

            var titleBetweenPages = from t in bookList
                                    where t.Pages > 300 && t.Pages < 400
                                    select new { Title = t.Title };

            Console.WriteLine("Titles of all books between 300 - 400 pages:\n");
            titleBetweenPages.ToList().ForEach(t => Console.WriteLine(t.Title));
            
            Console.WriteLine("--------------------------");
            Console.ReadLine();

            // 3. Display ISBN, title, author, pages of books order by ISBN

            var orderBy = from b in bookList
                          orderby b.ISBN
                          select new
                          {
                              ISBN = b.ISBN,
                              Title = b.Title,
                              Author = b.Author,
                              Pages = b.Pages,
                          };
            Console.WriteLine("Books ordered by ISBN:\n");
            orderBy.ToList().ForEach(b => Console.WriteLine("ISBN: {0}, Title: {1}, Author: {2}, Pages: {3}", b.ISBN, b.Title, b.Author, b.Pages));

            Console.WriteLine("--------------------------");
            Console.ReadLine();

            // 4. Display ISBN, title, author, pages of books order by category ID and title

            var orderByIDTitle = from b in bookList
                          orderby b.CategoryID, b.Title
                          select new
                          {
                              ISBN = b.ISBN,
                              Title = b.Title,
                              Author = b.Author,
                              Pages = b.Pages,
                          };
            Console.WriteLine("Books ordered by Category ID and Title:\n");
            orderByIDTitle.ToList().ForEach(b => Console.WriteLine("ISBN: {0}, Title: {1}, Author: {2}, Pages: {3}", b.ISBN, b.Title, b.Author, b.Pages));

            Console.WriteLine("--------------------------");
            Console.ReadLine();

            // 5. Display groups and titles of different categories

            var groups = from g in bookList
                         group g by g.CategoryID into gg
                         orderby gg.Key
                         select new { gg.Key, gg };

            Console.WriteLine("List of Titles grouped by Category ID:\n");
            foreach (var group in groups)
            {
                Console.WriteLine("Category ID {0}:", group.Key);

                group.gg.ToList().ForEach(a => Console.WriteLine(a.Title));

                Console.WriteLine("\n");
            }

            Console.WriteLine("--------------------------");
            Console.ReadLine();

            // 6. Use left outer join to group categories but with category descriptions

            var groupCatDesc = from cat in categoryList
                               join c in bookList
                               on cat.CategoryID equals c.CategoryID
                                    into cg
                               select new
                               {
                                   CategoryName = cat.CategoryName,
                                   Title = cg
                               };

            Console.WriteLine("Outer Join Category Descriptions:\n");
            foreach (var group in groupCatDesc)
            {
                Console.WriteLine(group.CategoryName + ":");

                group.Title.ToList().ForEach(t => Console.WriteLine(t.Title));

                Console.WriteLine("\n");
            }

            Console.WriteLine("--------------------------");
            Console.ReadLine();

            // 7. Use inner join to display titles and categories

            var titleCategory = from t in bookList
                                join cat in categoryList
                                on t.CategoryID equals cat.CategoryID
                                select new
                                {
                                    Title = t.Title,
                                    Category = cat.CategoryName
                                };

            Console.WriteLine("Inner join displaying titles and categories:\n");
            titleCategory.ToList().ForEach(t => Console.WriteLine("{0} is in the {1} book category.", t.Title, t.Category));

            Console.WriteLine("--------------------------");
            Console.ReadLine();


        } // end main
    } // end class

    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CategoryID { get; set; }
    } // end class

    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    } // end class
} // end namespace