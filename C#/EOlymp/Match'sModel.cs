using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.EOlymp
{
    public static class Match_sModel
    {
        public static int matchCount(int n)
        {
            return (n * 12) - (n - 1) * 4;
        }
    }
}
