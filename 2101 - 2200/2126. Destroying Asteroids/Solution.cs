using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DestroyingAsteroids
{
    public class Solution
    {
        public bool AsteroidsDestroyed(int mass, int[] asteroids)
        {
            long m = mass;
            Array.Sort(asteroids);
            for (int i = 0; i < asteroids.Length; i++)
                if (m >= asteroids[i])
                    m += asteroids[i];
                else
                    return false;
            return true;
        }
    }
}