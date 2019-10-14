using System;

namespace ChallengeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random();
            int year = rando.Next(0, 2500);
            Console.WriteLine("Is " + year + " a leap year?");
            if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            } else
            {
                Console.WriteLine(year + " is not a leap year");
                    }
            Console.ReadLine();
        }
    }
}
