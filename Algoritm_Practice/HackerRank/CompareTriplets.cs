using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class CompareTriplets
    {
        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int>();
            int bob = 0;
            int alice = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (a[i] < b[i])
                {
                    bob++;
                }

            }
            score.Add(alice);
            score.Add(bob);

            return score;

        }

    }
}
