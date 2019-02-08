using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter();
        }

        private static void Counter()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(NumberCheck(i));
            }
        }

        private static string NumberCheck(int number)
        {
            if (DivisibleBy(number, 15)) { return "FizzBuzz"; }
            else if (DivisibleBy(number, 3)) { return "Fizz"; }
            else if (DivisibleBy(number, 5)) { return "Buzz"; }
            else { return $"{number}"; }
        }

        private static bool DivisibleBy(int number, int dividedBy)
        {
            return number % dividedBy == 0;
        }
    }
}
