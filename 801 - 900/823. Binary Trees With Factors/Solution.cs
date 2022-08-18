using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BinaryTreesWithFactors
{
    public class Solution
    {
        public int NumFactoredBinaryTrees(int[] arr)
        {
            const int MOD = 1_000_000_007;
            var memo = new Dictionary<int, long>(arr.Length);

            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                long res = 1;
                var curr = arr[i];
                for (int j = 0; j < i; j++)
                {
                    var div = (int)(curr / arr[j]);
                    if (arr[j] * div == curr && memo.ContainsKey(div))
                        res += (arr[j] == div ? memo[div] * memo[div] : memo[div] * memo[arr[j]]);
                    // res %= MOD;
                }
                memo.Add(curr, res);
            }

            long sum = 0;
            foreach (var kvp in memo)
            {
                sum += kvp.Value;
                sum %= MOD;
            }
            return (int)sum;
        }
    }
}