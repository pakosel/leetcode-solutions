using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DecodeString
{
    public class Solution
    {
        Dictionary<int, int> brackets = new Dictionary<int, int>();
        public string DecodeString(string s)
        {
            Stack<int> stack = new Stack<int>();
            for(int i=0; i<s.Length; i++)
            {
                var c = s[i];
                if(c == '[')
                    stack.Push(i);
                else if (c == ']')
                    brackets.Add(stack.Pop(), i);
            }

            return Helper(s, 0, s.Length - 1);
        }

        private string Helper(string s, int start, int end)
        {
            string res = "";
            while(start <= end)
            {
                var c = s[start++];
                if(Char.IsLetter(c))
                    res += c;
                else if(Char.IsDigit(c))
                {
                    int num = int.Parse(c.ToString());
                    while(s[start] != '[')
                    {
                        int n;
                        if(int.TryParse(s[start++].ToString(), out n))
                        {
                            num *= 10;
                            num += n;
                        }
                    }
                    var inner = Helper(s, start + 1, brackets[start] - 1);
                    for(int i=0; i<num; i++)
                        res += inner;
                    start = brackets[start] + 1;
                }
            }

            return res;
        }
    }
}