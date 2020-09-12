using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestCommonSubsequence
{
    public class Solution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int len1 = text1.Length;
            int len2 = text2.Length;
            int[,] arr = new int[len1, len2];

            for (int i = 0; i < len1; i++)
                for (int j = 0; j < len2; j++)
                    if (text1[i] == text2[j])
                    {
                        int diag = i > 0 && j > 0 ? arr[i - 1, j - 1] : 0;
                        arr[i, j] = 1 + diag;
                    }
                    else
                    {
                        int left = j > 0 ? arr[i, j - 1] : 0;
                        int top = i > 0 ? arr[i - 1, j] : 0;
                        arr[i, j] = left > top ? left : top;
                    }

            return arr[len1 - 1, len2 - 1];
        }
    }
}