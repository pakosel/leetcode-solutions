using System.Collections.Generic;
using System.Linq;
using System;

namespace JumpGame
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            var canJump = new bool[nums.Length];
            canJump[0] = true;
            var maxJump = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!canJump[i])
                    continue;
                var from = Math.Max(i + 1, maxJump);
                var to = Math.Min(i + nums[i], nums.Length - 1);
                for (int j = from; j <= to; j++)
                {
                    if (j == nums.Length - 1)
                        return true;
                    canJump[j] = true;
                    maxJump = Math.Max(maxJump, j);
                }
            }
            return canJump[nums.Length - 1];
        }
    }
}