using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Product
    {
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }

        public void GetProductDetails()
        {
            Console.WriteLine("Enter Product Name :");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product Quantity :");
            ProductQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Price :");
            ProductPrice = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Invoice : Product
    {
        string CustomerName { get; set; }
        readonly string InvoiceNumber;
        public void PrintInvoice(Product[] products)
        {
            Console.WriteLine("-------------------Invoice------------------------");
            Console.WriteLine("S.No \t Product Name \t Quantity \t Price \t Total");
            int index = 1;
            foreach (var item in products)
            {
                Console.Write(index);
                Console.Write("\t");
                Console.Write(item.ProductName);
                Console.Write("\t\t");
                Console.Write(item.ProductQuantity);
                Console.Write("\t\t");
                Console.Write(item.ProductPrice);
                Console.Write("\t\t");
                Console.Write(item.ProductPrice * item.ProductQuantity);
                Console.Write("\n");
                index = index + 1;
            }
        }
    }
    class User
    {
        public static void Main()
        {
            Console.WriteLine("-------------------Pos Sample Software------------------------");
            //array of objects
            Product[] products = new Product[2];

            for (int i = 0; i < products.Length; i++)
            {
                Product product = new Product();
                product.GetProductDetails();
                products[i] = product;
            }
            Invoice invoice = new Invoice();
            invoice.PrintInvoice(products);

            Console.ReadLine();
        }
    }
}