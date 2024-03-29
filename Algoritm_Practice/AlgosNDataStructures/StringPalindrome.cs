using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class StringPalindrome
    {
        public static bool isPalindrome(string word)
        {
            char[] chars = word.ToCharArray();

            int start = 0;
            int end = chars.Length - 1;

            while (start < end)
            {
                if (chars[start] == chars[end])
                {
                    return true;
                }
                start++;
                end--;
            }

            return false;
        }
    }
}
