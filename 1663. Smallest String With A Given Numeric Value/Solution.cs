using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SmallestStringWithGivenNumericValue
{
    public class Solution
    {
        public string GetSmallestString(int n, int k)
        {
            var arr = new char[n];
            while (n > 0)
            {
                var last = Math.Min(k - n + 1, 26);
                arr[n - 1] = (char)('a' + last - 1);
                k -= last;
                n--;
            }

            return string.Join(null, arr);
        }
    }

}