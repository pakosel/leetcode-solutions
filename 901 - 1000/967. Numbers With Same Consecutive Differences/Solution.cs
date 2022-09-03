using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace NumbersWithSameConsecutiveDifferences
{
    public class Solution
    {
        public int[] NumsSameConsecDiff(int n, int k)
        {
            var q = new Queue<int>();
            for (int i = 1; i < 10; i++)
                q.Enqueue(i);
            while (n-- > 1)
            {
                var cnt = q.Count;
                for (int i = 0; i < cnt; i++)
                {
                    var curr = q.Dequeue();
                    var lastDigit = curr % 10;
                    if (lastDigit + k < 10)
                        q.Enqueue(curr * 10 + lastDigit + k);
                    if (lastDigit - k >= 0)
                        q.Enqueue(curr * 10 + lastDigit - k);
                }
            }
            return q.Distinct().ToArray();
        }
    }
}