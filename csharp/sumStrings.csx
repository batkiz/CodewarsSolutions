#r "System.Numerics"
using System.Numerics;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        if (string.IsNullOrEmpty(a))
            a = "0";
        if (string.IsNullOrEmpty(b))
            b = "0";
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}