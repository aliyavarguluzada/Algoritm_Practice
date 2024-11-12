namespace C_.Leetcode
{
    public static class CountOddNumbersinanIntervalRange
    {
        public static int CountOdds(int low, int high)
        {
            int count = (high + 1) / 2 - low / 2;
            return count;
        }
    }
}


