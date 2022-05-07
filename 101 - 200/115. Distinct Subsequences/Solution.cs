using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DistinctSubsequences
{
    public class Solution
    {
        public int NumDistinct(string s, string t)
        {
            int lenS = s.Length;
            int lenT = t.Length;

            int[,] arr = new int[lenS+1, lenT+1];
            for(int i=0; i<=lenS; i++)
                arr[i,0] = 1;

            for(int i=0; i<lenT; i++)
                for(int j=0; j<lenS; j++)
                    arr[j+1, i+1] = s[j] == t[i] ? arr[j, i] + arr[j, i+1] : arr[j, i+1];

            return arr[lenS, lenT];
        }
    }

    public class Solution_Memo
    {
        Dictionary<(string, string), int> memo = new Dictionary<(string, string), int>();

        public int NumDistinct(string s, string t)
        {
            if (t == "")
                return 1;

            return Helper(s, t);
        }

        private int Helper(string s, string t)
        {
            if (memo.ContainsKey((s, t)))
                return memo[(s, t)];

            int res = 0;
            if (t.Length == 1)
            {
                foreach (var c in s)
                    if (c == t[0])
                        res++;
            }
            else
            {
                int idx = 0;
                while (idx < s.Length)
                {
                    if (s[idx] == t[0])
                    {
                        res = Helper(s.Substring(idx + 1), t.Substring(1)) + Helper(s.Substring(idx + 1), t);
                        break;
                    }
                    idx++;
                }
            }

            memo.Add((s, t), res);
            return res;
        }
    }
}