using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmbers
{
    internal class PalindromeNUmber
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, temp;
            Console.WriteLine("Enter number to check");
            num=Convert.ToInt32(Console.ReadLine());
            temp=num;
            while(num>0)
            {
                rem = num % 10;
                sum =sum*10+rem;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine($"{sum} is Palindrome number");
            }
            else
            {
                Console.WriteLine($"{sum} is not Palindrome number");
            }
            
        }
    }
}
