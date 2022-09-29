using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindKClosestElements
{
    public class Solution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var pos = Array.BinarySearch(arr, x);
            if(pos < 0)
                pos = ~pos;
            if(IsLeftCloser(pos-1, pos))
                pos--;

            var left = pos;
            var right = pos;
            var taken = 1;
            while(taken++ < k)
                if(IsLeftCloser(left-1, right+1))
                    left--;
                else
                    right++;

            return arr.Skip(left).Take(k).ToList();

            bool IsLeftCloser(int left, int right)
            {
                if(left < 0)
                    return false;
                if(right >= arr.Length)
                    return true;
                return Math.Abs(arr[left] - x) < Math.Abs(arr[right] - x) ||
                    (Math.Abs(arr[left] - x) == Math.Abs(arr[right] - x) && arr[left] < arr[right]);
            }
        }
    }
}