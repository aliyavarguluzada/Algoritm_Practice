using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class MonotonicArray
    {
        public static bool IsMonotonic(int[] nums)
        {

            // Example 1:

            // Input: nums = [1, 2, 2, 3]
            // Output: true
            // Example 2:

            // Input: nums = [6, 5, 4, 4]
            // Output: true
            // Example 3:

            // Input: nums = [1, 3, 2]
            // Output: false


            bool increasing = true;

            bool decreasing = true;


            for (int i = 0; i < nums.Length - 1; i++)
            {

                if (nums[i] > nums[i + 1])
                    increasing = false;

                if (nums[i] < nums[i + 1])
                    decreasing = false;

                // if it is not increasing or decreasing return false
                if (increasing == false && decreasing == false)
                    return false;

            }

            return true;
        }
    }
}
