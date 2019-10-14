using System;

namespace ChallengeThree
{
    class Program
    {
        static void Main(int[] perfectSequense)
        {
            Console.WriteLine("Array: " + String.Join(',', perfectSequense));
            int sum = 0;
            int product = 1;
            foreach (var number in perfectSequense)
            {
                sum += number;
                product *= number;
            }
            if (sum == product)
            {
                Console.WriteLine(String.Join(',', perfectSequense) + " is a perfect sequence");
            }
            else
            {
                Console.WriteLine(String.Join(',', perfectSequense) + " is not a perfect sequense");
            }
            Console.ReadLine();
        }
    }
}
