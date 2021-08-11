using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfDoubledPairs
{
    public class Solution
    {
        public bool CanReorderDoubled(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int zeros = 0;
            foreach (var e in arr)
                if (e == 0)
                {
                    zeros++;
                    continue;
                }
                else if (dict.ContainsKey(e))
                    dict[e]++;
                else
                    dict.Add(e, 1);

            if (zeros % 2 != 0)
                return false;

            int cnt = 0;
            Array.Sort(arr);
            foreach (var e in arr)
                if (e == 0)
                    continue;
                else if (dict.ContainsKey(2 * e) && dict.ContainsKey(e))
                {
                    cnt++;
                    DecreaseDict(dict, 2*e);
                    DecreaseDict(dict, e);
                }
            return cnt == (arr.Length - zeros) / 2;
        }
        public void DecreaseDict(Dictionary<int, int> dict, int key)
        {
            if(dict[key] > 1)
                dict[key]--;
            else
                dict.Remove(key);
        }
    }
}