public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string pos = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                pos += $" {char.ToUpper(text[i]) - 64}";
            }
        }

        return pos == "" ? pos : pos.Remove(0, 1);
    }
}