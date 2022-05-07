using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace FirstBadVersion
{
    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int lastGood = 1;
            int firstBad = n;
            while (firstBad - lastGood > 1)
            {
                if (IsBadVersion(lastGood))
                    return lastGood;
                else
                {
                    var mid = lastGood + (firstBad - lastGood) / 2;
                    if (IsBadVersion(mid))
                        firstBad = mid;
                    else
                        lastGood = mid;
                }
            }
            return IsBadVersion(lastGood) ? lastGood : firstBad;
        }
    }

    public class VersionControl
    {
        private int badVersion;
        public void SetBadVersion(int badVersion)
        {
            this.badVersion = badVersion;
        }
        protected bool IsBadVersion(int version) => version >= badVersion;
    }
}