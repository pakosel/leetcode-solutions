using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PermutationInString
{
    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int s1_len = s1.Length;
            int s2_len = s2.Length;

            int[] s1_letters = new int[26];
            foreach (char c in s1)
                s1_letters[c - 'a']++;

            int cnt = s1_len;
            int left = 0;

            while(left < s2_len)
            {
                char c = s2[left];
                if(s1_letters[c - 'a'] > 0)
                {
                    s1_letters[c - 'a']--;
                    cnt--;
                    break;
                }
                left++;
            }
            if(cnt == 0)
                return true;

            int right = left + 1;

            while(right < s2.Length)
            {
                char c = s2[right];
                if(s1_letters[c - 'a'] > 0)
                {
                    s1_letters[c - 'a']--;
                    cnt--;
                    if(cnt == 0)
                        return true;
                }
                else
                    while(left < right)
                    {
                        char c_left = s2[left];
                        left++;
                        if(c_left == c)
                            break;
                        s1_letters[c_left - 'a']++;
                        cnt++;
                    }
                right++;
            }

            return false;
        }
    }
}