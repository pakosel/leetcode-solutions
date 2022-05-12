using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PermutationsII
{
    public class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var set = Permute(NumToStr(nums));
            return set.Select(s => StrToNum(s)).ToArray();
        }

        private HashSet<string> Permute(string numsStr)
        {
            if (numsStr.Length == 1)
                return new HashSet<string>() {numsStr};

            var res = new HashSet<string>();
            var first = numsStr[0];
            foreach(var perm in Permute(numsStr.Substring(1)))
                for (int i = 0; i <= perm.Length; i++)
                    res.Add(perm.Insert(i, first.ToString()));
            return res;
        }

        private string NumToStr(int[] nums) => string.Join(null, nums.Select(n => (char)('k' + n)));

        private IList<int> StrToNum(string s) => s.Select(c => c - 'k').ToArray();
    }

    public class Solution_List
    {
        public IList<IList<int>> PermuteUnique(int[] nums) => Permute(new Queue<int>(nums));

        private IList<IList<int>> Permute(Queue<int> nums)
        {
            IList<IList<int>> res = new List<IList<int>>();

            if (nums.Count == 1)
                res.Add(new List<int>() { nums.Dequeue() });
            else
            {
                var first = nums.Dequeue();
                foreach(var perm in Permute(nums))
                {
                    for (int i = 0; i <= perm.Count; i++)
                    {
                        var candidate = new List<int>(perm);
                        candidate.Insert(i, first);
                        if(!Contains(res, candidate))
                            res.Add(candidate);
                    }
                }
            }
            return res;
        }

        private bool Contains(IList<IList<int>> res, List<int> list)
        {
            foreach(var lst in res)
                if(lst.Count != list.Count)
                    continue;
                else
                {
                    int i;
                    for(i=0; i<lst.Count; i++)
                        if(lst[i] != list[i])
                            break;
                    if(i == lst.Count)
                        return true;
                }
            return false;
        }
    }
    
    public class Solution_Memoization
    {
        Dictionary<List<int>, List<IList<int>>> dict = new Dictionary<List<int>, List<IList<int>>>(new ListComparer());
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            if (nums.Length == 1)
                return new List<IList<int>>() { nums };

            Array.Sort(nums);
            var numsList = nums.ToList();

            return Helper(numsList);
        }

        private List<IList<int>> Helper(List<int> sortedList)
        {
            if (dict.ContainsKey(sortedList))
                return dict[sortedList];

            List<IList<int>> res = new List<IList<int>>();
            int len = sortedList.Count;

            if (sortedList.Count == 2)
            {
                res.Add(sortedList);
                if (sortedList[0] != sortedList[1])
                    res.Add(new List<int>() { sortedList[1], sortedList[0] });
            }
            else
                for (int i = 0; i < len; i++)
                {
                    int e = sortedList[i];
                    if (i > 0 && e == sortedList[i - 1])
                        continue;
                    var sublist = new List<int>(sortedList);
                    sublist.RemoveAt(i);
                    var subRes = Helper(sublist);
                    foreach (var sr in subRes)
                    {
                        var concat = new List<int>() { e };
                        concat.AddRange(sr);
                        res.Add(concat);
                    }
                }

            dict.Add(sortedList, res);

            return res;
        }
    }
}