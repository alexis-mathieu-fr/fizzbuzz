namespace Fizzbuzz.App;

public static class FizzBuzzClass
{
    public static void Main()
    {
    }

    public static string TestFunction(int input) =>
        input switch
        {
            _ when input % 15 == 0 => "FizzBuzz",
            _ when input % 3 == 0 => "Fizz",
            _ when input % 5 == 0 => "Buzz",
            _ => input.ToString()
        };
}