using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountOfMatchesInTournament
{
    public class Solution
    {
        public int NumberOfMatches(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else if (n % 2 == 0)
                return n / 2 + NumberOfMatches(n / 2);
            return (n - 1) / 2 + NumberOfMatches((n - 1) / 2 + 1);
        }
    }
}