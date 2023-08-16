using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SlidingWindowMaximum
{
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            var heap = new SortedSet<int>();
            for (int i = 0; i < k; i++)
                Add(i);
            var res = new List<int>();
            res.Add(heap.Max);

            for (int i = k; i < nums.Length; i++)
            {
                Delete(i - k);
                Add(i);
                res.Add(heap.Max);
            }

            return res.ToArray();

            void Add(int pos)
            {
                var val = nums[pos];
                if (!dict.ContainsKey(val))
                    dict.Add(val, 0);
                dict[val]++;
                heap.Add(val);
            }

            void Delete(int pos)
            {
                var val = nums[pos];
                dict[val]--;
                if (dict[val] == 0)
                    heap.Remove(val);
            }
        }
    }
}