using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FormLargestInteger
{
    public class Solution
    {
        public string LargestNumber(int[] cost, int target)
        {
            List<int>[] maxDigit = new List<int>[target + 1];

            for (int i = 1; i <= target; i++)
            {
                List<int> max = null;
                for (int j = 0; j < 9; j++)
                {
                    int diff = i - cost[j];
                    if (diff == 0)
                        max = Compare(max, new List<int>() { j + 1 });
                    else if (diff > 0 && maxDigit[diff] != null)
                        max = Compare(max, ConstructMax(maxDigit[diff], j + 1));
                }
                maxDigit[i] = max;
            }

            return ToStr(maxDigit[target]);
        }

        private string ToStr(List<int> list)
        {
            if (list == null || list.Count == 0)
                return "0";
            StringBuilder sb = new StringBuilder();
            foreach (var i in list)
                sb.Append(i);

            return sb.ToString();
        }

        private List<int> ConstructMax(List<int> list, int num)
        {
            var res = new List<int>(list);

            for (int i = 0; i < res.Count; i++)
                if (num >= res[i])
                {
                    res.Insert(i, num);
                    return res;
                }

            res.Add(num);
            return res;
        }

        private List<int> Compare(List<int> list1, List<int> list2)
        {
            if (list1 == null)
                return list2;
            if (list1.Count != list2.Count)
                return list1.Count > list2.Count ? list1 : list2;

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] == list2[i])
                    continue;
                else if (list1[i] > list2[i])
                    return list1;
                else
                    return list2;
            }

            return list1;
        }
    }
}