using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CountOfSmallerNumbersAfterSelf
{
    public class Solution
    {
        public IList<int> CountSmaller(int[] nums)
        {
            var len = nums.Length;
            var res = new int[len];
            var list = new List<int>(len);

            for (int i = len - 1; i >= 0; i--)
                res[i] = Put(nums[i]);

            return res;

            int Put(int val)
            {
                var pos = list.BinarySearch(val);
                if (pos < 0)
                    pos = ~pos;
                else    //skip the same values
                    while (pos > 0 && list[pos - 1] == val)
                        pos--;

                list.Insert(pos, val);
                return pos;
            }
        }
    }
}