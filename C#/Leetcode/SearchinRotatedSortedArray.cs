namespace C_.Leetcode
{
    public static class SearchinRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            // Input: nums = [4, 5, 6, 7, 0, 1, 2], target = 0
            // Output: 4

            if (nums is null || nums.Length == 0)
                return -1;


            int left = 0;
            int right = nums.Length - 1;



            while (left < right)
            {
                int mid = left + (right - left) / 2;


                if (nums[mid] < nums[right])
                    right = mid;
                else
                    left = mid + 1;

            }

            int start = left;

            left = 0;
            right = nums.Length - 1;

            if (target >= nums[start] && target <= nums[right])
                left = start;
            else
                right = start;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;

            }




            return -1;
        }
    }
}