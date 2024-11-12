using Algoritm_Practice.HackerRank;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class ValidAnagram
    {
        public static bool validAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] ss = s.ToCharArray();
            char[] tt = t.ToCharArray();

            Array.Sort(ss);
            Array.Sort(tt);


            bool a = true;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i] == tt[i])
                    a = true;
                else
                {
                    //a = false;
                    //break; returning false right away is better
                    return false;

                }
            }


            return a;
        }
    }
}
