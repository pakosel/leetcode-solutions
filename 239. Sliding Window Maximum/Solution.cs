using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SlidingWindowMaximum
{
    public class Solution
    {
        SortedSet<int> maxHeap = new SortedSet<int>();
        Dictionary<int, int> numCount = new Dictionary<int, int>();

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            List<int> res = new List<int>();
            int len = nums.Length;

            int i = 0;
            while (i < k)
            {
                AddNum(nums[i]);
                i++;
            }
            res.Add(maxHeap.Max);

            while (i < len)
            {
                int lPtr = i - k;
                RemoveNum(nums[lPtr]);
                AddNum(nums[i]);
                res.Add(maxHeap.Max);
                i++;
            }

            return res.ToArray();
        }

        private void AddNum(int num)
        {
            if (numCount.ContainsKey(num))
                numCount[num] = numCount[num] + 1;
            else
            {
                maxHeap.Add(num);
                numCount.Add(num, 1);
            }
        }

        private void RemoveNum(int num)
        {
            if (numCount[num] > 1)
                numCount[num] = numCount[num] - 1;
            else
            {
                numCount.Remove(num);
                maxHeap.Remove(num);
            }
        }
    }
}