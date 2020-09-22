using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortestCommonSubsequence
{
    public class Solution
    {
        public string ShortestCommonSupersequence(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            string[,] arr = new string[len1, len2];

            arr[0,0] = str1[0] == str2[0] ? str1[0].ToString() : str2[0] + str1[0].ToString();

            for(int i=1; i<len1; i++)
                arr[i,0] = str1[i] == str2[0] ? arr[i-1,0] : arr[i-1,0] + str1[i];
            for(int j=1; j<len2; j++)
                arr[0,j] = str2[j] == str1[0] ? arr[0, j-1] : arr[0, j-1] + str2[j];

            for(int i=1; i<len1; i++)
                for(int j = 1; j<len2; j++)
                {
                    if(str1[i] == str2[j])
                        arr[i,j] = arr[i-1, j-1] + str1[i];
                    else
                    {
                        var left = arr[i-1, j];
                        var top = arr[i, j-1];
                        arr[i, j] = left.Length < top.Length ? left + str1[i] : top + str2[j];
                    }
                }

            for(int i=0; i<len1; i++)
            {
                for(int j=0; j<len2; j++)
                    System.Console.Write($"{arr[i,j]}, ");
                System.Console.WriteLine();
            }


            return arr[len1-1, len2-1];
        }
    }

    public class Solution_Memo
    {
        Dictionary<(string, string), string> memo = new Dictionary<(string, string), string>();

        public string ShortestCommonSupersequence(string str1, string str2)
        {
            return FindMinSubseq(str1, str2);
        }

        private string FindMinSubseq(string s1, string s2)
        {
            if (memo.ContainsKey((s1, s2)))
                return memo[(s1, s2)];
            else if (memo.ContainsKey((s2, s1)))
                return memo[(s2, s1)];

            string val;
            if (s1.Length == 0)
                val = s2;
            else if (s2.Length == 0)
                val = s1;
            else if (s1[0] == s2[0])
                val = s1[0] + FindMinSubseq(s1.Substring(1), s2.Substring(1));
            else
            {
                string sub1 = FindMinSubseq(s1.Substring(1), s2);
                string sub2 = FindMinSubseq(s1, s2.Substring(1));
                val = sub1.Length < sub2.Length ? s1[0] + sub1 : s2[0] + sub2;
            }

            memo.Add((s1, s2), val);
            return val;
        }
    }
}