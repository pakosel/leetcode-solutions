using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SetMismatch
{
    public class Solution_2024
    {
        public int[] FindErrorNums(int[] nums)
        {
            var res = new int[2];
            var len = nums.Length;
            var arr = new int[len + 1];
            foreach (var n in nums)
                if (arr[n] == 0)
                    arr[n]++;
                else
                    res[0] = n;
            for (int i = 1; i <= len; i++)
                if (arr[i] == 0)
                {
                    res[1] = i;
                    break;
                }
            return res;
        }
    }
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            var res = new List<int>();
            var max = 0;
            var set = new HashSet<int>();
            foreach (var n in nums)
            {
                max = Math.Max(max, n);
                if (!set.Contains(n))
                    set.Add(n);
                else
                    res.Add(n);
            }

            var cnt = res.Count;
            if (cnt == 0)
                return res.ToArray();

            for (int i = 1; i <= max; i++)
                if (!set.Contains(i))
                    res.Add(i);
            if (res.Count != 2 * cnt)
                res.Add(max + 1);

            return res.ToArray();
        }
    }
}