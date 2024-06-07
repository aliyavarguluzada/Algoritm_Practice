namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class StringPalindrome
    {
        public static bool isPalindrome(string word)
        {
            char[] chars = word.ToCharArray();

            int start = 0;
            int end = chars.Length - 1;

            bool a = false;

            while (start < end)
            {
                if (chars[start] == chars[end])
                {
                    a = true;
                }
                else
                {
                    return false;
                }
                start++;
                end--;
            }

            return a;
        }
    }
}
