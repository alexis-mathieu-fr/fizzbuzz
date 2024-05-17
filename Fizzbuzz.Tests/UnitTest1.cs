using Fizzbuzz.App;

namespace Fizzbuzz.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(6, "Fizz")]
    [InlineData(9, "Fizz")]
    [InlineData(10, "Buzz")]
    [InlineData(30, "FizzBuzz")]
    public void IfInputThenShouldMatchExpected(int input, string expected)
    {
        var result = FizzBuzzClass.TestFunction(input);
        
        Assert.Equal(expected, result);
    }
}