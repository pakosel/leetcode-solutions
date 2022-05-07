using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace JumpGameIV
{
    public class Solution
    {
        public int MinJumps(int[] arr)
        {
            var dict = new Dictionary<int, List<int>>();
            var res = new int[arr.Length];
            Array.Fill(res, -1);

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], new List<int>());
                dict[arr[i]].Add(i);
            }

            var queue = new Queue<(List<int> siblings, int dist)>();
            queue.Enqueue((new List<int>() { arr.Length - 1 }, 0));

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();

                foreach (var index in curr.siblings)
                {
                    if (res[index] != -1)
                        continue;
                    res[index] = curr.dist;
                    if (index == 0)
                        return curr.dist;
                    if (res[index - 1] == -1)
                        queue.Enqueue((new List<int>() { index - 1 }, curr.dist + 1));
                    if (index < arr.Length - 1 && res[index + 1] == -1)
                        queue.Enqueue((new List<int>() { index + 1 }, curr.dist + 1));
                    if (dict[arr[index]].Count > 1)
                        queue.Enqueue((dict[arr[index]], curr.dist + 1));
                }
            }

            return res[0];
        }
    }
}