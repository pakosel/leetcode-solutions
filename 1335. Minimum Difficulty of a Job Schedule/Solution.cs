using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumDifficultyOfJobSchedule
{
    public class Solution
    {
        private Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();

        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            return Helper(jobDifficulty, d, 0);
        }

        private int Helper(int[] arr, int d, int left)
        {
            if (memo.ContainsKey((left, d)))
                return memo[(left, d)];
            int res = 0;
            int len = arr.Length;
            if (left == len - 1)
                res = d == 1 ? arr[left] : -1;
            else if (d > len - left)
                res = -1;
            else if (d == 1)
            {
                res = arr[left];
                for (int i = left + 1; i < len; i++)
                    if (arr[i] > res)
                        res = arr[i];
            }
            else
            {
                int max_left = arr[left];
                int min = int.MaxValue;
                for (int i = left; i < len - 1; i++)
                {
                    if (arr[i] > max_left)
                        max_left = arr[i];
                    int temp = Helper(arr, d - 1, i + 1);
                    if (temp != -1)
                        min = Math.Min(min, max_left + temp);
                }
                res = min == int.MaxValue ? -1 : min;
            }

            memo.Add((left, d), res);
            return res;
        }
    }
}