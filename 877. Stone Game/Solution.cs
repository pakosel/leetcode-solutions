using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace StoneGame
{
    public class Solution_Correct
    {
        public bool StoneGame(int[] piles)
        {
            return true;
        }
    }

    public class Solution_Memoization
    {
        Dictionary<(int, int), int> maxPoints = new Dictionary<(int, int), int>();
        int[] Piles;
        int Alex = 0;
        int Lee = 0;

        public bool StoneGame(int[] piles)
        {
            Piles = piles;
            int left = 0;
            int right = piles.Length - 1;
            var sum = Sum(left, right);
            if (GetMaxPoints(left, right) * 2 > sum)
                return true;
            else
                return false;
        }

        private int GetMaxPoints(int left, int right)
        {
            if (maxPoints.ContainsKey((left, right)))
                return maxPoints[(left, right)];
            int res;
            int dist = right - left;
            if (dist == 1)
                res = Math.Max(Piles[left], Piles[right]);
            else
            {
                var sum = Sum(left, right);
                var take_left = GetMaxPoints(left + 1, right);
                var take_right = GetMaxPoints(left, right - 1);
                if (sum - take_left > sum - take_right)
                    res = sum - take_left;
                else
                    res = sum - take_right;
            }

            maxPoints.Add((left, right), res);
            return res;
        }

        Dictionary<(int, int), int> dictSum = new Dictionary<(int, int), int>();
        private int Sum(int left, int right)
        {
            if (dictSum.ContainsKey((left, right)))
                return dictSum[(left, right)];
            int res = 0;
            for (int i = left; i <= right; i++)
                res += Piles[i];

            dictSum.Add((left, right), res);
            return res;
        }
    }
}