using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SingleElementInSortedArray
{
    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            while(true)
            {
                var mid = start + (end - start) / 2;
                if (mid == start)
                    return nums[start];
            
                if (mid % 2 == 0)
                    if(nums[mid] == nums[mid-1])
                        end = mid;
                    else
                        start = mid;
                else
                    if(nums[mid] == nums[mid-1])
                        start = mid + 1;
                    else
                        end = mid - 1;
            }
        }
    }
}