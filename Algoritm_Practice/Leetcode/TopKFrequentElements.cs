namespace Algoritm_Practice.Leetcode
{
    public static class TopKFrequentElements
    {
        // arr = [1, 1, 1, 2, 2, 2, 3, 3, 3, 3]
        public static int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == 1)
                return nums;

            Dictionary<int, int> values = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int count = nums.Count(c => c == nums[i]);


                if (values.ContainsKey(nums[i]))
                    values[nums[i]] = count;
                else
                    values.Add(nums[i], count);
            }

            var topKeys = values.OrderByDescending(x => x.Value)
                                .Take(k)
                                .Select(x => x.Key)
                                .ToArray();

            return topKeys;
        }
    }
}
