using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace WordPattern
{
    public class Solution {
    public bool WordPattern(string pattern, string s) {
        var arr = s.Split(' ');
        if(arr.Length != pattern.Length)
            return false;

        var dict = new Dictionary<char, string>();
        
        for(int i=0; i<arr.Length; i++)
        {
            var c = pattern[i];
            if(dict.ContainsKey(c))
            {
                if(dict[c] != arr[i])
                    return false;
            }
            else if(dict.ContainsValue(arr[i]))
                return false;
            else                
                dict.Add(c, arr[i]);
        }
            
        return true;
    }
}
}