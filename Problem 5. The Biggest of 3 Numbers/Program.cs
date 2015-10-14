using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_5.The_Biggest_of_3_Numbers
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
            float max = a;

            if (b > a)
            {
                max = b;
            }
            if (c > b)
            {
                max = c;
            }
            if (a > c)
            {
                max = a;
            }
            Console.WriteLine(max);
        }
    }
        }
    

