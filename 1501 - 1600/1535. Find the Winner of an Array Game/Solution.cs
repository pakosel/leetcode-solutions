using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindTheWinnerOfAnArrayGame
{
    public class Solution
    {
        public int GetWinner(int[] arr, int k)
        {
            var n = arr.Length;
            for (var i = 0; i < n;)
            {
                var i2 = i;
                var k2 = i == 0 ? k : k - 1;
                for (var j = i + 1; j <= i + k2 && j < n; j++)

                    if (arr[j] > arr[i])
                    {
                        i = j;
                        break;
                    }
                if (i2 == i)
                    return arr[i];

            }
            return 0;
        }
    }
}