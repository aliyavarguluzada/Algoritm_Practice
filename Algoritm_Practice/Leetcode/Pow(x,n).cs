namespace Algoritm_Practice.Leetcode
{
    public class Pow_x_n_
    {
        public static double Pow(double x, int n)
        {

            double result = 1;

            if (n < 0)
            {
                int y = -1;
                while (y >= n)
                {

                    result /= x;
                    y--;
                }
            }
            else
            {
                int y = 1;

                while (y <= n)
                {
                    result *= x;
                    y++;
                }
            }
            return result;
        }
    }
}
