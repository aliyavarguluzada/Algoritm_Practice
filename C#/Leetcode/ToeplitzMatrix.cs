namespace C_.Leetcode
{
    public static class ToeplitzMatrix
    {
        public static bool IsToeplitzMatrix(int[][] matrix)
        {

            if (matrix is null)
                return false;

            int row = matrix.Length;
            int col = matrix[0].Length;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i + 1 < row &&
                        j + 1 < col &&
                        matrix[i][j] != matrix[i + 1][j + 1])
                        return false;
                }
            }
            return true;
        }
    }
}
