using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class DiagonalDifference
    {
        public int diagonalDifference(List<List<int>> arr)
        {
            int sum_1 = 0;
            int sum_2 = 0;
            int result = 0;
            arr.ToArray<List<int>>();


            for (int i = 0; i < arr.Count; i++)
            {

                sum_1 = arr[i][i];
                sum_2 = arr[i][arr.Count - 1 - i];

            }


            result = Math.Abs(sum_1 - sum_2);

            return result;
        }
    }
}
