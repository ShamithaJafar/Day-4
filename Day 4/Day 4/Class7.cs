using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class MyException : ApplicationException
    {

        public void MyDivideException()
        {
            Console.WriteLine("exception occured, divisor should be zero");
        }
    }
    class Class6
    {
        public static void Main()
        {
            int x = 5, y = 0, z;
            Class6 c = null;
            try
            {
                if (c == null)
                {
                    throw new MyException();
                }


            }
            catch (MyException ex)
            {
                ex.MyDivideException();
            }
            Console.ReadLine();
        }

    }
}
