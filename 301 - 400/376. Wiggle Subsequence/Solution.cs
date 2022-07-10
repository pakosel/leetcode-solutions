using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace WiggleSubsequence
{
    public class Solution
    {
        public int WiggleMaxLength(int[] nums)
        {
            var len = nums.Length;
            //0 = inc., 1 = dec. from the given index
            var memo = Enumerable.Range(0, len).Select(_ => new int[2]).ToArray();
            var res = 0;
            res = Math.Max(Dfs(0, 0), Dfs(0, 1));
            return res;

            int Dfs(int i, int pos)
            {
                if (memo[i][pos] != 0)
                    return memo[i][pos];
                var res = 1;
                for (int x = i + 1; x < len; x++)
                    if (pos == 0 && nums[i] < nums[x])
                        res = Math.Max(res, 1 + Dfs(x, 1));
                    else if (pos == 1 && nums[i] > nums[x])
                        res = Math.Max(res, 1 + Dfs(x, 0));

                memo[i][pos] = res;

                return res;
            }
        }
    }
}