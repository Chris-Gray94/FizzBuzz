using Xunit;
using fizzbuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
  
    {
        FizzBuzz fb = new FizzBuzz(); 

        [Fact]
        public void Fizz_WhenMultipleThree_ReturnFizz()   
        {
            int number = 3;
            var fizz = fb.FizzBuzzNumber(number);                 
            Assert.Equal(number, fizz);
        }

        [Fact]
        public void Buzz_WhenMultipleFive_ReturnBuzz()
        {
            int number = 5;
            var buzz = fb.FizzBuzzNumber(number);
            Assert.Equal(number, buzz);
        }
        
        [Fact]
        public void FizzBuzz_WhenMultipleThreeAndFive_ReturnFizzBuzz()
        {
            int fizzNumber = 3;
            int buzzNumber = 5;
            var fizzBuzz = fb.FizzBuzzNumber(fizzNumber * buzzNumber);
            Assert.Equal(fizzNumber * buzzNumber, fizzBuzz);
        }
    }
}