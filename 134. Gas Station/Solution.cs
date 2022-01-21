using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace GasStation
{
    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var len = cost.Length;
            var diff = new int[len];
            var sum = 0;

            for (int i = 0; i < len; i++)
            {
                diff[i] = gas[i] - cost[i];
                sum += diff[i];
            }

            if (sum < 0)
                return -1;

            if (len == 1)
                return 0;

            var left = 0;
            var right = 1;
            sum = diff[0];

            while (right < len)
            {
                while (sum < 0 && left < right)
                    sum -= diff[left++];
                sum += diff[right++];
            }

            return left;
        }
    }
}