using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice
{
    public class User
    {
        private float _salary;

        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value - (value * 0.18F);
            }
        }
    }
}
