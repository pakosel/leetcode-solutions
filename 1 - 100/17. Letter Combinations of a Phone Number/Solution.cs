using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LetterCombinationsPhoneNumber
{
    public class Solution
    {
        Dictionary<char, List<char>> letters = new Dictionary<char, List<char>>();
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
            letters.Add('1', new List<char>() {});
            letters.Add('2', new List<char>() {'a', 'b', 'c'});
            letters.Add('3', new List<char>() {'d', 'e', 'f'});
            letters.Add('4', new List<char>() {'g', 'h', 'i'});
            letters.Add('5', new List<char>() {'j', 'k', 'l'});
            letters.Add('6', new List<char>() {'m', 'n', 'o'});
            letters.Add('7', new List<char>() {'p', 'q', 'r', 's'});
            letters.Add('8', new List<char>() {'t', 'u', 'v'});
            letters.Add('9', new List<char>() {'w', 'x', 'y', 'z'});
        }

        public List<string> GetLetters(string digits)
        {
            if(digits.Length == 1)
                return new List<string>(letters[digits[0]].Select(c => c.ToString()));

            var res = new List<string>();
            var rest = GetLetters(digits.Substring(1));
            foreach(var c in letters[digits[0]])
                foreach(var r in rest)
                    res.Add(c + r);
            return res;
        }
    }
}