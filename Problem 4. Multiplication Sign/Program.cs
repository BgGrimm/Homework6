using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4.Multiplication_Sign
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

            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a == 0 && b < 0 && c > 0)
            {
                Console.WriteLine("0");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
