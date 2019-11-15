using System;

public static class Kata
{
    public static int TrailingZeros(int n)
    {
        int count = 0;

        for (var i = 5; n / i >= 1; i *= 5)
        {
            count += n / i;
        }

        return count;
    }
}


Console.WriteLine(Kata.TrailingZeros(5) == 1);
Console.WriteLine(Kata.TrailingZeros(25) == 6);
Console.WriteLine(Kata.TrailingZeros(531) == 131);