using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace UniqueBinarySearchTrees
{
    public class Solution
    {
        private int[] memo = new int[20];

        public int NumTrees(int n)
        {
            memo[0] = memo[1] = 1;

            return GetNum(n);
        }

        private int GetNum(int n)
        {
            if (memo[n] != 0)
                return memo[n];

            n--;
            var res = 0;
            for (int i = 0; i <= n; i++)
                res += GetNum(i) * GetNum(n - i);
            memo[n + 1] = res;

            return res;
        }
    }
}