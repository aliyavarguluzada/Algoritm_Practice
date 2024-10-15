using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class ResizeArray
    {
        public static int[] resize(int[] arr, int capacity)
        {
            int[] temp = new int[capacity];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            
            arr = temp;

            return arr;
        }
    }
}
