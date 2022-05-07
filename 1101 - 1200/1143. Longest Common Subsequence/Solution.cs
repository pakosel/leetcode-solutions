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

            if(text1[0] == text2[0])
                arr[0,0] = 1;

            //initialize first row and first column
            for(int i=1; i<len1; i++)
                arr[i, 0] = arr[i-1, 0] == 1 || text1[i] == text2[0] ? 1 : 0;
            for(int j=1; j<len2; j++)
                arr[0,j] = arr[0,j-1] == 1 || text1[0] == text2[j] ? 1 : 0;

            for (int i = 1; i < len1; i++)
                for (int j = 1; j < len2; j++)
                    if (text1[i] == text2[j])
                        arr[i, j] = 1 + arr[i - 1, j - 1];
                    else
                        arr[i, j] = arr[i, j - 1] > arr[i - 1, j] ? arr[i, j - 1] : arr[i - 1, j];

            return arr[len1 - 1, len2 - 1];
        }
    }
}