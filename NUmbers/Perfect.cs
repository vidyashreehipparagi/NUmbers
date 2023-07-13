using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmbers
{
    internal class Perfect
    {
        static void Main(string[] args)
        {
            int num, sum = 0,temp;
            Console.WriteLine("Enter number");

            num =Convert.ToInt32(Console.ReadLine());
            temp=num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
                {
                    Console.WriteLine($"{num} is Perfect number");
                }
            else
                {
                    Console.WriteLine($"{num} is not perfect number");
                }
            
           
        }
    }
}
