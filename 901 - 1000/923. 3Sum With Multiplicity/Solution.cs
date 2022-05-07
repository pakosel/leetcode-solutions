using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ThreeSumWithMultiplicity
{
    public class Solution
    {
        const int MOD = 1_000_000_007;
        public int ThreeSumMulti(int[] arr, int target)
        {
            var cnt = new int[101];
            for (int i = 2; i < arr.Length; i++)
            {
                var n = arr[i];
                cnt[n]++;
            }

            var res = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (i > 1)
                    cnt[arr[i]]--;
                var curr = new int[101];
                
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (j > 1)
                        curr[arr[j]]++;
                    var lookingFor = target - arr[i] - arr[j];
                    if (lookingFor >= 0 && lookingFor <= 100)
                        res += (cnt[lookingFor] - curr[lookingFor]);
                    if (res > MOD)
                        res %= MOD;
                }
            }
            return res;
        }
    }
}