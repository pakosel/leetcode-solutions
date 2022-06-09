using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace TwoSumIIinputArrayIsSorted
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while (left < right)
                if (numbers[left] + numbers[right] < target)
                    left++;
                else if (numbers[left] + numbers[right] > target)
                    right--;
                else
                    break;
            return new int[] { left + 1, right + 1 };
        }
    }
}