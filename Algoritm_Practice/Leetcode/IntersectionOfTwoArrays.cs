using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class IntersectionOfTwoArrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {

            HashSet<int> uniques = new HashSet<int>();

            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1.Contains(nums2[j]))
                {
                    uniques.Add(nums2[j]);
                }


            }
            int[] newArray = uniques.ToArray();
            return newArray;
        }
    }
}
