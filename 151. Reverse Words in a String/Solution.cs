using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ReverseWordsInString
{
    /*
    Runtime: 84 ms, faster than 94.18% of C# online submissions for Reverse Words in a String.
    Memory Usage: 24.5 MB, less than 81.66% of C# online submissions for Reverse Words in a String.
    */
    public class Solution
    {
        public string ReverseWords(string s) => string.Join(' ', s.Split(' ').Reverse().Where(e => e.Length > 0));
    }

    /*
    Runtime: 88 ms, faster than 84.66% of C# online submissions for Reverse Words in a String.
    Memory Usage: 24.5 MB, less than 79.19% of C# online submissions for Reverse Words in a String.
    */
    public class Solution_SemiManual
    {
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            var arr = s.Split(' ');
            for (int i = arr.Length - 1; i >= 0; i--)
                if (arr[i].Length > 0)
                {
                    sb.Append(arr[i]);
                    sb.Append(' ');
                }

            if(sb.Length > 0)
                sb.Remove(sb.Length-1, 1);

            return sb.ToString();
        }
    }

    /*
    Runtime: 172 ms, faster than 12.52% of C# online submissions for Reverse Words in a String.
    Memory Usage: 43.8 MB, less than 6.34% of C# online submissions for Reverse Words in a String.
    */
    public class Solution_FullManual
    {
        public string ReverseWords(string s)
        {
            Stack<string> stack = new Stack<string>();
            string temp = "";
            for(int i=0; i<s.Length; i++)
            {
                char c = s[i];
                if(c == ' ')
                {
                    if(temp.Length > 0)
                    {
                        stack.Push(temp);
                        temp = "";
                    }
                }
                else
                    temp += c;
            }
            if(temp.Length > 0)
                stack.Push(temp);

            string res = "";
            while(stack.Count > 0)
                res += stack.Pop() + " ";

            //TrimEnd
            if(res.Length > 0)
                res = res.Remove(res.Length - 1, 1);

            return res;
        }
    }
}