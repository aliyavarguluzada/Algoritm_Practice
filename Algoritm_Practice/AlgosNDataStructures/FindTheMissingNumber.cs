using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class FindTheMissingNumber
    {
        public static int Find(int[] arr)
        {

            // Sum of first natural numbers S = n(n + 1)/2

            int n = arr.Length;

            int sum = n * (n + 1) / 2;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum = sum - arr[i];
            //}
            foreach (int num in arr)
            {
                sum = sum - num;
            }
            return sum;
        }
    }
}
