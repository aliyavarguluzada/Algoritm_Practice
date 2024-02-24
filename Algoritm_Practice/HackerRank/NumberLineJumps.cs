using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class NumberLineJumps
    {
       public string kangaroo(int x1, int v1, int x2, int v2)
        {

            int s1 = x1 + v1;
            int s2 = x2 + v2;
            if (v1 - v2 == 0)
                return "NO";

            decimal n = (decimal)(s2 - s1) / (v1 - v2);

            if (n >= 0 && n % 1 == 0)
                return "YES";


            if (s1 == s2)
                return "Yes";



            return "NO";

        }
    }
}
