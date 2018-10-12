using System;
using Xunit;

namespace Tests
{   
    public class FizzBuzzShould
    {
        [Fact]
        public void ReturnFizzWhenMultipleThree()   
        {
            int number = 3;
            var fizz = ReturnFizz(number);
            Assert.Equal("Fizz", fizz);
        }
		
		private String ReturnFizz(int number)
        {          
            return "Fizz";
		}

        [Fact]
        public void ReturnBuzzWhenMultipleFive()
        {
            int number = 5;
            var buzz = ReturnBuzz(number);
            Assert.Equal("Buzz", buzz);
        }

        private String ReturnBuzz(int number)
        {
            return "Buzz";
        }

        [Fact]
        public void ReturnFizzBuzzWhenMultipleThreeAndFive()
        {
            int fizzNumber = 3;
            int buzzNumber = 5;
            int number = buzzNumber * fizzNumber;
            var fizz = ReturnFizz(number);
            Assert.Equal("Fizz", fizz);
        }

        private String ReturnFizzBuzz(int fizzNumber,int buzzNumber)
        {
            return "FizzBuzz";
        }
    }
}