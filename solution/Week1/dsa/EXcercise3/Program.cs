using System;
using Exercise3_SortingOrders.Models;
using Exercise3_SortingOrders.Services;

namespace Exercise3_SortingOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            Order[] orders =
            {
                new Order(101, "Alice", 5200),
                new Order(102, "Bob", 1200),
                new Order(103, "Charlie", 8900),
                new Order(104, "David", 2500),
                new Order(105, "Emma", 6700)
            };

            SortService sorter = new SortService();

            Console.WriteLine("===== Original Orders =====");
            sorter.Display(orders);

            Console.WriteLine("\n===== Bubble Sort =====");
            sorter.BubbleSort(orders);
            sorter.Display(orders);

            // New array for Quick Sort
            Order[] orders2 =
            {
                new Order(101, "Alice", 5200),
                new Order(102, "Bob", 1200),
                new Order(103, "Charlie", 8900),
                new Order(104, "David", 2500),
                new Order(105, "Emma", 6700)
            };

            Console.WriteLine("\n===== Quick Sort =====");

            sorter.QuickSort(orders2, 0, orders2.Length - 1);

            sorter.Display(orders2);
        }
    }
}