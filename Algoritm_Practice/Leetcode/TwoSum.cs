using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class TwoSum
    {
        public static int[] TwoSumOp(int[] nums, int target)
        {
            HashSet<int> l = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        l.Add(nums[i]);
                        l.Add(nums[j]);
                        break;

                    }

                }
            }
            int[] result = l.ToArray();
            return result;
        }
    }
}
