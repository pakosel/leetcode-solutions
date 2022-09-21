using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace SumOfEvenNumbersAfterQueries
{
    public class Solution
    {
        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            var res = new List<int>(queries.Length);

            var sumEven = nums.Where(n => n % 2 == 0).Sum();
            foreach (var q in queries)
            {
                var i = q[1];
                if (nums[i] % 2 == 0)
                    sumEven -= nums[i];
                nums[i] += q[0];
                if (nums[i] % 2 == 0)
                    sumEven += nums[i];
                res.Add(sumEven);
            }
            return res.ToArray();
        }
    }
}