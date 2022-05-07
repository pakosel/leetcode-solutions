using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ClosestDessertCost
{
    public class Solution
    {
        HashSet<int> toppingsTargets = new HashSet<int>();  //all possible toppings costs

        public int ClosestCost(int[] baseCosts, int[] toppingCosts, int target)
        {
            FillToppingsTarget(toppingCosts, 2 * target);   //2* -> last test case

            int minDelta = int.MaxValue;
            foreach (var b in baseCosts)
            {
                minDelta = MinDist(minDelta, b - target);   //option: no toppings at all - only base cost
                var remCost = target - b;

                if (toppingsTargets.Contains(remCost))
                    return target;

                for (int d = 1; d < remCost && d <= Math.Abs(minDelta); d++)
                {
                    if (toppingsTargets.Contains(remCost - d))
                        minDelta = MinDist(minDelta, -1*d);
                    else if (toppingsTargets.Contains(remCost + d))
                        minDelta = MinDist(minDelta, d);
                }
            }

            return target + minDelta;
        }

        private int MinDist(int d1, int d2) => 
            Math.Abs(d1) < Math.Abs(d2) || (Math.Abs(d1) == Math.Abs(d2) && d1 < 0) ? d1 : d2;

        //solves subset sum problem
        private void FillToppingsTarget(int[] toppingCosts, int target)
        {
            var len = 2 * toppingCosts.Length; //There are at most two of each type of topping
            var idx = 0;
            Array.Sort(toppingCosts);
            
            var arr = new bool[len][];
            for (int i = 0; i < len; i++)
            {
                arr[i] = new bool[target + 1];
                arr[i][0] = true;
            }
            if (toppingCosts[0] <= target)
                arr[0][toppingCosts[0]] = true;

            //main loop
            for (int i = 1; i < len; idx += i%2, i++)
            {
                var val = toppingCosts[idx];

                for (int j = 1; j <= target; j++)
                    arr[i][j] = j < val ? arr[i - 1][j] : arr[i - 1][j] || arr[i - 1][j - val];
            }

            //fill all possible toppings combination HashSet
            for (int i = 0; i <= target; i++)
                if (arr[len - 1][i])
                    toppingsTargets.Add(i);
        }
    }
}