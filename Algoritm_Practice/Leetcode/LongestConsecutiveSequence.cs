namespace Algoritm_Practice.Leetcode
{
    public static class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            // nums = [100,4,200,1,3,2]
            // nums = [9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6]

            Array.Sort(nums);

            int sequenceLength = 1;

            if (nums.Length == 1)
                return 1;

            if (nums is [])
                return 0;
            
            if (nums is [0, 0])
                return 1;
            List<int> list = new List<int>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    continue;

                if (nums[i] + 1 == nums[i + 1])
                {
                    sequenceLength++;
                }
                else
                {
                    list.Add(sequenceLength);
                    sequenceLength = 1;
                }
                list.Add(sequenceLength);
            }

            return list.Max();
        }
    }
}
