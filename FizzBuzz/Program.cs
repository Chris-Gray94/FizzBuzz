using System;

namespace FizzBuzz
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int fizzBuzz;

            for (fizzBuzz = 1; fizzBuzz <= 100; fizzBuzz++)
            {
                if (fizzBuzz % 3 == 0 && fizzBuzz % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (fizzBuzz % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (fizzBuzz % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(fizzBuzz);
                }
            }
            Console.ReadKey();
        }
    }
}