using System.Collections.Generic;
using System.Linq;
using System;

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

            return "/" + string.Join("/", stack.Reverse());
        }
    }
}