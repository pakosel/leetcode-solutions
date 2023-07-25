using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PeakIndexInMountainArray
{
    public class Solution
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                    return mid;
                if (arr[mid + 1] > arr[mid])
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
    }
}