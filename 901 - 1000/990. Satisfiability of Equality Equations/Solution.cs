using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace SatisfiabilityOfEqualityEquations
{
    public class Solution
    {
        public bool EquationsPossible(string[] equations)
        {
            var arr = Enumerable.Range(0, 26).Select(_ => new List<char>(equations.Length)).ToArray();

            foreach (var eq in equations.Where(e => e.Contains("==")))
            {
                var sp = eq.Split("==");
                var left = sp[0].First();
                var right = sp[1].First();
                arr[left - 'a'].Add(right);
                arr[right - 'a'].Add(left);
            }

            foreach (var eq in equations.Where(e => e.Contains("!=")))
            {
                var sp = eq.Split("!=");
                var left = sp[0].First();
                var right = sp[1].First();
                if (!Dfs(left, right) || !Dfs(right, left))
                    return false;
            }

            return true;

            bool Dfs(char start, char notEq)
            {
                var visited = new HashSet<char>();
                var q = new Queue<char>();
                q.Enqueue(start);
                while (q.Count > 0)
                {
                    var curr = q.Dequeue();
                    if (visited.Contains(curr))
                        continue;
                    visited.Add(curr);
                    if (curr == notEq)
                        return false;
                    foreach (var c in arr[curr - 'a'])
                        if (!visited.Contains(c))
                            q.Enqueue(c);
                }
                return true;
            }
        }
    }
}