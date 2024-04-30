using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class LeastCommonMultiple
    {
        public static int LCM(int a, int b)
        {
            int big;
            int small;

            if (a % b == 0)
                return a;
            if (b % a == 0)
                return b;

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

            for (int i = 2; i < big; i++)
            {
                if ((big * i) % small == 0)
                    return big * i;
            }

            return -1;
        }
    }
}
