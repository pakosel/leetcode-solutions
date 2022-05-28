using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SenderWithLargestWordCount
{
    public class Solution
    {
        public string LargestWordCount(string[] messages, string[] senders)
        {
            var len = messages.Length;
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < len; i++)
            {
                if (!dict.ContainsKey(senders[i]))
                    dict.Add(senders[i], 0);
                var cnt = messages[i].Split(' ').Length;
                dict[senders[i]] += cnt;
            }
            var max = 0;
            var res = "";
            foreach (var kvp in dict)
                if (kvp.Value >= max)
                {
                    if (kvp.Value > max || (kvp.Value == max && string.Compare(kvp.Key, res, StringComparison.Ordinal) > 0))
                        res = kvp.Key;
                    max = Math.Max(max, kvp.Value);
                }
            return res;
        }
    }
}