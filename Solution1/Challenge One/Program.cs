using System;

namespace Challenge_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready to play a game? Choose between 1 and 10.");

            string[] numArray = new string[5];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Choose a number for your score.");
            string score = Console.ReadLine();
            int counter = 0;
            foreach(string number in numArray)
            {
                if(score == number)
                {
                    counter++;
                        }
            }

            int guessTheNumber = Convert.ToInt32(score);
            int finalScore = counter * guessTheNumber;
            Console.WriteLine($"Score: {finalScore}");
            Console.ReadLine();
        }
    }
}
