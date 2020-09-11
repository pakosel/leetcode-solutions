using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RepeatedStringMatch
{
    public class Solution
    {
        string A;
        string B;
        int lenA;
        int lenB;

        public int RepeatedStringMatch(string A, string B)
        {
            this.A = A;
            this.B = B;
            lenA = A.Length;
            lenB = B.Length;

            for (int i = 0; i < lenA; i++)
                if (TryRepeatedByStartingWith(i) is int res && res != -1)
                    return res;

            return -1;
        }

        private int TryRepeatedByStartingWith(int startPos)
        {
            int repeated = 1;
            for (int i = 0; i < lenB; i++)
                if (B[i] != A[startPos])
                    return -1;
                else if (i != lenB - 1)
                {
                    startPos++;
                    if (startPos == lenA)
                    {
                        repeated++;
                        startPos = 0;
                    }
                }

            return repeated;
        }
    }
}