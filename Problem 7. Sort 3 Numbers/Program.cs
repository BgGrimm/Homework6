﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7.Sort_3_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else
            {
                if (b > c && a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    if (c > a && c > b)
                    {
                        if (a > b)
                        {
                            Console.WriteLine("{0} {1} {2}", c, a, b);
                        }
                        else
                        {
                            Console.WriteLine("{0} {1} {2}", c, b, a);
                        }
                    }
                    else
                    {
                        if (c > a)
                        {
                            Console.WriteLine("{0} {1} {2}", b, c, a);
                        }
                        else
                        {
                            Console.WriteLine("{0} {1} {2}", b, a, c);
                        }
                    }

                }
            }
        }
    }
}

