namespace Algoritm_Practice.Leetcode
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int maxArea = 0; // area = width (right - left) * height (Min(left, right))


            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);

                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return maxArea;
        }
    }
}
