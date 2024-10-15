using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class BirthdayCakeCandles
    {
        public int birthdayCakeCandles(List<int> candles)
        {
            int tallestCandles = 0;

            int tallestCandle = candles.Max();

            tallestCandles = candles.Count(c => c == tallestCandle);
            Console.WriteLine(tallestCandle);

            Console.WriteLine(tallestCandles);
            return tallestCandles;
        }
    }
}
