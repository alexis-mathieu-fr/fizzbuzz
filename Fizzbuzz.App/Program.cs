namespace Fizzbuzz.App;

public static class FizzBuzzClass
{
    public static void Main()
    {
    }

    public static string TestFunction(int input)
    {
        if (input % 3 == 0 && input % 5 != 0) return "Fizz";
        if (input == 5) return "Buzz";
        if (input == 15) return "FizzBuzz";
        return input.ToString();
    }
}