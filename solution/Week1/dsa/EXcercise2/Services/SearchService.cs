using System;
using Exercise2_EcommerceSearch.Models;

namespace Exercise2_EcommerceSearch.Services
{
    public class SearchService
    {
        // Linear Search
        public int LinearSearch(Product[] products, string searchName)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }

        // Binary Search (Array must be sorted by ProductName)
        public int BinarySearch(Product[] products, string searchName)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                int result = string.Compare(
                    products[mid].ProductName,
                    searchName,
                    StringComparison.OrdinalIgnoreCase);

                if (result == 0)
                {
                    return mid;
                }
                else if (result < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        public void DisplayResult(Product[] products, int index)
        {
            if (index != -1)
            {
                Console.WriteLine("Product Found:");
                Console.WriteLine(products[index]);
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }
    }
}