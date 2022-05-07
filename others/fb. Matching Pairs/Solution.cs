using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
                Dictionary<char, HashSet<char>> unmatched = new Dictionary<char, HashSet<char>>();
                for (int i = 0; i < len; i++)
                {
                    char Si = s[i];
                    char Ti = t[i];
                    if (Si == Ti)
                        matching++;
                    else
                    {
                        if (!bestMatchFound)
                        {
                            if (unmatched.ContainsKey(Ti))
                            {
                                if (!swapped)
                                {
                                    matching++;
                                    swapped = true;
                                }

                                if (unmatched[Ti].Contains(Si))
                                {
                                    matching++;
                                    bestMatchFound = true;
                                }
                            }
                            else
                                if(unmatched.ContainsKey(Si))
                                    unmatched[Si].Add(Ti);
                                else
                                    unmatched.Add(Si, new HashSet<char>() { Ti });
                        }
                    }
                }

                if (!swapped && matching == len)            //to cover test case no. 2
                    if(s.Distinct().Count() == s.Length)    //to cover test case no. 9
                        matching -= 2;

                return matching;
            }
        }

    }
}