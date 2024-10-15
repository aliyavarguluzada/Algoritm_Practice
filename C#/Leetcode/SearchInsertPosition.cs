using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            // Example 1:

            // Input: nums = [1, 3, 5, 6], target = 5
            // Output: 2
            // Example 2:

            // Input: nums = [1, 3, 5, 6], target = 2
            // Output: 1
            // Example 3:

            //Input: nums = [1, 3, 5, 6], target = 7
            //Output: 4

            int position = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (target > nums[nums.Length - 1])
                    return nums.Length;

                if (nums[i] == target || target < nums[i])
                    return i;

                if (target == nums[i] + 1)
                {
                    position = i + 1;
                    return position;
                }

            }

            return -1;
        }
    }
}
