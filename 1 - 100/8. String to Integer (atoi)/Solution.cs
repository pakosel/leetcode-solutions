using System.Text;

namespace StringToInteger
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            long res = 0;
            bool? neg = null;
            bool parsing = false;
            foreach (var c in s)
                if (c >= '0' && c <= '9')
                {
                    parsing = true;
                    res = res * 10 + (c - '0');
                    if (res > int.MaxValue)
                        break;
                }
                else if ((c >= 'a' && c <= 'z') || c == '.' || parsing)
                    break;
                else if (c == '-' || c == '+')
                    if (neg != null)
                        return 0;
                    else
                    {
                        neg = (c == '-');
                        parsing = true;
                    }
            if (neg == true)
                res = 0 - res;
            return res > int.MaxValue ? int.MaxValue :
                   res < int.MinValue ? int.MinValue :
                   (int)res;
        }
    }
}