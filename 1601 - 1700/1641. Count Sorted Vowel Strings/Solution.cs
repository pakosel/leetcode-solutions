using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountSortedVowelStrings
{
    public class Solution
    {
        public int CountVowelStrings(int n)
        {
            var helper = Helper(n);
            return helper[0];
        }

        private int[] Helper(int n)
        {
            if (n == 1)
                return new int[5] { 5, 4, 3, 2, 1 };
            var prev = Helper(n - 1);
            for (int i = 3; i >= 0; i--)
                prev[i] += prev[i + 1];
            return prev;
        }
    }
}