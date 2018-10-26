using System;

namespace fizzbuzz
{
    public class FizzBuzz
    {
        public int FizzBuzzNumber(int fizzBuzzNumber)
        {
            for (fizzBuzzNumber = 1; fizzBuzzNumber <= 100; fizzBuzzNumber++)
            {
                if (fizzBuzzNumber % 3 == 0 && fizzBuzzNumber % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizzBuzzNumber % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fizzBuzzNumber % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(fizzBuzzNumber);
                }

            }
            Console.ReadKey();
            return fizzBuzzNumber;
        }
        
        public static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();
            fb.FizzBuzzNumber(15);
        }
    }
}