using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LetterCombinationsPhoneNumber
{
    public class Solution
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public IList<string> LetterCombinations(string digits)
        {
            var len = digits.Length;
            if(len == 0)
                return new string[0];

            InitDict();           
            return GetLetters(digits);
        }

        private void InitDict()
        {
            dict.Add("1", new List<string>() {});
            dict.Add("2", new List<string>() {"a", "b", "c"});
            dict.Add("3", new List<string>() {"d", "e", "f"});
            dict.Add("4", new List<string>() {"g", "h", "i"});
            dict.Add("5", new List<string>() {"j", "k", "l"});
            dict.Add("6", new List<string>() {"m", "n", "o"});
            dict.Add("7", new List<string>() {"p", "q", "r", "s"});
            dict.Add("8", new List<string>() {"t", "u", "v"});
            dict.Add("9", new List<string>() {"w", "x", "y", "z"});
        }

        public List<string> GetLetters(string digits)
        {
            if(dict.ContainsKey(digits))
                return dict[digits];

            var res = new List<string>();
            var rest = GetLetters(digits.Substring(1));
            foreach(var c in dict[digits[0].ToString()])
                foreach(var r in rest)
                    res.Add(c + r);
            return res;
        }
    }
}