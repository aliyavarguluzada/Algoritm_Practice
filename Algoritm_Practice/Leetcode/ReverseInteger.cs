using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            // Example 1:

            // Input: x = 123
            // Output: 321
            // Example 2:

            // Input: x = -123
            // Output: -321
            // Example 3:

            // Input: x = 120
            // Output: 21
            //if(x % 10 == 0)

            int num = 0;

            if (x == 10)
                return 1;
            else if (x == -10)
                return -1;

            if (x % 10 == x && x != 10)
                return x;

            if (x > 0)
            {

                int x4 = x % 10; // 1

                int x3 = ((x - x4) - x4) / 10 + 1;

                int x2 = x3 % 10; // 2 

                int x1 = (x3 - x2) / 10; // 3

                // x4 x2 x1

                num = x4 * 100 + x2 * 10 + x1;
                x = num;
                if (x4 == 0)
                    return x - 10;

            }
            else
            {
                x = 0 - x;

                int x4 = x % 10; // 1

                int x3 = ((x - x4) - x4) / 10 + 1;

                int x2 = x3 % 10; // 2 

                int x1 = (x3 - x2) / 10; // 3

                // x4 x2 x1

                num = x4 * 100 + x2 * 10 + x1;
                x = 0 - num;
                if (x4 == 0)
                    return x + 10;

            }







            return x;

            return x;
        }
    }
}
