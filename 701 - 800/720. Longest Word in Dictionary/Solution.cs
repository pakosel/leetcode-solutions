using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestWordInDictionary
{
    public class Solution
    {
        Trie root = new Trie();
        public string LongestWord(string[] words)
        {
            BuildDict(words);
            root.IsFinal = true; //not true but to satisfy DFS while-continue condition

            return DFS(root);
        }

        private string DFS(Trie node)
        {
            string longest = "";
            Stack<(Trie, string)> stack = new Stack<(Trie, string)>();
            stack.Push((node, ""));

            while (stack.Count > 0)
            {
                var el = stack.Pop();
                node = el.Item1;
                var str = el.Item2;
                if (!node.IsFinal)
                    continue;
                if (str.Length > longest.Length)
                    longest = str;

                //because of the request: '... smallest lexicographical order ...'
                for (int i = 25; i >= 0; i--)
                    if (node.Children[i] != null)
                        stack.Push((node.Children[i], str + (char)(i + 'a')));
            }
            return longest;
        }

        private void BuildDict(string[] words)
        {
            foreach (var word in words)
            {
                var node = root;
                foreach (var c in word)
                {
                    int idx = c - 'a';
                    if (node.Children[idx] == null)
                        node.Children[idx] = new Trie();
                    node = node.Children[idx];
                }
                node.IsFinal = true;
            }
        }
    }
}