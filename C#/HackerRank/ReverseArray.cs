using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class ReverseArray
    {
        public static List<int> reverseArray(List<int> a)
        {
            int start = 0;
            int end = a.Count - 1;
            while (start < end)
            {
                int temp = a[start];
                a[start] = a[end];
                a[end] = temp;

                start++;
                end--;
            }

            return a;
        }
    }
}
