using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class ArrayPartition
    {
        public static int ArrayPairSum(int[] nums)
        {

            Array.Sort(nums);

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                    sum += nums[i];
            }

            return sum;
        }
    }
}
