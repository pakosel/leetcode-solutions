using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestPalindromicSubsequence
{
    public class Solution
    {
        public int LongestPalindromeSubseq(string s)
        {
            int len = s.Length;
            int[,] arr = new int[len,len];

            int offset=0;
            for(int i=0; i<len; i++, offset++)
            {
                int x=0;
                for(int y=offset; y<len; y++, x++)
                {
                    int val = 0;
                    if(x == y)
                        val = 1;
                    else if(s[x] == s[y])
                        val = 2 + arr[x+1,y-1];
                    else
                        val = Math.Max(arr[x,y-1], arr[x+1,y]);
                    arr[x,y] = val;
                }
            }

            // for(int i=0; i<len; i++)
            // {
            //     for(int j=0; j<len; j++)
            //         System.Console.Write($"{arr[i,j]},");
            //     System.Console.WriteLine();
            // }

            return arr[0,len-1];
        }
    }

    public class SolutionMemoization
    {
        Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();

        public int LongestPalindromeSubseq(string s)
        {
            return Helper(s, (0, s.Length - 1));
        }

        private int Helper(string s, (int, int) range)
        {
            if (memo.ContainsKey(range))
                return memo[range];

            int res = 0;
            bool equals = s[range.Item1] == s[range.Item2];
            int dist = range.Item2 - range.Item1;

            if (dist == 0)
                res = 1;
            else if (dist == 1)
                res = equals ? 2 : 1;
            else
                res = equals ?
                        2 + Helper(s, (range.Item1 + 1, range.Item2 - 1)) :
                        Math.Max(Helper(s, (range.Item1, range.Item2 - 1)), Helper(s, (range.Item1 + 1, range.Item2)));

            memo.Add(range, res);
            return res;
        }
    }
}