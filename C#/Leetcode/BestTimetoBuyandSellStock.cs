namespace C_.Leetcode
{
    public static class BestTimetoBuyandSellStock
    {
        public static int MaxProfit(int[] prices)
        {


            // Input: prices = [7, 1, 5, 3, 6, 4]
            // Output: 5

            int left = 0;
            int right = 1;
            int MaxProfit = 0;
            int profit = 0;

            while (right <= prices.Length - 1)
            {
                if (prices[left] < prices[right])
                {
                    profit = prices[right] - prices[left];
                    MaxProfit = Math.Max(MaxProfit, profit);
                }
                else
                    left = right;
                right++;


            }


            return MaxProfit;
        }
    }
}
