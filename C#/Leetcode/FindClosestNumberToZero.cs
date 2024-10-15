namespace Algoritm_Practice.Leetcode
{
    public static class FindClosestNumberToZero
    {
        public static int FindClosestNumber(int[] nums)
        {
            //nums = [-4, -2, 1, 4, 8]
            //nums = [-1, 1]

            int closest = nums[0];

            foreach (int num in nums)
            {
                if (Math.Abs(num) < Math.Abs(closest))
                    closest = num;
            }


            if (closest < 0 && nums.Contains(Math.Abs(closest)))
            {
                return Math.Abs(closest);
            }
            else
            {
                return closest;
            }

        }

    }
}
