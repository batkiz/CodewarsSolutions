// thanks to
// http://code.kylebaker.io/2018/03/28/old-code-new-code-codewars/#

public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        var textList = text.Split('\n');
        var newstr = "";
        var tmp = "";
        foreach (var item in textList)
        {
            tmp = item;
            foreach (var c in commentSymbols)
            {
                if (item.Contains(c))
                {
                    tmp = item.Substring(0, item.IndexOf(c));
                }
            }
            newstr += tmp.TrimEnd(' ') + "\n";
        }

        return newstr.TrimEnd('\n');
    }
}

Console.WriteLine(StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples",
                                                      new[] { "#", "!" })
                  == "apples, pears\ngrapes\nbananas");
Console.WriteLine(StripCommentsSolution.StripComments("a #b\nc\nd $e f g",
                                                      new string[] { "#", "$" })
                  == "a\nc\nd");
