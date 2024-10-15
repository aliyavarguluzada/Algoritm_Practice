using Algoritm_Practice.Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public static class DivisibleSumPairs
    {
        // arr = [1, 2, 3, 4, 5, 6]; k = 5;
        // 1 3 2 6 1 2
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int pairCount = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        pairCount++;
                    }
                }
            }
            return pairCount;
        }
    }
}
