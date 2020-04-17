using System;
using System.Linq;

public class ConwayLife
{
    public static int[,] GetGeneration(int[,] cells, int generation)
    {
        if (generation <= 0)
        {
            return cells;
        }

        var hang = cells.GetLength(0);
        var lie = cells.GetLength(1);

        var newGen = new int[hang + 2, lie + 2];

        var biggerCells = NewBoard(cells);


        for (int x = 0; x < hang + 2; x++)
        {
            for (int y = 0; y < lie + 2; y++)
            {
                var n = GetLiveNeighbors(x, y, biggerCells);
                var c = biggerCells[x, y];

                newGen[x, y] = ((c == 1) && (n == 2 || n == 3) || (c == 0) && n == 3) ? 1 : 0;
            }
        }

        var result = cropped(newGen);

        return GetGeneration(result, generation - 1);
    }

    public static int GetLiveNeighbors(int x, int y, int[,] ceil)
    {
        var val = 0;
        int[] neighbors = { 0, 1, -1 };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!(neighbors[i] == 0 && neighbors[j] == 0))
                {
                    int r = (x + neighbors[i]);
                    int c = (y + neighbors[j]);

                    try
                    {
                        if (ceil[r, c] == 1)
                        {
                            val += 1;
                        }
                    }
                    catch (System.Exception)
                    {
                        val += 0;
                        continue;
                    }
                }
            }
        }

        return val;
    }

    public static int[,] cropped(int[,] cells)
    {
        var hang = cells.GetLength(0);
        var lie = cells.GetLength(1);
        var (hStart, lStart, hEnd, lEnd, hLen, lLen) = (0, 0, 0, 0, 0, 0);

        for (int i = 0; i < hang; i++)
        {
            for (int j = 0; j < lie; j++)
            {
                if (cells[i, j] != 0)
                {
                    hStart = i;
                    i = hang;
                    break;
                }
            }
        }

        for (int i = hang - 1; i >= 0; i--)
        {
            for (int j = lie - 1; j >= 0; j--)
            {
                if (cells[i, j] != 0)
                {
                    hEnd = i;
                    i = 0;
                    break;
                }
            }
        }

        for (int i = 0; i < lie; i++)
        {
            for (int j = 0; j < hang; j++)
            {
                if (cells[j, i] != 0)
                {
                    lStart = i;
                    i = lie;
                    break;
                }
            }
        }


        for (int i = lie - 1; i >= 0; i--)
        {
            for (int j = hang - 1; j >= 0; j--)
            {
                if (cells[j, i] != 0)
                {
                    lEnd = i;
                    i = 0;
                    break;
                }
            }
        }

        hLen = hEnd - hStart + 1;
        lLen = lEnd - lStart + 1;

        var newCell = new int[hLen, lLen];

        Console.WriteLine($"h {hLen} l {lLen}");

        for (int i = 0; i < hLen; i++)
        {
            for (int j = 0; j < lLen; j++)
            {
                newCell[i, j] = cells[hStart + i, lStart + j];
            }
        }

        return newCell;
    }

    public static int[,] NewBoard(int[,] cells)
    {
        var hang = cells.GetLength(0);
        var lie = cells.GetLength(1);

        var newBoard = new int[hang + 2, lie + 2];

        for (int i = 0; i < hang + 2; i++)
        {
            for (int j = 0; j < lie + 2; j++)
            {
                newBoard[i, j] = 0;
            }
        }

        for (int i = 1; i < hang + 1; i++)
        {
            for (int j = 1; j < lie + 1; j++)
            {
                newBoard[i, j] = cells[i - 1, j - 1];
            }
        }

        return newBoard;
    }
}

