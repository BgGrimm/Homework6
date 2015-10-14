using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3.Check_for_a_Play_Card
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a card sign");
            string c = (Console.ReadLine());

            if (c == "A" || c == "J" || c == "K" || c == "Q" || c == "2" || c == "3" || c == "4" || c == "5" || c == "6" || c == "7" || c == "8" || c == "9" || c == "10")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
