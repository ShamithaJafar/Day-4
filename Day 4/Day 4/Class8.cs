using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Product
    {

        public int pdtno { get; set; }
        public String name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int number { get; set; }
        public int code { get; set; }
        public int Existingpdt { get; set; }
        public int Existingpdtqty { get; set; }





        public void InputValues()
        {
            
        
                Console.Write("Enter serial number : ");
                pdtno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product type : ");
                name = Console.ReadLine();
                Console.Write("Enter quantity : ");
                quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter price : ");
                price = Convert.ToInt32(Console.ReadLine());


            
        }
        
    }
    class Invoice : Product
    {
        string CustomerName { get; set; }
        readonly string InvoiceNumber;

        

        public void PrintInvoice(Product[] products)
        {

            Console.WriteLine("-------------------Invoice------------------------");
            Console.Write("index  \t");
            Console.Write("Product No \t");
            Console.Write("Name \t\t");
            Console.Write("quantity \t");
            Console.Write("price \t");
            Console.Write("totalprice \n");
            int index = 1;
            foreach (var item in products)
            {

                Console.Write(index + "\t");
                Console.Write(item.pdtno + "\t");
                Console.Write(item.name + "\t\t");
                Console.Write(item.quantity + "\t\t");
                Console.Write(item.price + "\t");
                Console.Write((item.price) * (item.quantity));
                Console.Write("\n");
                index = index + 1;
            }

        }


    }


    class User
    {


        public static void Main()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Product[] products = new Product[number];

            for (int i = 0; i < products.Length; i++)
            {
                Product product = new Product();
                product.InputValues();
                products[i] = product;
            }
            Invoice invoice = new Invoice();
            invoice.PrintInvoice(products);
            Console.ReadLine();

        }
    }
}


