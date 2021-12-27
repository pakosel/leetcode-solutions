using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberComplement
{
    public class Solution
    {
        public int FindComplement(int num)
        {
            int m = 1;
            while (m < num)
                m = (m << 1) + 1;

            return num ^ m;
        }
    }
}