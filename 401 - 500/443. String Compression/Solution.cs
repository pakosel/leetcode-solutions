using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace StringCompression
{
    public class Solution
    {
        public int Compress(char[] chars)
        {
            var resIdx = 0;
            var idx = 0;
            var prevIdx = 0;
            while (idx < chars.Length)
            {
                while (idx + 1 < chars.Length && chars[idx + 1] == chars[prevIdx])
                    idx++;
                chars[resIdx++] = chars[prevIdx];
                var cnt = idx - prevIdx + 1;
                if (cnt > 1)
                {
                    var lst = NumToList(cnt);
                    foreach (var i in lst)
                        chars[resIdx++] = (char)(i + '0');
                }
                idx++;
                prevIdx = idx;
            }

            return resIdx;

            List<int> NumToList(int num)
            {
                var lst = new List<int>();
                while (num > 0)
                {
                    lst.Add(num % 10);
                    num /= 10;
                }
                lst.Reverse();
                return lst;
            }
        }
    }
}