namespace Algoritm_Practice.Leetcode
{
    public static class FibonacciNumber
    {
        public static int Fib(int n)
        {
            // F(0) = 0, F(1) = 1
            // F(n) = F(n - 1) + F(n - 2), for n > 1.

            return n < 2 ? n : Fib(n - 1) + Fib(n - 2); // recursive solution
        }

        public static int FibIt(int n)
        {

            if (n < 2)
                return n;

            int previous = 0;
            int next = 1;


            for (int i = 1; i < n; i++) // you can start from 2 and make i <= n because of if statement above but this one has better memory performance and similar speed 
            {
                int sequenceNumber = previous + next;

                previous = next;
                next = sequenceNumber;

            }
            return next;

        }
    }
}
