using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ReorderedPowerOf2
{
    public class Solution
    {
        public bool ReorderedPowerOf2(int n)
        {
            var allPowersOf2 = GetAllPowers();
            foreach (var pow in allPowersOf2)
                if (CanShuffle(pow, n))
                    return true;
            return false;

            bool CanShuffle(int n1, int n2)
            {
                var digits1 = GetDigits(n1);
                var digits2 = GetDigits(n2);

                for (int i = 0; i < digits1.Length; i++)
                    if (digits1[i] != digits2[i])
                        return false;
                return true;
            }

            int[] GetDigits(int n)
            {
                var res = new int[10];
                foreach (var c in n.ToString())
                    res[c - '0']++;
                return res;
            }

            IList<int> GetAllPowers()
            {
                var res = new List<int>();
                long n = 1;
                while (n <= int.MaxValue)
                {
                    res.Add((int)n);
                    n <<= 1;
                }
                return res;
            }
        }
    }
}