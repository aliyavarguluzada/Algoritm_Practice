using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.EOlymp
{
    public static class TwoCircles
    {
        public static int twoCircles(int[] a, int[] b)
        {
            int count = 0;

            int x1 = 0;
            int y1 = 0;
            int r1 = 5;

            int x2 = 5;
            int y2 = 0;
            int r2 = 1;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (a[i] == b[j])
                        count++;
                }
            }

            


            return count;
        }
    }
}
