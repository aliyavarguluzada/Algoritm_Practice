using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public static class LeftRotation
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int n = arr.Count;

            int[] newArray = new int[n];

            for (int i = 0; i < arr.Count; i++)
            {
                int newIndex;

                if (i - d < 0)
                    newIndex = i - d + n;
                else
                    newIndex = i - d;

                newArray[newIndex] = arr[i];

            }
            List<int> aa = newArray.ToList();

            return aa;
        }
    }
}
