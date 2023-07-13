using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmbers
{
    internal class SumOfNaturalNUmber
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                sum=sum+i;
            }
            Console.WriteLine(sum);
        }
        
    }
}
