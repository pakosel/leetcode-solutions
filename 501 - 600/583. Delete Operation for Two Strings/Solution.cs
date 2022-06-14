using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DeleteOperationForTwoStrings
{
    public class SolutionDP
    {
        public int MinDistance(string word1, string word2)
        {
            var len1 = word1.Length;
            var len2 = word2.Length;

            var dp = Enumerable.Range(0, len2+1).Select(_ => new int[len1+1]).ToArray();
            
            for(int i=1; i<=len2; i++)
                for(int j=1; j<=len1; j++)
                    if(word2[i-1] == word1[j-1])
                        dp[i][j] = dp[i-1][j-1] + 1;
                    else
                        dp[i][j] = Math.Max(dp[i-1][j], dp[i][j-1]);
            
            //length of maximum common subsequence
            var maxCommon = dp[len2][len1];
            
            return len1 + len2 - 2*maxCommon;            
        }
    }

    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;
            if(len1 == 0)
                return len2;
            if(len2 == 0)
                return len1;

            int[,] arr = new int[len1, len2];

            arr[0,0] = word1[0] == word2[0] ? 0 : 2;
            bool done = arr[0,0] == 0;

            for(int i=1; i<len1; i++)
                if(word1[i] == word2[0] && !done)
                {
                    arr[i, 0] = arr[i-1, 0] - 1;
                    done = true;
                }
                else
                    arr[i, 0] = arr[i-1, 0] + 1;

            done = arr[0,0] == 0;
            for(int j=1; j<len2; j++)
                if(word1[0] == word2[j] && !done)
                {
                    arr[0, j] = arr[0, j-1] - 1;
                    done = true;
                }
                else
                    arr[0, j] = arr[0, j-1] + 1;

            for(int i=1; i<len1; i++)
                for(int j=1; j<len2; j++)
                    if(word1[i] == word2[j])
                        arr[i, j] = arr[i-1, j-1];
                    else
                        arr[i,j] = Math.Min(arr[i-1, j], arr[i, j-1]) + 1;
            
            return arr[len1-1, len2-1];
        }
    }

    public class Solution_Memoization
    {
        Dictionary<(string, string), int> memo = new Dictionary<(string, string), int>();

        public int MinDistance(string word1, string word2)
        {
            return Helper(word1, word2);
        }

        private int Helper(string s1, string s2)
        {
            if (memo.ContainsKey((s1, s2)))
                return memo[(s1, s2)];
            else if (memo.ContainsKey((s2, s1)))
                return memo[(s2, s1)];
            
            int res;
            int len1 = s1.Length;
            int len2 = s2.Length;

            if (len1 == 0)
                res = len2;
            else if (len2 == 0)
                res = len1;
            else if (s1[0] == s2[0])
                res = Helper(s1.Substring(1), s2.Substring(1));
            else
            {
                int v1 = Helper(s1.Substring(1), s2);
                int v2 = Helper(s1, s2.Substring(1));
                res = 1 + Math.Min(v1, v2);
            }

            memo.Add((s1, s2), res);
            return res;
        }
    }
}