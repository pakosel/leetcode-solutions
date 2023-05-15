using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public class MathExt
    {
        public static int Gcd(int a, int b)
        {
            while (a != 0 && b != 0)
                if (a > b)
                    a %= b;
                else
                    b %= a;

            return a | b;
        }
    }
}