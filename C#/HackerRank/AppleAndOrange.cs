using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class AppleAndOrange
    {
        public void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;
            foreach (int apple in apples)
            {
                int appleLoc = apple + a;
                if (appleLoc >= s && appleLoc <= t)
                {
                    appleCount++;
                }

            }
            foreach (int orange in oranges)
            {
                int orangeLoc = orange + b;
                if (orangeLoc >= s && orangeLoc <= t)
                {
                    orangeCount++;
                }

            }
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);

        }
    }
}
