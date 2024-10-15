using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.GrokkingAlgorithms
{
    public static class LinearSearch
    {
        public static bool linearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return true;
            }
            return false;
        }
    }
}
