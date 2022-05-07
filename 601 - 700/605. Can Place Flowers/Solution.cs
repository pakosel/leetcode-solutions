using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CanPlaceFlowers
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int i = 0;
            int len = flowerbed.Length;

            while (i < len && n > 0)
            {
                if (flowerbed[i] == 1)
                    i += 2;
                else if ((i == 0 || flowerbed[i - 1] == 0) && (i >= len - 1 || flowerbed[i + 1] == 0))
                {
                    n--;
                    i += 2;
                }
                else
                    i++;
            }

            return n == 0;
        }
    }
}