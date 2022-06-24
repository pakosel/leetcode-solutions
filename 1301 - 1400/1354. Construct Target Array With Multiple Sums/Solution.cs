using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ConstructTargetArrayWithMultipleSums
{
    public class Solution
    {
        public bool IsPossible(int[] target)
        {
            var heap = new SortedSet<long>();
            long sum = 0;
            foreach (var e in target)
            {
                heap.Add(e);
                sum += e;
            }

            while (heap.Count > 1)
            {
                var max = heap.Max;
                heap.Remove(max);
                sum -= max;
                if (heap.Count == 1)
                {
                    if(sum == 0 || sum >= max)
                        return false;
                    if(sum == 1)
                        return true;
                    max = max % sum;
                }
                else
                    max -= sum;

                if (max > 1 && heap.Contains(max))
                    return false;
                sum += max;
                heap.Add(max);
            }

            return heap.Max == 1;
        }
    }
}