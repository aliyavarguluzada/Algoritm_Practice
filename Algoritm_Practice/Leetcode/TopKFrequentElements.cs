namespace Algoritm_Practice.Leetcode
{
    public static class TopKFrequentElements
    {
        // arr = [1, 1, 1, 2, 2, 2, 3, 3, 3, 3]
        public static int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == 1)
                return nums;

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            var topKeys = frequency.OrderByDescending(x => x.Value)
                    .Take(k)
                    .Select(x => x.Key)
                    .ToArray();

            return topKeys;
        }
    }
}
