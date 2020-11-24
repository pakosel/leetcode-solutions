using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace UniqueMorseCodeWords
{
    public class Solution
    {
        private string[] letters = new string[] {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        public int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> transform = new HashSet<string>();
            foreach (var word in words)
                transform.Add(Transform(word));
            return transform.Count;
        }

        private string Transform(string word)
        {
            string res = "";
            foreach (var c in word)
                res += letters[c - 'a'];
            return res;
        }
    }
}