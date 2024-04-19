using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            // Input: nums = [1,2,3,4,5,6,7], k = 3
            // Output: [5,6,7,1,2,3,4]



            //if (nums.Length < k)
            //    return;
            int[] arr = new int[nums.Length];

            int position = 0;

            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                if (i + k - n > n - 1)
                {
                    int s = ((i + k) / n);
                    position = (i + k) - s * n;
                }
                else if (i + k > n - 1)
                {
                    position = i + k - n;

                }
                else
                {
                    position = i + k;

                }
                arr[position] = nums[i];

            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = arr[i];
            }


        }
    }
}
