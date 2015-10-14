using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1.Exchange_If_Greater
{
    class Program
    {
        static void Main()
        {
        Console.WriteLine("Please enter a number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number");
        double b = double.Parse(Console.ReadLine());
        bool c = a > b;
        if (c)
        {
            Console.WriteLine("{0} {1}", b, a);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
}