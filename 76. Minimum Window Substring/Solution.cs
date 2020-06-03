using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumWindowSubstring
{
    public class Solution
    {
        //Incomplete solution
        //works only if t contains unique characters
        public string MinWindow(string s, string t)
        {
            int lenS = s.Length;
            int lenT = t.Length;
            int minWin = int.MaxValue;
            string res = "";

            int[,] arr = new int[lenS + 1, lenT];

            for (int i = 0; i < lenT; i++)
                arr[0, i] = -1;
            for (int j = 1; j <= lenS; j++)
            {
                int min = int.MaxValue;
                int max = -1;
                for (int i = 0; i < lenT; i++)
                {
                    if (s[j - 1] == t[i])
                        arr[j, i] = j - 1;
                    else
                        arr[j, i] = arr[j - 1, i];

                    min = Math.Min(min, arr[j, i]);
                    max = Math.Max(max, arr[j, i]);
                }
                if (min != -1 && max != -1)
                {
                    int candidate = max - min + 1;
                    if (candidate < minWin)
                    {
                        minWin = candidate;
                        res = s.Substring(min, minWin);
                    }
                }
            }

            return res;
        }
    }
}