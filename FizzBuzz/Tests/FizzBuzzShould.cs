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
		
		private String ReturnFizz(int number){          
            return "Fizz";
		}
    }
}
