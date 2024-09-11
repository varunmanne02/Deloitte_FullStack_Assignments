using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public int Quantity { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return string.Format("\n Product Id: {0} \n Product Name: {1} \n Unit Price: {2} \n Quantity: {3}, Category: {4} \n", ProductId, Name, UnitPrice, Quantity, Category);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            Console.WriteLine("Enter 2 Product Details\n");
            Product product;
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine($"Enter details of Product {i}");
                product = new Product();
                Console.WriteLine("Enter Product ID:");
                product.ProductId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product Name:");
                product.Name = Console.ReadLine();

                Console.WriteLine("Enter Unit Price:");
                product.UnitPrice = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Quantity:");
                product.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product Category:");
                product.Category = Console.ReadLine();

                products.Add(product);

            }

            Console.WriteLine("Enter the Id of the product to search");
            int productIDToDisplay = int.Parse(Console.ReadLine());
            Product productToDisplay = products.Find(p => p.ProductId == productIDToDisplay);

            if (productToDisplay != null)
            {
                Console.WriteLine("Searched Product Found.");
            }
            else
            {
                Console.WriteLine("Searched Product Not Found.");
            }

            Console.WriteLine("Enter the Id of the product to remove");
            int productIDToRemove = int.Parse(Console.ReadLine());
            Product productToRemove = products.Find(p => p.ProductId == productIDToRemove);

            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                Console.WriteLine("Product removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            

            Console.WriteLine("Details of remaining products:\n");

            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }


            Console.ReadLine();
        }
    }
}
