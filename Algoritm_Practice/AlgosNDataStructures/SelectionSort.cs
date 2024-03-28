using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.GrokkingAlgorithms
{
    public class SelectionSort
    {
        public int[] selectionSort(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[minIndex];

                array[minIndex] = array[i];
                array[i] = temp;
            }

            return array;
        }
    }
}
