using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class GreatestCommonDivisor
    {
        public static int GCD(int a, int b)
        {
            int big;
            int small;

            if (a > b)
            {
                big = a;
                small = b;
            }
            else
            {
                big = b;
                small = a;
            }

            for (int i = 1; i < big; i++)
            {
                if (big % (small / i) == 0)
                {
                    return small / i;
                }
            }

            return -1;
        }
    }
}
