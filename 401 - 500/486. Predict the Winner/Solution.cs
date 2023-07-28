using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PredictTheWinner
{
    public class Solution
    {
        public bool PredictTheWinner(int[] nums)
        {
            if (nums.Length < 3)
                return true;

            var memo = new Dictionary<(int l, int r), (int first, int sec)>();

            var maxForFirst = Memo((0, nums.Length - 1)).first;

            return maxForFirst >= nums.Sum() - maxForFirst;

            (int first, int sec) Memo((int l, int r) key)
            {
                if (memo.ContainsKey(key))
                    return memo[key];
                (int, int) res = (0, 0);
                if (key.r - key.l == 1)
                    res = (Math.Max(nums[key.r], nums[key.l]), Math.Min(nums[key.r], nums[key.l]));
                else
                {
                    var takeLeft = Memo((key.l + 1, key.r));
                    var takeRight = Memo((key.l, key.r - 1));
                    if (nums[key.l] + takeLeft.sec > nums[key.r] + takeRight.sec)
                        res = (nums[key.l] + takeLeft.sec, takeLeft.first);
                    else
                        res = (nums[key.r] + takeRight.sec, takeRight.first);
                }

                memo[key] = res;
                return res;
            }
        }
    }
}