using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class _2DArrayDs
    {
        public int hourglassSum(List<List<int>> arr)
        {
            int result = 0;
            int sum = 0;

            List<int> hourglassSum = new List<int>();

            for (int i = 0; i < arr.Count - 2; i++)
            {
                for (int j = 0; j < arr.Count - 2; j++)
                {
                    sum = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2]) + (arr[i + 1][j + 1]) + (arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);
                    hourglassSum.Add(sum);
                }
            }
            result = hourglassSum.Max();



            return result;
        }
    }
}
