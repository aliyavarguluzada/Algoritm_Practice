using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class FindTheIndexOfTheFirstOccurrenceInaString
    {
        public static int StrStr(string haystack, string needle)
        {
            // Example 1:

            // Input: haystack = "sadbutsad", needle = "sad"
            // Output: 0
            // Explanation: "sad" occurs at index 0 and 6.
            // The first occurrence is at index 0, so we return 0.

            // Example 2:

            // Input: haystack = "leetcode", needle = "leeto"
            // Output: -1
            // Explanation: "leeto" did not occur in "leetcode", so we return -1.


            return haystack.IndexOf(needle); // this is the easy solution

        }
    }
}
