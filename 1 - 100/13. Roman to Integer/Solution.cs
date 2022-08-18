using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                var d = (i + 1 < s.Length ? s[i + 1] : '-');
                switch (c)
                {
                    case 'I':
                        switch (d)
                        {
                            case 'V':
                                res += 4;
                                i++;
                                break;
                            case 'X':
                                res += 9;
                                i++;
                                break;
                            default:
                                res += 1;
                                break;
                        }
                        break;
                    case 'V':
                        res += 5;
                        break;
                    case 'X':
                        switch (d)
                        {
                            case 'L':
                                res += 40;
                                i++;
                                break;
                            case 'C':
                                res += 90;
                                i++;
                                break;
                            default:
                                res += 10;
                                break;
                        }
                        break;
                    case 'L':
                        res += 50;
                        break;
                    case 'C':
                        switch (d)
                        {
                            case 'D':
                                res += 400;
                                i++;
                                break;
                            case 'M':
                                res += 900;
                                i++;
                                break;
                            default:
                                res += 100;
                                break;
                        }
                        break;
                    case 'D':
                        res += 500;
                        break;
                    case 'M':
                        res += 1000;
                        break;
                }
            }
            return res;
        }
    }
}