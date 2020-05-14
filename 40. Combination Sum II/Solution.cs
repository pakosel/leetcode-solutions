using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CombinationSumII
{
    public class Solution
    {
        Dictionary<int, List<Tuple<List<int>, List<int>>>> visited = new Dictionary<int, List<Tuple<List<int>, List<int>>>>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var res = new List<IList<int>>();

            BackTrack(new List<int>(), candidates.OrderBy(t => t).ToList(), target, res);

            return res;
        }

        private void BackTrack(List<int> partialRes, List<int> candidates, int currentTarget, IList<IList<int>> res)
        {
            var tupleCallLists = new Tuple<List<int>, List<int>>(partialRes, candidates);
            if(visited.ContainsKey(currentTarget))
            {
                var tupleList = visited[currentTarget];
                if(tupleList.Any(t => t.Item1.SequenceEqual(partialRes) && t.Item2.SequenceEqual(candidates)))
                    return;
                else
                    tupleList.Add(tupleCallLists);
            }
            else
                visited.Add(currentTarget, new List<Tuple<List<int>, List<int>>>() {tupleCallLists});

            Console.Out.WriteLine($"BackTrack partialRes: [{string.Join(',', partialRes)}] candidates: [{string.Join(',', candidates)}] currentTarget: [{currentTarget}]");
            foreach (var c in candidates)
            {
                if (c > currentTarget)
                    return;
                var newPartial = new List<int>(partialRes);
                newPartial.Add(c);
                newPartial = newPartial.OrderBy(t => t).ToList();

                if (c == currentTarget)
                {
                    if(!res.Any(l => l.SequenceEqual(newPartial)))
                    {
                        res.Add(newPartial);
                        return;
                    }
                }
                else
                {
                    var newCandidates = new List<int>(candidates);
                    newCandidates.Remove(c);
                    BackTrack(newPartial, newCandidates, currentTarget - c, res);
                }
            }
        }
    }
}