using System;
using Exercise6_LibraryManagement.Models;
using Exercise6_LibraryManagement.Services;

namespace Exercise6_LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Books are sorted alphabetically by Title
            Book[] books =
            {
                new Book(101, "Algorithms", "Thomas Cormen"),
                new Book(102, "C Programming", "Dennis Ritchie"),
                new Book(103, "Data Structures", "Seymour Lipschutz"),
                new Book(104, "Java Programming", "Herbert Schildt"),
                new Book(105, "Python Basics", "Eric Matthes")
            };

            LibraryService library = new LibraryService();

            Console.WriteLine("========== LINEAR SEARCH ==========");

            Book book1 = library.LinearSearch(books, "Data Structures");

            if (book1 != null)
                Console.WriteLine(book1);
            else
                Console.WriteLine("Book Not Found.");

            Console.WriteLine();

            Console.WriteLine("========== BINARY SEARCH ==========");

            Book book2 = library.BinarySearch(books, "Data Structures");

            if (book2 != null)
                Console.WriteLine(book2);
            else
                Console.WriteLine("Book Not Found.");
        }
    }
}