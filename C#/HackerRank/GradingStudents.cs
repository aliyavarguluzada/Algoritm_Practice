using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice.HackerRank
{
    public class GradingStudents
    {
        public List<int> gradingStudents(List<int> grades)
        {
            List<int> newGrades = new List<int>();


            foreach (int grade in grades)
            {
                int round = (int)Math.Ceiling(grade / 5.0) * 5;

                if (grade < 38 || round - grade >= 3)
                {
                    newGrades.Add(grade);
                }
                else
                {
                    newGrades.Add(round);
                }

            }


            return newGrades;
        }
    }
}
