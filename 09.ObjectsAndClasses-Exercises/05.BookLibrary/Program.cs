using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;

namespace _05.BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }

        public static Book Parse(string author, string title, string publisher, DateTime releaseDate, int isbn, double price)
        {
            Book book = new Book
            {
                Author = author,
                Title = title,
                Publisher = publisher,
                ISBN = isbn,
                Price = price,
                ReleaseDate = releaseDate
            };
            return book;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library dimchosLibrary = new Library
            {
                Name = "Dimcho's Library",
                Books = ReadBooks()
            };
            Dictionary<string, double> booksInfo = new Dictionary<string, double>();
            foreach (Book dimchoLibrary in dimchosLibrary.Books)
            {
                if (! booksInfo.ContainsKey(dimchoLibrary.Author))
                {
                    booksInfo[dimchoLibrary.Author] = 0d;
                }
                booksInfo[dimchoLibrary.Author] += dimchoLibrary.Price;
            }

            foreach (KeyValuePair<string, double> authorBookPair in booksInfo.OrderByDescending(p => p.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{authorBookPair.Key} -> {authorBookPair.Value:f2}");
            }
        }

        private static List<Book> ReadBooks()
        {
            List<Book> bookList = new List<Book>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime date = DateTime.ParseExact(tokens[3], $"dd.MM.yyyy", CultureInfo.InvariantCulture);
                int isbn = int.Parse(tokens[4]);
                double price = double.Parse(tokens[5]);

                bookList.Add(Book.Parse(author, title, publisher, date, isbn, price));
            }
            return bookList;
        }
    }
}
