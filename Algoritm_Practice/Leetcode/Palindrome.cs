using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class Palindrome
    {
        public static bool isPalindrome(int x)
        {
            int temp = x;

            int remainder = 0;
            int sum = 0;

            while (x > 0)
            {
                remainder = x % 10;
                sum = (sum * 10) + remainder;
                x = x / 10;
            }
            if (temp == sum)
                return true;

            return false;
        }
    }
}
