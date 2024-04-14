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

            string s1 = new string(ss);
            string s2 = new string(tt);

            //if (
                //return true;


            return false;
        }
    }
}
