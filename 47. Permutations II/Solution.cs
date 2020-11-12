using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PermutationsII
{
    public class Solution
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

        private class ListComparer : IEqualityComparer<IList<int>>
        {
            public bool Equals(IList<int> l1, IList<int> l2)
            {
                if (l1.Count != l2.Count)
                    return false;

                for (int i = 0; i < l1.Count; i++)
                    if (l1[i] != l2[i])
                        return false;

                return true;
            }

            public int GetHashCode(IList<int> obj)
            {
                int hashcode = 0;
                foreach (int t in obj)
                    hashcode ^= t.GetHashCode();
                return hashcode;
            }
        }
    }
}