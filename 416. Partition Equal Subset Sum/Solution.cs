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
                var target = sum / 2;
                var memoTable = new bool[len][];

                for(int i=0; i<len; i++)
                {
                    memoTable[i] = new bool[target+1];
                    for(int j=0; j<=target; j++)
                    {
                        if(i == 0)
                            memoTable[i][j] = (nums[i] == j);
                        else
                        {
                            if(j < nums[i])
                                memoTable[i][j] = memoTable[i-1][j];
                            else
                                memoTable[i][j] = memoTable[i-1][j] || memoTable[i-1][ j - nums[i] ];
                        }
                    }
                }

                return memoTable[len-1][target];
            }

            return false;
        }
    }
}