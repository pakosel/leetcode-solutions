using System.Collections.Generic;
using System.Linq;
using System;

namespace AddDigits
{
    public class Solution
    {
        public int AddDigits(int num)
        {
            while (num > 9)
                num = num.ToString().Sum(c => c - '0');
            return num;
        }
    }

    public class Solution_Div
    {
        public int AddDigits(int num)
        {
            while (num > 9)
            {
                var sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }

            return num;
        }
    }
    public class Solution_Math
    {
        public int AddDigits(int num)
        {
            // mathematical approach - digital root
            return num == 0 ? 0 : num % 9 == 0 ? 9 : num % 9;
        }
    }
}