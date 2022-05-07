using System.Collections.Generic;
using System.Linq;
using System;

namespace EditDistance
{
    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;

            if (len1 == 0)
                return len2;
            if (len2 == 0)
                return len1;

            int[,] arr = new int[len1 + 1, len2 + 1];

            for (int i = 0; i <= len1; i++)
                arr[i, 0] = i;

            for (int j = 0; j <= len2; j++)
                arr[0, j] = j;

            for (int i = 1; i <= len1; i++)
                for (int j = 1; j <= len2; j++)
                {
                    int diag = arr[i - 1, j - 1];

                    if (word1[i - 1] == word2[j - 1])
                        arr[i, j] = diag;
                    else
                    {
                        int top = arr[i - 1, j];
                        int left = arr[i, j - 1];
                        int min = Math.Min(Math.Min(top, left), diag);
                        arr[i, j] = min + 1;
                    }
                }

            return arr[len1, len2];
        }
    }
}