using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class Pow_x__n_
    {
        public static double MyPow(double x, int n)
        {
            double power = 1;

            if (n == 0)
                return 1;

            if (n < 0)
                n = 0 - n;

            for (int i = 0; i < n; i++)
            {

                if (n < 0)
                {
                    power /= x;

                }
                else
                {

                    power *= x;
                }


            }

            return power;
        }
    }
}
