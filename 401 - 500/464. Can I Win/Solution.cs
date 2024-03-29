using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CanIWin
{
    public class Solution
    {
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            if (maxChoosableInteger * (maxChoosableInteger + 1) / 2 < desiredTotal)
                return false;

            var memo = new Dictionary<(int intMask, int tgt), bool>();
            var allNumsMask = (1 << maxChoosableInteger) - 1;

            return CanWin(allNumsMask, desiredTotal);

            bool CanWin(int numsMask, int target)
            {
                if (memo.ContainsKey((numsMask, target)))
                    return memo[(numsMask, target)];

                var res = false;
                for (int i = 1; i <= maxChoosableInteger; i++)
                    if (((1 << i-1) & numsMask) != 0)     //we can use this integer
                        if (i >= target || 
                            !CanWin((1 << i-1) ^ numsMask, target - i))     //turn off bit for i-th integer and check recursively
                        {
                            res = true;
                            break;
                        }

                memo.Add((numsMask, target), res);
                return res;
            }
        }
    }
}