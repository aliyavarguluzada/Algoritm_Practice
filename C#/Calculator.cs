using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice
{
    public class Calculator
    {
        public int number1, number2;

        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static Calculator operator -(Calculator c1) 
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }
    }
}
