using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumGardenPerimeterToCollectEnoughApples
{
    public class Solution
    {
        public long MinimumPerimeter(long neededApples)
        {
            long sum = 0;
            long i = 0;
            while (sum < neededApples)
            {
                i++;
                var s = 3 * i;
                // for(int k=1; k<i; k++)
                //     s += 2*(i+k);
                //Above loop can be simplified using the n-th partial sum of the series equation
                //i.e.: sum(1..2*i-1) - sum(1..i)
                s += 3 * i * (i - 1);

                sum += 4 * s;
            }
            return 8 * i;
        }
    }
}