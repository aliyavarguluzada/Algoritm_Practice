using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.Leetcode
{
    public static class FibonacciNumber
    {
        public static int Fib(int n)
        {
            // F(0) = 0, F(1) = 1
            // F(n) = F(n - 1) + F(n - 2), for n > 1.

            int f = (n - 1) + (n - 2);


            return f;
        }
    }
}
