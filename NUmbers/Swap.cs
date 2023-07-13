using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmbers
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("Enter first number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("withou using third number");
            c = Convert.ToInt32(Console.ReadLine());
            //without using third number

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a},{b}");
            Console.WriteLine("using third variable");
            c = a;
            a = b;
            b = c;
            
            Console.WriteLine($"{a},{b}");
        }
    }
}
