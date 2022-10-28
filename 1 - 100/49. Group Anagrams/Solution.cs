using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    public class Solution_2022
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            return strs.GroupBy(s => Encode(s)).ToDictionary(_ => _).Select(kvp => kvp.Value.ToList()).ToList<IList<string>>();

            string Encode(string s)
            {
                var arr = new int[26];
                foreach(var c in s)
                    arr[c-'a']++;
                return string.Join(',', arr);
            }
        }
    }

    public class Solution
    {
        public static int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103 };
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<long, List<string>> dict = new Dictionary<long, List<string>>();

            foreach (var s in strs)
            {
                var encoded = Encode(s);
                if (!dict.ContainsKey(encoded))
                    dict.Add(encoded, new List<string>());
                dict[encoded].Add(s);
            }

            var res = new List<IList<string>>();
            foreach (var e in dict)
                res.Add(e.Value);

            return res;
        }

        private long Encode(string s)
        {
            long res = 1;
            foreach (var c in s)
                res *= primes[c - 'a'];
            return res;
        }
    }

    public class Solution_Slow
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (var s in strs)
            {
                var sorted = String.Concat(s.OrderBy(c => c));
                if (!dict.ContainsKey(sorted))
                    dict.Add(sorted, new List<string>());
                dict[sorted].Add(s);
            }

            var res = new List<IList<string>>();
            foreach (var e in dict)
                res.Add(e.Value);

            return res;
        }
    }
}