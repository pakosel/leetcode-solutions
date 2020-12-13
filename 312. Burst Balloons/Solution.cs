using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BurstBalloons
{
    public class Solution
    {
        Dictionary<List<int>, int> dict = new Dictionary<List<int>, int>(new ListComparer());

        public int MaxCoins(int[] nums)
        {
            return GetMax(nums.ToList());
        }

        private int GetMax(List<int> nums)
        {
            if (dict.ContainsKey(nums))
                return dict[nums];

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

                    var subList = new List<int>(nums);
                    subList.RemoveAt(i);
                    int curr = prev * nums[i] * next + GetMax(subList);
                    res = Math.Max(res, curr);
                }
            }
            dict.Add(nums, res);
            return res;
        }
    }
}