using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CrawlerLogFolder
{
    public class Solution
    {
        public int MinOperations(string[] logs)
        {
            var cnt = 0;
            foreach (var e in logs)
                if (e == "../")
                    cnt = Math.Max(cnt - 1, 0);
                else if (e != "./")
                    cnt++;
            return cnt;
        }
    }
}