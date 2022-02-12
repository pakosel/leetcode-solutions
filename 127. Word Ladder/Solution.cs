using System.Collections.Generic;
using System.Linq;
using System;

namespace WordLadder
{
    public class Solution
    {
        Dictionary<string, HashSet<string>> Targets = new Dictionary<string, HashSet<string>>();

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var res = 1;
            if (!wordList.Contains(beginWord))
                wordList.Insert(0, beginWord);
            BuildGraph(wordList);
            var q = new Queue<string>();
            var visited = new HashSet<string>();
            q.Enqueue(beginWord);
            while (q.Count > 0)
            {
                var cnt = q.Count;
                for (int i = 0; i < cnt; i++)
                {
                    var curr = q.Dequeue();
                    if (curr == endWord)
                        return res;
                    if (visited.Contains(curr))
                        continue;
                    else
                        visited.Add(curr);
                    foreach (var w in Targets[curr])
                        q.Enqueue(w);
                }
                res++;
            }
            return 0;
        }

        private void BuildGraph(IList<string> wordList)
        {
            for (int i = 0; i < wordList.Count; i++)
            {
                if (!Targets.ContainsKey(wordList[i]))
                    Targets.Add(wordList[i], new HashSet<string>());
                for (int j = i + 1; j < wordList.Count; j++)
                    if (AreConnected(wordList[i], wordList[j]))
                    {
                        Targets[wordList[i]].Add(wordList[j]);
                        if (!Targets.ContainsKey(wordList[j]))
                            Targets.Add(wordList[j], new HashSet<string>());
                        Targets[wordList[j]].Add(wordList[i]);
                    }
            }
        }

        private bool AreConnected(string w1, string w2)
        {
            var diff = false;
            for (int i = 0; i < w1.Length; i++)
                if (w1[i] != w2[i])
                    if (diff)
                        return false;
                    else
                        diff = true;
            return true;
        }
    }
}