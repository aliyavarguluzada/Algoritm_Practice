using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class ContainsDuplicate
    {
        public static bool containsDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        return true;
                }
            }

            return false;
        }
        public static bool containsDuplicateOptimized(int[] nums)
        {
            HashSet<int> ints = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (ints.Contains(nums[i]))
                    return true;

                ints.Add(nums[i]);
            }
            return false;
        }
    }
}
