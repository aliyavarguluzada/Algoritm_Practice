﻿namespace Algoritm_Practice.Leetcode
{
    public static class TwoSumIIInputArrayIsSorted
    {
        public static int[] TwoSum(int[] numbers, int target)
        {

            // nums = [2, 7, 11, 15] target = 9;
            // nums = [2, 3, 4] target = 6;


            int[] result = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        result[0] = i + 1;
                        result[1] = j + 1;
                    }
                }
            }

            return result;
        }


        public static int[] TwoSumOp(int[] numbers, int target)
        {

            int left = 0;
            int right = numbers.Length - 1;


            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                    return new int[] { left + 1, right + 1 };
                else if (numbers[left] + numbers[right] < target)
                    left++;
                else
                    right--;
            }

            return new int[] { };

        }
    }
}
