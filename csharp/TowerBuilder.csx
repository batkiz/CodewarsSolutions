public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        var tower = new string[nFloors];

        for (int i = 1; i <= nFloors; i++)
        {
            var floor =
                $"{new string(' ', nFloors - i)}{new string('*', i * 2 - 1)}{new string(' ', nFloors - i)}";

            tower[i - 1] = floor;
        }

        return tower;
    }
}