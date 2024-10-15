using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class RemoveElement
    {
        public static int removeElement(int[] nums, int val)
        {

            // Input: nums = [3, 2, 2, 3], val = 3
            // Output: 2, nums = [2, 2, _, _]

            // Input: nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2
            // Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]

            int k = 0;
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    k++;

                if (nums[i] != val && nums[j] == val)
                {
                    int temp = nums[i];

                    nums[i] = nums[j];
                    
                    nums[j] = temp;
                }
                if (nums[j] != val)
                    j++;
            }

            return k;
        }
    }
}
