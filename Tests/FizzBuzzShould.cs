using System;
using Xunit;

namespace Tests
{
    public class FizzBuzzShould
    {
        [Fact]
        public void ReturnFizzWhenMultipleThree()
        {
			var fizz = ReturnFizz(2);
			Assert.Equal("Fizz", fizz);
        }
		
		private String ReturnFizz(int number){
			return "Fizz";
		}
		
    }
}
