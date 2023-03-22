namespace FizzBuzz.Core;
public class FizzBuzzService
{
    public string Print(int number)
    {
        if (IsDivisibleByThree(number) && IsDivisibleByFive(number))
        {
            return "FizzBuzz";
        }
        else if (IsDivisibleByThree(number))
        {
            return "Fizz";
        }
        else if (IsDivisibleByFive(number))
        {
            return "Buzz";
        }
        return number.ToString();
    }

    private static bool IsDivisibleByFive(int number)
    {
        return number % 5 == 0;
    }

    private bool IsDivisibleByThree (int number) {
        return number % 3 == 0;
    }
}
