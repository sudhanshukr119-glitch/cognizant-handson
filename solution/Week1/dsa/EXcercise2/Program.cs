using System;
using Exercise2_EcommerceSearch.Models;
using Exercise2_EcommerceSearch.Services;

namespace Exercise2_EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Keyboard", "Electronics"),
                new Product(102, "Laptop", "Electronics"),
                new Product(103, "Mouse", "Electronics"),
                new Product(104, "Printer", "Electronics"),
                new Product(105, "Speaker", "Electronics")
            };

            SearchService search = new SearchService();

            Console.WriteLine("===== Linear Search =====");

            int linearIndex = search.LinearSearch(products, "Mouse");
            search.DisplayResult(products, linearIndex);

            Console.WriteLine();

            Console.WriteLine("===== Binary Search =====");

            int binaryIndex = search.BinarySearch(products, "Mouse");
            search.DisplayResult(products, binaryIndex);
        }
    }
}