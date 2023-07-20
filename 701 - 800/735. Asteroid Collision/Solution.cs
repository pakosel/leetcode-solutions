using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace AsteroidCollision
{
    public class Solution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            List<int> res = asteroids.ToList();
            var idx = 1;
            while (idx < res.Count)
                idx = CheckAndCollide(idx);

            return res.ToArray();

            int CheckAndCollide(int i)
            {
                if (i <= 0 || res[i] > 0 || res[i - 1] < 0)
                    return i + 1;
                if (res[i - 1] == Math.Abs(res[i]))
                {
                    res.RemoveAt(i);
                    res.RemoveAt(i - 1);
                    return i - 1;
                }
                else
                    if (res[i - 1] > Math.Abs(res[i]))
                {
                    res.RemoveAt(i);
                    return i;
                }
                else
                {
                    res.RemoveAt(i - 1);
                    return i - 1;
                }
            }
        }
    }
}