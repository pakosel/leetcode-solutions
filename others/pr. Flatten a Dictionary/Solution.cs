using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FlattenDictionary
{
    public class Solution
    {
        public static Dictionary<string, string> FlattenDictionary(Dictionary<string, object> dict)
        {
            return FlattenDictionaryWithPrefix("", dict);
        }

        private static Dictionary<string, string> FlattenDictionaryWithPrefix(string keyPrefix, Dictionary<string, object> dict)
        {
            var resDict = new Dictionary<string, string>();
            foreach (var el in dict)
            {
                var key = BuildKeyPrefix(keyPrefix, el.Key);
                var val = el.Value;

                if (val is string)
                    resDict.Add(key, val as string);
                else
                    FlattenDictionaryWithPrefix(key, val as Dictionary<string, object>)
                        .ToList()
                        .ForEach(e => resDict.Add(e.Key, e.Value));
            }

            return resDict;
        }

        private static string BuildKeyPrefix(string prefix, string key)
        {
            if (string.IsNullOrEmpty(key))
                return prefix;
            else
                return prefix != "" ? $"{prefix}.{key}" : key;
        }
    }
}