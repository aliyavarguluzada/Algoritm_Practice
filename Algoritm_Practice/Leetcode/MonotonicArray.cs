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


            bool[] cases = new bool[nums.Length - 1];

            int i = 0;
            int j = 1;






            while (nums[i] <= nums[j])
            {

            }
           

            bool ans = cases.All(x => x == true);


            if (ans == true)
                return true;


            return false;
        }
    }
}
