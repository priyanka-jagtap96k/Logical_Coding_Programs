using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_palindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0, temp;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            temp = a;
            while (a > 0)
            {
                b = a % 10;
                sum = (sum * 10) + b;
                a = a / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
