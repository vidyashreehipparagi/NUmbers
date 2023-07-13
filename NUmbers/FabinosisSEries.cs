using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmbers
{
    internal class FabinosisSEries
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c=0,num;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i=2;i<num;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b=c;
                
            }
         

        }
    }
}
