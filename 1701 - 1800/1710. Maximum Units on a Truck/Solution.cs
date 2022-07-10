using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumUnitsOnTruck
{
    public class Solution
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            Array.Sort(boxTypes, (x, y) => y[1].CompareTo(x[1]));
            var res = 0;
            for (int i = 0; i < boxTypes.Length && truckSize > 0; i++)
            {
                var maxBox = Math.Min(boxTypes[i][0], truckSize);
                res += maxBox * boxTypes[i][1];
                truckSize -= maxBox;
            }

            return res;
        }
    }
}