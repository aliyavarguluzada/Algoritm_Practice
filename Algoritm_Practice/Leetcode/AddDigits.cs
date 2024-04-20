using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class AddDigits
    {
        public static int AddDigit(int num)
        {
            int k = 0;
            if (num == 10)
                return 1;

            if (num < 10)
                return num;

            while (num >= 10)
            {
                if (num == 10)
                    return 1;

                int n1 = num % 10;
                int s = num - n1;
                int n2 = num / 10;
                k = n1 + n2;
                num = k;
            }
            return k;
        }
    }
}
