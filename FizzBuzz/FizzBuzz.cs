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
        /*
        public int Fizz(int fizzNumber)
        {
            
            for (fizzNumber = 1; fizzNumber <= 100; fizzNumber++)
            {
                if (fizzNumber % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(fizzNumber);
                }
                
            }
            Console.ReadKey();
            return fizzNumber;
        }

        public int Buzz(int buzzNumber)
        {
            
            for (buzzNumber = 1; buzzNumber <= 100; buzzNumber++)
            {
                if (buzzNumber % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(buzzNumber);
                }

            }
            Console.ReadKey();
            return buzzNumber;
        }
        */
        public static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();
            fb.FizzBuzzNumber(15);
        }
    }
}