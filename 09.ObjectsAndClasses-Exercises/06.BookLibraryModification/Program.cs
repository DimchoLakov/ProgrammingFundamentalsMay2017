using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.BookLibraryModification
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
        public int Isbn { get; set; }
        public double Price { get; set; }

        public static Book Parse(string author, string title, string publisher, DateTime releaseDate, int isbn, double price)
        {
            Book book = new Book
            {
                Author = author,
                Title = title,
                Publisher = publisher,
                Isbn = isbn,
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

            DateTime afterDate = DateTime.ParseExact(Console.ReadLine(), $"dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (Book dimchoLibrary in dimchosLibrary.Books.Where(x => x.ReleaseDate > afterDate)
                .OrderBy(d => d.ReleaseDate).ThenBy(t => t.Title))
            {
                Console.WriteLine($"{dimchoLibrary.Title} -> {dimchoLibrary.ReleaseDate.ToString($"dd.MM.yyyy")}");
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
