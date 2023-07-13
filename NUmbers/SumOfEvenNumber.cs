using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmbers
{
    internal class SumOfEvenNumber
    {
        static void Main(string[] args)
        { int sum = 0,sum1=0;
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
                else if(i%2!= 0) {
                 sum1= sum1 + i;
                }
            }
            Console.WriteLine("sum of even numbers "+sum);
            Console.WriteLine("Sum of odd numbers "+sum1);





        }
    }
}
