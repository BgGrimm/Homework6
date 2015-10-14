using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6.TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number:");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the fourth number:");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the fifth number:");
            float e = float.Parse(Console.ReadLine());
            float max = a;

            if (b > a)
            {
                max = b;
            }
            if (c > b)
            {
                max = c;
            }
            if (d > c)
            {
                max = d;
            }
            if (e > d)
            {
                max = e;
            }
            if (a > e)
            {
                max = a;
            }
            Console.WriteLine(max);
        }
    }
}
