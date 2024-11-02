namespace C_.Leetcode
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            // Input: s = "abcabcbb"
            // Output: 3
            // Input: s = "pwwkew"
            // Output: 3


            int left = 0;
            int right = 0;
            int max = 0;

            HashSet<char> chars = new HashSet<char>(26);

            while (left < s.Length)
            {
                if (!chars.Contains(s[right]))
                {
                    chars.Add(s[right]);
                    right++;
                    max = Math.Max(chars.Count, max);
                }
                else
                {
                    chars.Remove(s[left]);
                    left++;
                }
            }


            return max;
        }
    }
}
