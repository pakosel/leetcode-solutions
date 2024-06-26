using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MakeTheStringGreat
{
    public class Solution2024
    {
        public string MakeGood(string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
                if (sb.Length > 0 && Math.Abs(sb[^1] - c) == 32)
                    sb.Length--;
                else
                    sb.Append(c);
            return sb.ToString();
        }
    }
    
    public class Solution
    {
        public string MakeGood(string s)
        {
            int i = 0;
            var str = s.ToList();
            while (i < s.Length - 1)
            {
                if (!CheckGood(i))
                {
                    str.RemoveAt(i + 1);
                    str.RemoveAt(i);
                    i--;
                }
                else
                    i++;
            }

            return string.Join("", str);

            bool CheckGood(int i)
            {
                if (i < 0 || i + 1 >= str.Count)
                    return true;
                var case1 = char.IsUpper(str[i]);
                var case2 = char.IsUpper(str[i + 1]);
                if (case1 != case2 && char.ToLower(str[i]) == char.ToLower(str[i + 1]))
                    return false;
                return true;
            }
        }
    }
}