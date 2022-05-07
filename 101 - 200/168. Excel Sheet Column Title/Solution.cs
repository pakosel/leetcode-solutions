using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace ExcelSheetColumnTitle
{
    public class Solution
    {
        public string ConvertToTitle(int columnNumber)
        {
            var res = "";
            while (columnNumber > 0)
            {
                var mod = (columnNumber % 26);
                if (mod == 0)
                {
                    res = res.Insert(0, "Z");
                    columnNumber--;
                }
                else
                    res = res.Insert(0, ((char)('@' + mod)).ToString());
                columnNumber /= 26;
            }

            return res;
        }
    }
}