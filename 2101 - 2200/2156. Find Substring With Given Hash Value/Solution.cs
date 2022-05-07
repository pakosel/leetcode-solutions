using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindSubstringWithGivenHashValue
{
    public class Solution
    {
        public string SubStrHash(string s, int power, int m, int k, int hashValue)
        {
            var len = s.Length;
            var arr = new int[len];
            var startIdx = 0;

            for (int i = 0; i < len; i++)
                arr[i] = (s[i] - 'a' + 1);

            long val = 0;
            long p = 1;
            for(int i=len-k; i<len; i++)
            {
                val = (val + arr[i] * p);
                if(i < len-1)   //we will need the value power^(k-1) later in the code
                    p = (p * power) % m;
            }

            if(val % m == hashValue)
                startIdx = len-k;

            for(int i=len-k-1; i>=0; i--)
            {
                val = ((val % m) - (arr[i+k]*p % m) + m) * power + arr[i];
                if(val % m == hashValue)
                    startIdx = i;   //we need to continue since we're asked to return THE FIRST substring
            }

            return s.Substring(startIdx, k);
        }
    }
}