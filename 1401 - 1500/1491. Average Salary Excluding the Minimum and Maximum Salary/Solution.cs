using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AverageSalaryExcludingTheMinimumAndMaximumSalary
{
    public class SolutionLinq
    {
        public double Average(int[] salary) =>
            salary.Where(s => s != salary.Min() && s != salary.Max()).Average();
    }

    public class Solution
    {
        public double Average(int[] salary)
        {
            var min = Math.Min(salary[0], salary[1]);
            var max = Math.Max(salary[0], salary[1]);
            long sum = 0;
            for (int i = 2; i < salary.Length; i++)
                if (salary[i] < min)
                {
                    sum += min;
                    min = salary[i];
                }
                else if (salary[i] > max)
                {
                    sum += max;
                    max = salary[i];
                }
                else
                    sum += salary[i];
            return (double)sum / (salary.Length - 2);
        }
    }
}