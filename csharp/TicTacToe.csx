public class TicTacToe
{
    public int IsSolved(int[,] board)
    {
        if (isWinner(1, board))
            return 1;
        if (isWinner(2, board))
            return 2;
        if (isUnfinished(board))
            return -1;
        return 0;
    }

    public bool isWinner(int player, int[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                return true;
            if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                return true;
        }

        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            return true;
        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            return true;

        return false;
    }

    public bool isUnfinished(int[,] board)
    {
        foreach (var item in board)
        {
            if (item == 0)
                return true;
        }
        return false;
    }
}