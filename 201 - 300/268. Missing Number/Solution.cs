using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace MissingNumber
{
    public class Solution_Math
    {
        public int MissingNumber(int[] nums)
        {
            var n = nums.Length;
            var expectedSum = n * (n + 1) / 2;
            var sum = nums.Sum();
            return expectedSum - sum;
        }
    }

    public class Solution_Jumps
    {
        public int MissingNumber(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var currIdx = nums[i];
                var currNum = currIdx != nums.Length ? nums[currIdx] : currIdx;
                while (currIdx != currNum)
                {
                    (currIdx, nums[currIdx]) = (nums[currIdx], currIdx);
                    currNum = currIdx != nums.Length ? nums[currIdx] : currIdx;
                }
            }
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != i)
                    return i;
            return nums.Length;
        }
    }

    public class Solution_Naive
    {
        public int MissingNumber(int[] nums)
        {
            var n = nums.Length;
            var arr = new bool[n + 1];
            foreach (var e in nums)
                arr[e] = true;
            for (int i = 0; i <= n; i++)
                if (!arr[i])
                    return i;
            return 0;
        }
    }
}