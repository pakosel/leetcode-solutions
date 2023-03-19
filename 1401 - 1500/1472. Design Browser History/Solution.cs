using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using Common;

namespace DesignBrowserHistory
{
    public class BrowserHistory
    {
        Stack<string> back;
        Stack<string> fwd;
        string current;

        public BrowserHistory(string homepage)
        {
            current = homepage;
            back = new Stack<string>();
            fwd = new Stack<string>();
        }

        public void Visit(string url)
        {
            back.Push(current);
            current = url;
            fwd.Clear();
        }

        public string Back(int steps)
        {
            while (steps-- > 0 && back.Count > 0)
            {
                fwd.Push(current);
                current = back.Pop();
            }
            return current;
        }

        public string Forward(int steps)
        {
            while (steps-- > 0 && fwd.Count > 0)
            {
                back.Push(current);
                current = fwd.Pop();
            }
            return current;
        }
    }
}