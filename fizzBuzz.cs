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
                NumberCheck(i);
            }
        }

        private static void NumberCheck(int number)
        {
            if (DivisibleBy(number, 15)) { Console.WriteLine("FizzBuzz"); }
            else if (DivisibleBy(number, 3)) { Console.WriteLine("Fizz"); }
            else if (DivisibleBy(number, 5)) { Console.WriteLine("Buzz"); }
            else { Console.WriteLine(number); }
        }

        private static bool DivisibleBy(int number, int dividedBy)
        {
            return number % dividedBy == 0;
        }
    }
}
