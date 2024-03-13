using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.GrokkingAlgorithms
{
    public static class BinarySearch
    {
        public static bool binarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                    return true;

                if (array[mid] > target)
                    right = mid - 1;

                if (array[mid] < target)
                    left = mid + 1;

            }

            return false;
        }
    }
}
