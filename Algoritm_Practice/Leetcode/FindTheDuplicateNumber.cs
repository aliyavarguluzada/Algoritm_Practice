using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class FindTheDuplicateNumber
    {
        public static int FindDuplicate(int[] nums)
        {
            // Example 1:

            // Input: nums = [1, 3, 4, 2, 2]
            // Output: 2
            // Example 2:

            // Input: nums = [3, 1, 3, 4, 2]
            // Output: 3
            // Example 3:

            // Input: nums = [3, 3, 3, 3, 3]
            // Output: 3


            HashSet<int> uniques = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (uniques.Contains(nums[i]))
                    return nums[i];

                uniques.Add(nums[i]);
            }


            return -1;
        }
    }
}
