using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class FindMin
    {
        public static int min(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (min > arr[i + 1])
                {
                    min = arr[i + 1];
                }

            }
            return min;
        }
    }
}
