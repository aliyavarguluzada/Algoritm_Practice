namespace C_.Leetcode
{
    public static class FindMinimuminRotatedSortedArray
    {
        public static int FindMin(int[] nums)
        {


            int min = nums[0];


            // Array.Sort(nums);
            // return nums[0]; this is shortest solution not optimized neither is the one below


            for (int i = 0; i < nums.Length; i++)
            {
                for (global::System.Int32 j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < min)
                    {
                        min = nums[i];
                    }
                }
            }

            return min;
        }


        public static int FindMinOp(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return nums[left];
        }
    }

}
