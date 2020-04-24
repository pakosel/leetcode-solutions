using System;
using System.Collections;
using System.Collections.Generic;

namespace SlowSums
{
    public class Solution
    {
        public static int getTotalTime(int[] arr)
        {
            var len = arr.Length;
            if (len == 1)
                return 0;
            if (len == 2)
                return arr[0] + arr[1];

            List<int> lst = new List<int>(arr);
            int sum = 0;
            int idx = 0;
            int max = 0;
            for (int i = 0; i < len - 1; i++)
                if (arr[i] + arr[i + 1] > max)
                {
                    max = arr[i] + arr[i + 1];
                    idx = i;
                }

            while (lst.Count > 2)
            {
                max = lst[idx] + lst[idx + 1];
                sum += max;
                lst[idx] = max;
                lst.RemoveAt(idx + 1);
                var rightVal = idx + 1 < lst.Count ? lst[idx + 1] : int.MinValue;
                var leftVal = idx - 1 >= 0 ? lst[idx - 1] : int.MinValue;
                if (leftVal > rightVal)
                    idx--;
            }

            sum += lst[0] + lst[1];

            return sum;
        }
    }
}