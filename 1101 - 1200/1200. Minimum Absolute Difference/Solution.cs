using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumAbsoluteDifference
{
    public class Solution
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            var res = new List<IList<int>>();
            var min = arr[1] - arr[0];
            res.Add(new int[] { arr[0], arr[1] });
            for (int i = 2; i < arr.Length; i++)
            {
                var d = arr[i] - arr[i - 1];
                if (d < min)
                {
                    min = d;
                    res.Clear();
                    res.Add(new int[] { arr[i - 1], arr[i] });
                }
                else if (d == min)
                    res.Add(new int[] { arr[i - 1], arr[i] });
            }
            return res;
        }
    }
}