using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace IteratorForCombination
{
    public class CombinationIterator
    {
        int len;
        string chars;
        int[] indexes;
        bool hasNext;

        public CombinationIterator(string characters, int combinationLength)
        {
            chars = characters;
            len = combinationLength;
            indexes = new int[len];
            for (int i = 0; i < len; i++)
                indexes[i] = i;
            hasNext = true;
        }

        public string Next()
        {
            var res = "";
            for (int i = 0; i < len; i++)
                res += chars[indexes[i]];
            hasNext = Roll(len - 1);
            return res;
        }

        public bool HasNext()
        {
            return hasNext;
        }

        private bool Roll(int idx)
        {
            if (indexes[idx] + 1 < chars.Length - (len - idx - 1))
            {
                indexes[idx]++;
                for (int i = idx + 1; i < len; i++)
                    indexes[i] = indexes[i - 1] + 1;
                return true;
            }
            else if (idx > 0)
                return Roll(idx - 1);
            else
                return false;
        }
    }
}