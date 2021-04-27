using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Class4
    {
        public static void Main()
        {
            int x = 1;
            int y;
            try
            {
                y = x / 0;
                Console.WriteLine(y);

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("some errors have occured");
            }
            finally
            {
                Console.WriteLine("I am finallly back");

            }
            Console.ReadLine();
        }
    }
}
