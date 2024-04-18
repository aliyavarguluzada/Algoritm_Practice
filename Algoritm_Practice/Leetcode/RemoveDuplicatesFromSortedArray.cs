using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            // Input: nums = [0,0,1,1,1,2,2,3,3,4]
            // Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]

            int k = 0;
           
            HashSet<int> uniques = nums.ToHashSet();
           
            int[] a = uniques.ToArray();

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 0;

                if (count < a.Length)
                {
                    nums[i] = a[count];

                    count++;
                }

            }

            k = uniques.Count();

            return k;
        }
    }
}
