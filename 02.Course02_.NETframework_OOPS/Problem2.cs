using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ProdId;
            string ProdName;
            int UnitPrice;
            int Quantity;
            double discount = 0;
            double totalAmount;
            double finalAmount;
            double discountAmount;

            Console.WriteLine("Enter the Product ID");
            ProdId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Product Name");
            ProdName = Console.ReadLine();

            Console.WriteLine("Enter the Unit Price");
            UnitPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Quantity");
            Quantity = int.Parse(Console.ReadLine());

            totalAmount = UnitPrice * Quantity;
            Console.WriteLine();

            if (Quantity > 10)
            {
                discount = 0.10;
            }
            if (Quantity > 30)
            {
                discount = 0.20;
            }
            if (Quantity > 50)
            {
                discount = 0.30;
            }
           

            discountAmount = totalAmount * discount;
            finalAmount = totalAmount - discountAmount; 

            Console.WriteLine("Product Id: " + ProdId);
            
            Console.WriteLine("Product Name: " + ProdName);
            
            Console.WriteLine("Unit Price: " + UnitPrice);
            
            Console.WriteLine("Quantity: " + Quantity);
            
            Console.WriteLine("Total Amount: " + totalAmount);
            
            Console.WriteLine("Discount Amount: " + discountAmount);
            
            Console.WriteLine("Final Amount: " + finalAmount);
           

            Console.ReadLine();
        }
    }
}
