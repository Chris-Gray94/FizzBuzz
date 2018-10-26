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
            var fizz = fb.FizzBuzzNumber();                 
            Assert.Equal(3, fizz);
        }

        [Fact]
        public void Buzz_WhenMultipleFive_ReturnBuzz()
        {
            var buzz = fb.FizzBuzzNumber();
            Assert.Equal(5, buzz);
        }
        
        [Fact]
        public void FizzBuzz_WhenMultipleThreeAndFive_ReturnFizzBuzz()
        {
            var fizzBuzz = fb.FizzBuzzNumber();
            Assert.Equal(15, fizzBuzz);
        }
    }
}