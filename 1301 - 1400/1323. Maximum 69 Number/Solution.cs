using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace Maximum69Number
{
    public class Solution
    {
        public int Maximum69Number(int num)
        {
            var list = num.ToString().ToList();
            for (int i = 0; i < list.Count; i++)
                if (list[i] == '6')
                {
                    list[i] = '9';
                    break;
                }
            return int.Parse(string.Join("", list));
        }
    }
}