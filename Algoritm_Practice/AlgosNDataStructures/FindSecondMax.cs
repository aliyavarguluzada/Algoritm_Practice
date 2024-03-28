using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class FindSecondMax
    {
        public static int secondMax(int[] arr)
        {
            int max = Int32.MinValue;
            int secondMax = Int32.MinValue;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (max < arr[i])
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] != max)
                {
                    secondMax = arr[i];
                }
            }
            return secondMax;
        }
    }
}
