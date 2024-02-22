using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class MiniMaxSum
    {
        public void miniMaxSum(List<int> arr)
        {
            long result = 0;
            long minSum = 0;
            long maxSum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                result += arr[i];

                maxSum = result - arr.Min();
                minSum = result - arr.Max();
            }

            Console.WriteLine(result);

            Console.WriteLine($"{minSum} {maxSum}");


        }
    }
}
