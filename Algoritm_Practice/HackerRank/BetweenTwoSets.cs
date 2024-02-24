using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class BetweenTwoSets
    {
        public int getTotalX(List<int> a, List<int> b)
        {

            // [2, 6], [24, 36] => (6, 12)
            // [2, 4], [16, 32, 36] => (4, 8, 16)

            int x1 = a.Max();

            int x2 = 1;

            foreach (int x in a)
            {
                x2 *= x;
            }
            int z = 0;

            int count1 = 0;
            int count2 = 0;

            if (x1 != 0)
                count1++;
            if (x2 != 0)
                count1++;

            int min = b.Min();
            
            foreach (int y in b)
            {
                FactorFinder(b[y]);
                if (y % min == 0)
                    z = min;
            }


            int result = count1 + count2;

            return result;
        }
        public List<int> FactorFinder(int number)
        {
            List<int> result = new List<int>();

            for (int factor = 1; factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    result.Add(factor);
                }
            }

            return result;
        }
    }
}
