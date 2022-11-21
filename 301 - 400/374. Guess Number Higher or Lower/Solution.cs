using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace GuessNumberHigherOrLower
{
    public class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            if (guess(n) == 0)
                return n;

            var lo = 1;
            var hi = n;
            var mid = lo + (hi - lo) / 2;
            var res = guess(mid);

            while (res != 0)
            {
                if (res == 1)
                    lo = mid;
                else
                    hi = mid;
                mid = lo + (hi - lo) / 2;
                res = guess(mid);
            }
            return mid;
        }
    }

    public class GuessGame
    {
        private int num;
        public void Pick(int num)
        {
            this.num = num;
        }

        protected int guess(int n)
        {
            if (n > num)
                return -1;
            else if (n < num)
                return 1;
            else
                return 0;
        }
    }
}