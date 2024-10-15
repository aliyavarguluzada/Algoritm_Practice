using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class TimeConversion
    {

        public string timeConversion(string s)
        {
            int hours = int.Parse(s.Substring(0, 2));
            int minutes = int.Parse(s.Substring(3, 2));
            int seconds = int.Parse(s.Substring(6, 2));

            string amp = s.Substring(8, 2);

            if (amp == "PM" && hours != 12)
            {
                hours += 12;
            }
            else if (amp == "AM" && hours == 12)
            {
                hours = 0;
            }
            string result = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

            Console.WriteLine(result);

            return result;
        }

    }
}
