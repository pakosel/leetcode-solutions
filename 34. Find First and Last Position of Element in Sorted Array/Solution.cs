using System.Collections.Generic;
using System.Linq;
using System;

namespace PositionsInSortedArray
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int len = nums.Length;
            if(len == 0)
                return new int[] {-1, -1};
            if(len == 1)
            {
                if(nums[0] == target)
                    return new int[] {0, 0};
                else
                    return new int[] {-1, -1};
            }
            if(nums[len-1] < target)
                return new int[] {-1, -1};

            int startPos = -1, endPos = -1;
            int currStart = 0, prevStart = 0, currEnd = len - 1;

            while(nums[currStart] != target && currEnd - currStart > 1)
            {
                if(nums[currStart] < target)
                {
                    prevStart = currStart;
                    currStart += (currEnd - currStart) / 2;
                }
                else
                {
                    currEnd = currStart;
                    currStart -= (currStart - prevStart) / 2;
                }
            }

            if(nums[currStart] == target || nums[currEnd] == target)
            {
                int hit = nums[currStart] == target ? currStart : currEnd;
                startPos = hit;
                while(nums[startPos] == target && startPos > 0)
                    startPos--;
                if(nums[startPos] != target)
                    startPos++;

                endPos = hit;
                while(nums[endPos] == target && endPos < len - 1)
                    endPos++;
                if(nums[endPos] != target)
                    endPos--;
            }

            return new int[] {startPos, endPos};
        }
   }
}