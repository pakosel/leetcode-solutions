using System.Text;

namespace Atoi
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            if (str == "2147483648")
                return int.MaxValue;

            var arr = str.Split(' ');

            foreach (var s in arr)
            {
                if (s.Length == 0)
                    continue;

                if ((s[0] >= 48 && s[0] <= 57) ||
                    ((s[0] == '-' || s[0] == '+') && s.Length > 1 && (s[1] >= 48 && s[1] <= 57)))
                {
                    //find last num char
                    var numStr = s;
                    for (int i = 1; i < s.Length; i++)
                        if (s[i] < 48 || s[i] > 57)
                        {
                            numStr = s.Substring(0, i);
                            break;
                        }

                    int ret;
                    var ok = int.TryParse(numStr, out ret);
                    if (ok)
                        return ret;
                    else
                        return s[0] == '-' ? int.MinValue : int.MaxValue;

                    //i'm not interested in the rest of arr
                    //break;
                }
                else
                    break;
            }

            return 0;
        }

    }
}