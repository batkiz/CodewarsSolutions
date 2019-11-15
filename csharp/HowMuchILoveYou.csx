using System.Collections.Generic;
public class Kata
{
    public static string HowMuchILoveYou(int nb_petals)
    {
        var petal = new List<string>() { "not at all", "I love you", "a little", "a lot", "passionately", "madly" };
        return petal[nb_petals % 6];
    }
}