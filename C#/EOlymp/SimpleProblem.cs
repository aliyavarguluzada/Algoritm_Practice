using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.EOlymp
{
    public class SimpleProblem
    {
        public void ReturnNumber()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1}", (int)number / 10, (int)number % 10);
        }
    }
}
