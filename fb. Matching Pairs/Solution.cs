using System;
using System.Collections;
using System.Collections.Generic;

namespace MatchingPairs
{
    public class Solution
    {
        public static int matchingPairs(string s, string t)
        {
            {
                var len = s.Length;
                if (len != t.Length || len < 2)
                    return 0;

                var matching = 0;
                var swapped = false;
                var bestMatchFound = false;
                Dictionary<char, List<char>> unmatched = new Dictionary<char, List<char>>();
                for (int i = 0; i < len; i++)
                    if (s[i] == t[i])
                        matching++;
                    else
                    {
                        if (!bestMatchFound)
                        {
                            if (unmatched.ContainsKey(t[i]))
                            {
                                if (!swapped)
                                {
                                    matching++;
                                    swapped = true;
                                }

                                if (unmatched[t[i]].Contains(s[i]))
                                {
                                    matching++;
                                    bestMatchFound = true;
                                }

                                unmatched[t[i]].Add(s[i]);
                            }
                            else
                                unmatched.Add(s[i], new List<char>() { t[i] });
                        }
                    }

                if (!swapped)
                    matching -= 2;

                return matching > 0 ? matching : 0;
            }
        }

    }
}