using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace TextJustification
{
    public class Solution
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var res = new List<string>();

            var currWords = new List<string>();
            var currLen = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var w = words[i];
                if (currLen + w.Length <= maxWidth)
                {
                    currLen += w.Length;
                    currWords.Add(w);
                    if (currLen == maxWidth)
                        ProcessLine(i == words.Length - 1);
                    else
                        currLen++;  //add a single space
                }
                else
                {
                    ProcessLine(false);
                    i--;
                }
            }
            ProcessLine(true);

            return res;

            void ProcessLine(bool isLastLine)
            {
                if (currWords.Count == 0)
                    return;

                if (isLastLine)
                {
                    var s = string.Join(' ', currWords);
                    s += GetSpace(maxWidth - s.Length);
                    res.Add(s);
                }
                else
                    ProcessNormalLine();

                //cleanup
                currWords.Clear();
                currLen = 0;
            }

            void ProcessNormalLine()
            {
                var sb = new StringBuilder();
                if (currWords.Count > 1)
                {
                    var spacesToFill = maxWidth - currWords.Sum(w => w.Length);
                    var spaceSize = spacesToFill / (currWords.Count - 1);
                    var mod = spacesToFill % (currWords.Count - 1);
                    var space = GetSpace(spaceSize);

                    for (int i = 0; i < currWords.Count - 1; i++)
                    {
                        sb.Append(currWords[i]);
                        sb.Append(space);
                        if (mod-- > 0)
                            sb.Append(" ");
                    }
                }
                sb.Append(currWords.Last());
                sb.Append(GetSpace(maxWidth - sb.Length));
                res.Add(sb.ToString());
            }

            string GetSpace(int size)
            {
                var sb = new StringBuilder();
                while (size-- > 0)
                    sb.Append(" ");
                return sb.ToString();
            }
        }
    }
}