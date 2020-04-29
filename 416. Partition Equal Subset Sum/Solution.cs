using System.Collections.Generic;
using System.Linq;
using System;

namespace PartitionEqualSum
{
    public class Solution
    {
        public bool CanPartition(int[] nums)
        {
            int len = nums.Length;
            if (len < 2)
                return false;

            int sum = 0;
            Array.Sort(nums);
            for (int i = 0; i < len; i++)
                sum += nums[i];

            if (sum % 2 == 0)
            {
                if(nums[len-1] == sum / 2)
                    return true;
                if(nums[len-1] > sum / 2)
                    return false;
                
                var target = sum / 2 - nums[len-1];
                var memoTable = new bool[len-1][];

                for(int i=0; i<len-1; i++)
                {
                    memoTable[i] = new bool[target+1];
                    for(int j=0; j<=target; j++)
                    {
                        if(i == 0)
                            memoTable[i][j] = (nums[i] == j);
                        else if(j == 0)
                            memoTable[i][j] = true;
                        else
                        {
                            if(j < nums[i])
                                memoTable[i][j] = memoTable[i-1][j];    //value greater than current target sum won't help us
                            else
                                memoTable[i][j] = memoTable[i-1][j] || memoTable[i-1][ j - nums[i] ];

                            if(j == target && memoTable[i][j])
                                return true;    //because the value will be "propagated" to "memoTable[len-2][target]" anyway
                        }
                    }
                }

                return memoTable[len-2][target];
            }

            return false;
        }
    }
}