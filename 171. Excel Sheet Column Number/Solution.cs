using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace ExcelSheetColumnNumber
{
    public class Solution
    {
        public int TitleToNumber(string columnTitle)
        {
            var res = 0;
            foreach (var c in columnTitle)
            {
                res *= 26;
                res += (c - 'A' + 1);
            }
            return res;
        }
    }
}