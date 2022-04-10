using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BaseballGame
{
    public class SolutionStack
    {
        public int CalPoints(string[] ops)
        {
            var rec = new Stack<int>();

            foreach (var op in ops)
                switch (op)
                {
                    case "+":
                        var last = rec.Pop();
                        var sum = rec.Peek() + last;
                        rec.Push(last);
                        rec.Push(sum);
                        break;
                    case "C":
                        rec.Pop();
                        break;
                    case "D":
                        rec.Push(2 * rec.Peek());
                        break;
                    default:
                        rec.Push(int.Parse(op));
                        break;
                }
            return rec.Sum();
        }
    }
    public class SolutionList
    {
        public int CalPoints(string[] ops)
        {
            var rec = new List<int>();

            foreach (var op in ops)
                switch (op)
                {
                    case "+":
                        rec.Add(rec[^1] + rec[^2]);
                        break;
                    case "C":
                        rec.RemoveAt(rec.Count - 1);
                        break;
                    case "D":
                        rec.Add(2 * rec[^1]);
                        break;
                    default:
                        rec.Add(int.Parse(op));
                        break;
                }
            return rec.Sum();
        }
    }
}