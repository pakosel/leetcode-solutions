using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace JumpGameIII
{
    public class Solution
    {
        Dictionary<int, bool> memo = new Dictionary<int, bool>();

        public bool CanReach(int[] arr, int start)
        {
            if (memo.ContainsKey(start))
                return memo[start];
            bool res = false;
            memo.Add(start, res);   //to avoid cycles

            if (arr[start] == 0)
                res = true;
            else
            {
                int offset = arr[start];
                if (start + offset < arr.Length)
                    res = CanReach(arr, start + offset);
                if (!res && start - offset >= 0)
                    res = CanReach(arr, start - offset);
            }

            memo[start] = res;
            return res;
        }
    }
}