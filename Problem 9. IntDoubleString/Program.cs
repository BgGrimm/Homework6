using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_9.IntDoubleString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a type: \"1\" for integer, \"2\" for double, \"3\" for string");
            string choice = (Console.ReadLine());
            switch (choice)
            {
                case "1": Console.WriteLine("Enter an integer:");
                    int a = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(a + 1);
                    break;
                case "2": Console.WriteLine("Enter a double:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(b + 1);
                    break;
                case "3": Console.WriteLine("Enter a string:");
                    string c = Console.ReadLine();
                    Console.WriteLine("{0}*", c);
                    break;

                default: Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}