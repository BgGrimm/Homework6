using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2.Bonus_Score
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your score");
            int score = int.Parse(Console.ReadLine());
            if (score >= 1 && score <= 3)
            {
                Console.WriteLine("Your score is {0}", score * 10);
            }
            else if (score >= 4 && score <= 5)
            {
                Console.WriteLine("Your score is {0}", score * 100);
            }
            else if (score >= 7 && score <= 9)
            {
                Console.WriteLine("Your score is {0}", score * 1000);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}