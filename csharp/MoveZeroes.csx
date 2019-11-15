using System.Collections.Generic;
public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        var nArr = new List<int>();
        int zeros = 0;

        foreach (var item in arr)
        {
            if (item == 0)
            {
                zeros++;
            }
            else
            {
                nArr.Add(item);
            }
        }

        for (int i = 0; i < zeros; i++)
        {
            nArr.Add(0);
        }

        return nArr.ToArray();
    }
}