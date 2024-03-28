using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class FindMax
    {
        public static int max(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (max < arr[i + 1])
                {
                    max = arr[i + 1];
                }

            }
            return max;
        }
    }
}
