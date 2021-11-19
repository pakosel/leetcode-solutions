using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace HammingDistance
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int xor = x ^ y;
            //Console.WriteLine($"{Convert.ToString(xor, 2).PadLeft(8, '0')}");
            
            int res = 0;
            for (int i = 0; i < 31; i++)
                if ((xor & (1 << i)) != 0)
                    res++;

            return res;
        }
    }
}