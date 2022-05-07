using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CinemaSeatAllocation
{
    public class Solution
    {
        public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
        {
            var rows = new Dictionary<int, SortedSet<int>>();
            foreach (var r in reservedSeats)
            {
                if (!rows.ContainsKey(r[0]))
                    rows.Add(r[0], new SortedSet<int>());
                rows[r[0]].Add(r[1]);
            }

            var res = 2 * (n - rows.Count());
            foreach (var seats in rows.Values)
            {
                var prev = seats.First();
                if (prev > 5)
                    res++;
                if (prev == 10)
                    res++;
                foreach (var s in seats.Skip(1))
                {
                    var size = s - prev - 1;
                    if (size >= 4)
                    {
                        if (prev < 2 && s > 9)
                            res += 2;
                        else if ((prev < 2 && s > 5) || (prev < 6 && s > 9) || (prev < 4 && s > 7))
                            res++;
                    }
                    prev = s;
                }

                if (prev == 1)
                    res += 2;
                else if (prev < 6)
                    res++;
            }
            return res;
        }
    }
}