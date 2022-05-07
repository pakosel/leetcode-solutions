using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SplitArrayLargestSum
{
    public class Solution
    {
        int[][] memo = new int[1001][];

        public int SplitArray(int[] nums, int m)
        {
            for (int i = 0; i < 1001; i++)
            {
                memo[i] = new int[51];
                Array.Fill(memo[i], -1);
            }

            var len = nums.Length;
            var arr = new int[len][];
            for (int i = 0; i < len; i++)
            {
                arr[i] = new int[len];
                for (int j = i; j < len; j++)
                    arr[i][j] = (i == j ? nums[j] : arr[i][j - 1] + nums[j]);
            }

            return Helper(arr, m, 0);
        }

        private int Helper(int[][] arr, int m, int start)
        {
            var len = arr.Length;

            if (m == 1)
                return arr[start][len - 1];

            if (memo[start][m] != -1)
                return memo[start][m];

            var res = int.MaxValue;
            for (int i = 0; i < len - 1; i++)
                res = Math.Min(res, Math.Max(arr[start][i], Helper(arr, m - 1, i + 1)));
            memo[start][m] = res;

            return res;
        }
    }
}