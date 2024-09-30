namespace Algoritm_Practice.Leetcode
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            // Input: nums = [1, 2, 3, 4]
            // Output: [24, 12, 8, 6]
            // int[] x = [-1, 1, 0, -3, 3];

            int[] k = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                int num = 1;

                if (nums is [0, 0])
                    return nums;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] != 0)
                        num = Product(nums) / nums[i];
                    else
                    {
                        if (nums[j] == 0)
                            continue;
                        num *= nums[j];
                    }
                }

                k[i] = num;
            }
            return k;

        }

        private static int Product(int[] nums)
        {

            return nums.Aggregate(1, (a, b) => a * b);
        }
    }
}
