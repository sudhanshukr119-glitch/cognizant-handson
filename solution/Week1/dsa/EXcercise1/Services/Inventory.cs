using System;
using System.Collections.Generic;
using Exercise1_InventoryManagement.Models;

namespace Exercise1_InventoryManagement.Services
{
    public class Inventory
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        // Add Product
        public void AddProduct(Product product)
        {
            if (!products.ContainsKey(product.ProductId))
            {
                products.Add(product.ProductId, product);
                Console.WriteLine("Product Added Successfully.");
            }
            else
            {
                Console.WriteLine("Product ID already exists.");
            }
        }

        // Update Product
        public void UpdateProduct(int id, int quantity, double price)
        {
            if (products.ContainsKey(id))
            {
                products[id].Quantity = quantity;
                products[id].Price = price;

                Console.WriteLine("Product Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }

        // Delete Product
        public void DeleteProduct(int id)
        {
            if (products.Remove(id))
            {
                Console.WriteLine("Product Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }

        // Display Products
        public void DisplayProducts()
        {
            Console.WriteLine("\nInventory Details");

            foreach (Product product in products.Values)
            {
                Console.WriteLine(product);
            }
        }
    }
}