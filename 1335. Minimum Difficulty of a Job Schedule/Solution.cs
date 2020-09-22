using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumDifficultyOfJobSchedule
{
    public class Solution
    {
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            int forward = FindDifficulty(jobDifficulty, d);
            Array.Reverse(jobDifficulty);
            int backward = FindDifficulty(jobDifficulty, d);
            
            return Math.Min(forward, backward);
        }

        private int FindDifficulty(int[] jobDifficulty, int d)
        {
            int len = jobDifficulty.Length;

            if(d > len)
                return -1;
            int[,] arr = new int[d,len];

            arr[0,0] = jobDifficulty[0];
            for(int i=1;i<len;i++)
                arr[0,i] = Math.Max(arr[0,i-1], jobDifficulty[i]);
            
            for(int j=1; j<d; j++)
                for(int i=j; i<len; i++)
                    if(i == j)
                        arr[j, i] = arr[j-1, i-1] + jobDifficulty[i];
                    else
                        arr[j, i] = Math.Min(arr[j-1, i-1], arr[j, i-1]) + jobDifficulty[i];

            return arr[d-1,len-1];
        }
    }

    public class Solution_Memoization
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