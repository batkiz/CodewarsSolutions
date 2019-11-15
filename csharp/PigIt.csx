using System.Text.RegularExpressions;

public class Kata
{
    public static string PigIt(string str)
    {

        string pig = Regex.Replace(
            str,
            @"(\w+)",
            i => i.ToString().Remove(0, 1) + i.ToString().Substring(0, 1) + "ay");

        return pig;
    }
}