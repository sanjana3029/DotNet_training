using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Books
    {
        public string BookName;
        public string AuthorName;

        public Books(string Bname, string Aname)
        {
            BookName = Bname;
            AuthorName = Aname;
        }

        public void Display()
        {
            Console.WriteLine($"BOOKNAME:{BookName} and AUTHORNAME: {AuthorName}");

        }
    }
    public class BookSelf
    {

        private Books[] book = new Books[5];
        public Books this[int index]
        {
            get { return book[index]; }
            set { book[index] = value; }
        }
    }

    class BookBook
    {


        static void Main(string[] args)
        {
            var BookSelf = new BookSelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"enter the Book {i + 1} Name:");
                string BookName = Console.ReadLine();
                Console.WriteLine($"enter the Author {i + 1} Name");
                string AuthorName = Console.ReadLine();

                var book = new Books(BookName, AuthorName);
                BookSelf[i] = book;
            }

            //Console.WriteLine("\nBook Details:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nBook {i + 1}:");
                BookSelf[i].Display();

                Console.Read();
            }

        }
    }
}
