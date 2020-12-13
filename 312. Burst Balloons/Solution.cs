using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BurstBalloons
{
    public class Solution
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        public int MaxCoins(int[] nums)
        {
            return GetMax(nums.ToList());
        }

        private int GetMax(List<int> nums)
        {
            var key = string.Join(',', nums);
            if (dict.ContainsKey(key))
                return dict[key];

            int len = nums.Count;
            int res = 0;
            if (len == 0)
                res = 0;
            else if (len == 1)
                res = nums[0];
            else if (len == 2)
                res = nums[0] * nums[1] + Math.Max(nums[0], nums[1]);
            else
            {
                for (int i = 0; i < len; i++)
                {
                    int prev = i > 0 ? nums[i - 1] : 1;
                    int next = i < len - 1 ? nums[i + 1] : 1;

                    int tmp = nums[i];
                    nums.RemoveAt(i);
                    int curr = prev * tmp * next + GetMax(nums);
                    res = Math.Max(res, curr);
                    nums.Insert(i, tmp);
                }
            }
            dict.Add(key, res);
            return res;
        }
    }
}