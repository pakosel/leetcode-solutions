using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public class ListComparer : IEqualityComparer<IList<int>>
    {
        public bool Equals(IList<int> l1, IList<int> l2)
        {
            if (l1.Count != l2.Count)
                return false;

            for (int i = 0; i < l1.Count; i++)
                if (l1[i] != l2[i])
                    return false;

            return true;
        }

        public int GetHashCode(IList<int> obj)
        {
            int hashcode = 0;
            foreach (int t in obj)
                hashcode ^= t.GetHashCode();
            return hashcode;
        }
    }
}