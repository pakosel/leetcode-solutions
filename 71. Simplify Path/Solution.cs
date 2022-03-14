using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SimplifyPath
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            var arr = path.Split('/');
            var stack = new Stack<string>();
            foreach (var p in arr)
                switch (p)
                {
                    case "":
                    case ".":
                        break;
                    case "..":
                        if (stack.Count > 0)
                            stack.Pop();
                        break;
                    default:
                        stack.Push(p);
                        break;
                }

            var sb = new StringBuilder();
            while (stack.Count > 0)
                sb.Insert(0, "/" + stack.Pop());

            return sb.Length == 0 ? "/" : sb.ToString();
        }
    }
}