using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ReplaceWords
{
    public class Solution
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var sb = new StringBuilder();
            dictionary = dictionary.OrderBy(_ => _).ToList();
            var words = sentence.Split(' ');
            foreach (var w in words)
            {
                sb.Append(Replace(w));
                sb.Append(' ');
            }
            sb.Length--;
            return sb.ToString();

            string Replace(string word)
            {
                var root = dictionary.FirstOrDefault(d => word.StartsWith(d));
                return root ?? word;
            }
        }
    }

    public class Solution_HashSet
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var sb = new StringBuilder();
            var set = new HashSet<string>(dictionary);
            var words = sentence.Split(' ');
            var word = new StringBuilder();
            foreach (var w in words)
            {
                word.Length = 0;
                for (int i = 0; i < w.Length; i++)
                {
                    word.Append(w[i]);
                    if (set.Contains(word.ToString()))
                        break;
                }
                sb.Append(word);
                sb.Append(' ');
            }
            sb.Length--;

            return sb.ToString();
        }
    }
}