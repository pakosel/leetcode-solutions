using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumFrequencyStack
{
    public class FreqStack
    {
        private Dictionary<int, int> dict;
        private SortedSet<(int val, int cnt)> sortedSet;
        private Stack<int> stack;

        public FreqStack()
        {
            dict = new Dictionary<int, int>();
            sortedSet = new SortedSet<(int val, int cnt)>(new PairComparer());
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            if (!dict.ContainsKey(val))
            {
                dict.Add(val, 1);
                sortedSet.Add((val, 1));
            }
            else
                EditCount(val, 1);

            stack.Push(val);
        }

        private void EditCount(int val, int cnt)
        {
            var curr = dict[val];
            sortedSet.Remove((val, curr));
            dict[val] = dict[val] + cnt;
            sortedSet.Add((val, dict[val]));
        }

        public int Pop()
        {
            var max = sortedSet.First();
            var temp = new Stack<int>();
            while (stack.Peek() != max.val && dict[stack.Peek()] < max.cnt)
                temp.Push(stack.Pop());

            var res = stack.Pop();
            EditCount(res, -1);
            while (temp.Count > 0)
                stack.Push(temp.Pop());

            return res;
        }

        private struct PairComparer : IComparer<(int val, int cnt)>
        {
            public int Compare((int val, int cnt) p1, (int val, int cnt) p2) =>
                p1.cnt == p2.cnt ? p1.val.CompareTo(p2.val) : p2.cnt.CompareTo(p1.cnt);
        }
    }
}