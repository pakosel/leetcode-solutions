using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace TimeBasedKeyValueStore
{
    public class TimeMap
    {
        Dictionary<string, (List<string> val, List<int> ts)> dict;
        public TimeMap()
        {
            dict = new();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!dict.ContainsKey(key))
                dict.Add(key, (new List<string>(), new List<int>()));
            var pos = dict[key].ts.BinarySearch(timestamp);
            if (pos < 0)
                pos = ~pos;
            dict[key].val.Insert(pos, value);
            dict[key].ts.Insert(pos, timestamp);
        }

        public string Get(string key, int timestamp)
        {
            if (!dict.ContainsKey(key))
                return "";
            var pos = dict[key].ts.BinarySearch(timestamp);
            if (pos < 0)
                pos = ~pos;
            if (pos >= dict[key].val.Count)
                return dict[key].val.Last();
            while (pos >= 0 && dict[key].ts[pos] > timestamp)
                pos--;
            return pos >= 0 ? dict[key].val[pos] : "";
        }
    }
}