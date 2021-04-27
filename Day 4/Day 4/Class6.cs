using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Product
    {
        public int code { get; set; }
        public string Existingpdt { get; set; }
        public int Existingpdtqty { get; set; }
        public int Existingprice { get; set; }
        public int pdtno { get; set; }
        public String name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int number { get; set; }

        public void invent()
        {
            Console.Write("Enter product code : ");
            code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the product inventory has : ");
            Existingpdt = Console.ReadLine();
            Console.Write("Enter the quantity of product  : ");
            Existingpdtqty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of prodcut: ");
            Existingprice = Convert.ToInt32(Console.ReadLine());
        }
        public class Invoice : Product
        {
            string CustomerName { get; set; }
            readonly string InvoiceNumber;



            public void PrintInvoice(Product[] products)
            {

                Console.WriteLine("-------------------Inventory List------------------------");
                Console.Write("index  \t");
                Console.Write("Product Code \t");
                Console.Write("Name  \t\t");
                Console.Write("quantity \t");
                Console.Write("price \n");

                int index = 1;
                foreach (var item in products)
                {

                    Console.Write(index + "\t");
                    Console.Write(item.code + "\t");
                    Console.Write(item.Existingpdt + "\t\t");
                    Console.Write(item.Existingpdtqty + "\t\t");
                    Console.Write(item.Existingprice + "\t");

                    Console.Write("\n");
                    index = index + 1;
                }

            }
            


        }
        public void Exit()
        {
            Console.Write("do you want to continue Y/N ?");
            char input = Convert.ToChar(Console.ReadLine());
            if (input == 'Y')
            {
                return;
            }
        }



        class CustomerB : Product
        {

            public void Buyer()
            {
                Console.WriteLine("Buyer List");



                Console.Write("Enter serial number : ");
                pdtno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product type : ");
                name = Console.ReadLine();
                Console.Write("Enter quantity : ");
                quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter price : ");
                price = Convert.ToInt32(Console.ReadLine());



            }


            class InvoiceB : Product
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
                        Console.Write((item.quantity - 10) + "\t\t");
                        Console.Write(item.price + "\t");
                        Console.Write((item.price) * (item.quantity - 10));
                        Console.Write("\n");
                        index = index + 1;
                    }

                }
            }

            class CustomerS : Product
            {

                public void Wholeseller()
                {
                    Console.WriteLine("Buyer List");



                    Console.Write("Enter serial number : ");
                    pdtno = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter product type : ");
                    name = Console.ReadLine();
                    Console.Write("Enter quantity : ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter price : ");
                    price = Convert.ToInt32(Console.ReadLine());



                }


                class InvoiceS : Product
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
                            Console.Write((item.quantity + 100) + "\t\t");
                            Console.Write(item.price + "\t");
                            Console.Write((item.price) * (item.quantity + 100));
                            Console.Write("\n");
                            index = index + 1;
                        }

                    }
                }


                public static void Main()
                {
                    Console.Write("Enter number of products in inventory: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Product[] products = new Product[number];

                    for (int i = 0; i < products.Length; i++)
                    {
                        Product product = new Product();
                        product.invent();
                        products[i] = product;
                    }
                    Invoice invoice = new Invoice();
                    invoice.PrintInvoice(products);
                    //Console.ReadLine();

                    Console.WriteLine("Enter whether u are a Buyer Or Wholeseller");

                    String c = Console.ReadLine();
                    if (c.Equals("Buyer"))
                    {
                        CustomerB buyer = new CustomerB();
                        buyer.Buyer();
                        Console.Write("Enter number of products needed to purchase: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Product[] productsB = new Product[number];

                        for (int i = 0; i < productsB.Length; i++)
                        {
                            Product product = new Product();
                            product.invent();
                            products[i] = product;
                        }
                        Invoice invoiceB = new Invoice();
                        invoice.PrintInvoice(products);
                        //Console.ReadLine();


                    }
                    else if (c.Equals("Wholeseller"))
                    {
                        CustomerS wholeseller = new CustomerS();
                        wholeseller.Wholeseller();
                        Console.Write("Enter number of products needed to purchase: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Product[] productsS = new Product[number];

                        for (int i = 0; i < productsS.Length; i++)
                        {
                            Product product = new Product();
                            product.invent();
                            products[i] = product;
                        }
                        Invoice invoiceS = new Invoice();
                        invoice.PrintInvoice(products);
                        //Console.ReadLine();

                    }
                    else
                    {
                        Console.Write("Invalid Entry");
                    }
                    Product products1 = new Product();
                    products1.Exit();

                    Console.ReadLine();
                }
            }
        }
    }
}
            
        

    

    

