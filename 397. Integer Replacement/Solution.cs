using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace IntegerReplacement
{
    public class Solution
    {
        public int IntegerReplacement(int n)
        {
            if(n == int.MaxValue)
                return 32;

            int res = 0;
            while(n > 1)
            {
                if(n % 2 == 0)
                    n = n >> 1;
                //substract 1 for 0b11 and 0bXXXX01 only
                else if(n == 3 || (0 == (n & (1 << 1))))
                    n--;
                else
                    n++;

                res++;
            }

            return res;
        }

        private int AllBitsAreSet(int n)
        {
            var cnt = 0;
            while(n > 0)
            {
                if((n & 1) == 0)
                    return -1;
                n = n >> 1;
                cnt++;
            }
            return cnt;
        }
    }
}