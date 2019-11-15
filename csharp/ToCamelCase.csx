using System.Text.RegularExpressions;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        var s = Regex.Replace(str, @"[-|_][a-zA-Z]", i => i.ToString().ToUpper());
        s = Regex.Replace(s, "[-|_]", "");

        return s;
    }
}