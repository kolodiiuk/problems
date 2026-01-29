public class TicTacToe
{
    public static int IsSolved(int[,] board)
    {
        int[] isVerticalOrDiagonalWin = new int[3 + 2]; // main, sec
        bool hasZero = false;

        for (int i = 0; i < 3; i++)
        {
            int isHorizontalWin = 0;
            for (int j = 0; j < 3; j++)
            {
                switch (board[i, j])
                {
                    case 1:
                        isHorizontalWin++;
                        break;
                    case 2:
                        isHorizontalWin--;
                        break;
                    case 0:
                        isHorizontalWin = 0;
                        hasZero = true;
                        break;
                }

                switch (board[i, j])
                {
                    case 1:
                        isVerticalOrDiagonalWin[i]++;
                        break;
                    case 2:
                        isVerticalOrDiagonalWin[i]--;
                        break;
                    case 0:
                        isVerticalOrDiagonalWin[i] = 0;
                        hasZero = true;
                        break;
                }
            }

            switch (isHorizontalWin)
            {
                case 3:
                    return 1;
                case -3:
                    return 2;
            }
        }

        isVerticalOrDiagonalWin[3] = board[0, 0] + board[1, 1] + board[2, 2];
        isVerticalOrDiagonalWin[4] = board[0, 2] + board[1, 1] + board[2, 0];
        if (isVerticalOrDiagonalWin[0] == 3 || isVerticalOrDiagonalWin[1] == 3 || isVerticalOrDiagonalWin[2] == 3)
        {
            return 1;
        }
        else if (isVerticalOrDiagonalWin[0] == -3 || isVerticalOrDiagonalWin[1] == -3 ||
                 isVerticalOrDiagonalWin[2] == -3)
        {
            return 2;
        }
        else if ((isVerticalOrDiagonalWin[3] == 3 || isVerticalOrDiagonalWin[4] == 3) && board[1, 1] != 0 &&
                 ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] == board[2, 2])
                  || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] == board[2, 0])))
        {
            return 1;
        }
        else if ((isVerticalOrDiagonalWin[4] == -3 || isVerticalOrDiagonalWin[4] == -3) && board[1, 1] != 0 &&
                 ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] == board[2, 2])
                  || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] == board[2, 0])))
        {
            return 2;
        }
        else if (!hasZero)
        {
            return 0;
        }

        return -1;
    }
}
