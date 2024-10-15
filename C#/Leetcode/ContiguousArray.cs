using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class ContiguousArray
    {
        public static int FindMaxLength(int[] nums)
        {
            // Example 1:

            // Input: nums = [0, 1]
            // Output: 2
            // Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
            // Example 2:

            // Input: nums = [0, 1, 0]
            // Output: 2
            // Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.           

            // [0, 1, 0, 1]

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] != nums[j])
                        count++;
                }
            }

            return count;
        }
    }
}
