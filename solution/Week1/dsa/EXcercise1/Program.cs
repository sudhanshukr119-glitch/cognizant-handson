using Exercise1_InventoryManagement.Models;
using Exercise1_InventoryManagement.Services;

namespace Exercise1_InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            Product p1 = new Product(101, "Laptop", 10, 55000);
            Product p2 = new Product(102, "Mouse", 50, 700);
            Product p3 = new Product(103, "Keyboard", 30, 1500);

            // Add Products
            inventory.AddProduct(p1);
            inventory.AddProduct(p2);
            inventory.AddProduct(p3);

            inventory.DisplayProducts();

            // Update Product
            inventory.UpdateProduct(102, 60, 750);

            inventory.DisplayProducts();

            // Delete Product
            inventory.DeleteProduct(101);

            inventory.DisplayProducts();
        }
    }
}