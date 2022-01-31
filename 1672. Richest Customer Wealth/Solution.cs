using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RichestCustomerWealth
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            return accounts.Max(c => c.Sum());
        }
    }
}