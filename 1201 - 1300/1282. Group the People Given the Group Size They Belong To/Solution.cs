using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace GroupPeopleGivenGroupSizeTheyBelongTo
{
    public class Solution
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var n = groupSizes.Length;
            var nextGroupId = 0;
            var groups = new List<int>[n];
            var groupsBySize = new int?[n + 1];

            for (int i = 0; i < n; i++)
            {
                var gs = groupSizes[i];
                if (!groupsBySize[gs].HasValue || groups[groupsBySize[gs].Value].Count == gs)
                    groupsBySize[gs] = nextGroupId++;

                var grpId = groupsBySize[gs].Value;
                if (groups[grpId] == null)
                    groups[grpId] = new List<int>();
                groups[grpId].Add(i);
            }

            return groups.Where(lst => lst != null).ToArray();
        }
    }
}