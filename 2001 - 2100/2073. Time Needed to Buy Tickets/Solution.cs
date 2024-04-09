using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TimeNeededToBuyTickets
{
    public class Solution
    {
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            var res = 0;
            for (int i = 0; i < tickets.Length; i++)
                if (i <= k)
                    res += Math.Min(tickets[i], tickets[k]);
                else
                    res += Math.Min(tickets[i], tickets[k] - 1);
            return res;
        }
    }
}