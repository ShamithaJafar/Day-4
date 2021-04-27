using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembly1;

namespace Day_4
{
    class Program
    {
        //method
        public void Display()
        {
            Console.WriteLine("Hi I'm sample assemply");
        }
        //function
        static void Main(string[] args)
        {
            AssemblyClass assemblyClass = new AssemblyClass();
            Console.WriteLine(assemblyClass.Sum(1, 2));
            Console.WriteLine(assemblyClass.Sub(4, 2));
            Console.WriteLine(assemblyClass.Mul(3, 2));
            Console.WriteLine(assemblyClass.Div(8, 2));
            Console.ReadLine();
        }
    
}
}
