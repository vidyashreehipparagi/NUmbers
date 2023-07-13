using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmbers
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            int num, sum=0,rem;
            Console.WriteLine("Enter number");
            num =Convert.ToInt32(Console.ReadLine());
            
            while (num > 0)
            {
                rem=num%10;
                sum = sum + (rem * rem * rem);
                num = num / 10;

            }
            if (num == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not an armstrong number");
            }
        }
    }
}
