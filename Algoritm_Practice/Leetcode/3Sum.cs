namespace Algoritm_Practice.Leetcode
{
    public static class _3Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            //  nums = [-1, 0, 1, 2, -1, -4];

            if (nums == null || nums.Length < 3)
                return new List<IList<int>>();

            Array.Sort(nums);


            HashSet<Tuple<int, int, int>> result = new HashSet<Tuple<int, int, int>>();



            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;

                int right = nums.Length - 1;


                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(Tuple.Create(nums[i], nums[left], nums[right]));

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                        left++;
                    else
                        right--;


                }

            }

            List<IList<int>> res = result
                                 .Select(t => new List<int> { t.Item1, t.Item2, t.Item3 })
                                 .Cast<IList<int>>()
                                 .ToList();

            return res;
        }

        public class Solution
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                Array.Sort(nums);
                IList<IList<int>> res = new List<IList<int>>();
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                    {
                        int lo = i + 1, hi = nums.Length - 1, sum = 0 - nums[i];
                        while (lo < hi)
                        {
                            if (nums[lo] + nums[hi] == sum)
                            {
                                res.Add(new List<int> { nums[i], nums[lo], nums[hi] });
                                while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
                                while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
                                lo++;
                                hi--;
                            }
                            else if (nums[lo] + nums[hi] < sum) lo++;
                            else hi--;
                        }
                    }
                }
                return res;
            }
        }

    }
}
