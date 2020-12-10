using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ValidMountainArray
{
    public class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            bool wasInc = false;
            bool wasDec = false;
            int i = 1;
            while (i < arr.Length)
            {
                int diff = arr[i] - arr[i - 1];
                if (!wasInc && diff > 0)
                    wasInc = true;
                if (!wasDec && diff < 0)
                    wasDec = true;

                if (diff == 0 || (!wasInc && diff < 0) || (wasDec && diff > 0))
                    return false;

                i++;
            }

            return wasInc & wasDec;
        }
    }
}