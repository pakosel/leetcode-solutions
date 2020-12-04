using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ThekthFactorOfN
{
    public class Solution
    {
        public int KthFactor(int n, int k)
        {
            int i = 1;
            int cnt = 0;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    cnt++;
                    if (cnt == k)
                        return i;
                }
                i++;
            }
            return -1;
        }
    }
}