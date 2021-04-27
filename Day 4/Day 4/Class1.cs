using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Product
    {
        Product()
        {

        }
        public int slno { get; set; }
        public String name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        


        public void InputValues()
        {
            Console.Write("Enter number of products needed to buy : ");
            int number = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter serial number : ");
                slno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product type : ");
                name = Console.ReadLine();
                Console.Write("Enter quantity : ");
                quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter price : ");
                price = Convert.ToInt32(Console.ReadLine());
      
            }
        }

        public void DispalyDetails()
        {
          


                Console.Write("Serial No \t");
                Console.Write("Name \t");
                Console.Write("quantity \t");
                Console.Write("price \t");
                Console.Write("totalprice \n");

            for (int i = 0; i < 2; i++)
            {
                Console.Write(slno + "\t");
                Console.Write(name + "\t");
                Console.Write(quantity + "\t");
                Console.Write(price + "\t");
                Console.Write((price * quantity) + "\t");
            }
               

            
        }
        public double TotalAmt()
        {
            int Total = price * quantity;
        }

        public static void Main(string[] args)
        {
            Product p1 = new Product();

            p1.InputValues();

            p1.DispalyDetails();
            p1. TotalAmt()
            //Console.Write("total amount : " + (p1.price * p1.quantity) + "\n");

            Console.ReadLine();

        }
    }
}

