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
            int[] x = new int[nums.Length];

            int k = 0;

            foreach (var item in nums)
            {
                if (item != val)
                {
                    x[k] = item;
                    k++;

                }

                return k;
            }
            for (int i = 0; i < x.Length; i++)
            {
                nums[i] = x[i];
            }

            return k;
        }
    }
}
