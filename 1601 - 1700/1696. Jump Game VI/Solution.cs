using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace JumpGameVI
{
    public class Solution
    {
        public int MaxResult(int[] nums, int k)
        {
            if (nums.Length < 2)
                return nums[0];
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var dict = new Dictionary<int, int>();
            pq.Enqueue(nums.Last(), nums.Last());
            dict.Add(nums.Last(), 1);

            for (int i = nums.Length - 2; i > 0; i--)
            {
                var curr = nums[i] + GetMax();
                nums[i] = curr;
                pq.Enqueue(curr, curr);
                if (!dict.ContainsKey(curr))
                    dict.Add(curr, 0);
                dict[curr]++;

                if (pq.Count > k)
                    dict[nums[i + k]]--;
            }
            return nums[0] + GetMax();

            int GetMax()
            {
                while (dict[pq.Peek()] == 0)
                    pq.Dequeue();
                return pq.Peek();
            }
        }
    }
}