using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindConsecutiveIntegersFromDataStream
{
    public class DataStream
    {
        int LastEqVal = 0;
        int Val;
        int K;
        public DataStream(int value, int k)
        {
            Val = value;
            K = k;
        }

        public bool Consec(int num)
        {
            if (num == Val)
                LastEqVal++;
            else
                LastEqVal = 0;

            return LastEqVal >= K;
        }
    }
}