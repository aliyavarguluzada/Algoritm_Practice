using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.EOlymp
{
    public class Digits
    {
        public void DigitCounter()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string a = number.ToString();
            for (int i = 0; i < a.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
