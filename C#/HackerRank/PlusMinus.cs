using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class PlusMinus
    {
        public void plusMinus(List<int> arr)
        {
            int n = arr.Count;
            int count_1 = 0;
            int count_2 = 0;
            int count_3 = 0;

            decimal result_1 = 0;
            decimal result_2 = 0;
            decimal result_3 = 0;

            for (int i = 0; i < arr.Count; i++)
            {

                if (arr[i] == 0)
                    count_1++;

                if (arr[i] < 0)
                    count_2++;

                if (arr[i] > 0)
                    count_3++;


            }
            result_1 = (decimal)count_1 / n;
            result_2 = (decimal)count_2 / n;
            result_3 = (decimal)count_3 / n;

            Console.WriteLine(result_1);
            Console.WriteLine(result_2);
            Console.WriteLine(result_3);
        }

    }
}
