namespace Algoritm_Practice.Leetcode
{
    public static class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> row = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.' && !row.Add(board[i][j]))
                        return false;
                }


            }

            for (int j = 0; j < 9; j++)
            {
                HashSet<char> column = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (board[i][j] != '.' && !column.Add(board[i][j]))
                        return false;
                }


            }


            for (int block = 0; block < 9; block++)
            {
                HashSet<char> threeByThree = new HashSet<char>();
                for (int i = block / 3 * 3; i < block / 3 * 3 + 3; i++)
                {
                    for (int j = block % 3 * 3; j < block % 3 * 3 + 3; j++)
                    {
                        if (board[i][j] != '.' && !threeByThree.Add(board[i][j]))
                            return false;

                    }
                }
            }

            return true;

        }

    }
}

