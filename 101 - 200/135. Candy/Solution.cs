using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Candy
{
    public class Solution
    {
        public int Candy(int[] ratings)
        {
            int len = ratings.Length;
            int[] candies = new int[len];
            var minHeap = new SortedSet<int>(new RatingsComparer() { ratings = ratings });

            var i=0;
            while(i < len)
                minHeap.Add(i++);

            while (minHeap.Count > 0)
            {
                var minIndex = minHeap.Min;
                var min = ratings[minIndex];
                var leftCandy = minIndex > 0 ? candies[minIndex - 1] : 0;
                var rightCandy = minIndex < len - 1 ? candies[minIndex + 1] : 0;
                var minCandy = 1;
                if (leftCandy > 0 && ratings[minIndex - 1] < ratings[minIndex])
                    minCandy = leftCandy + 1;
                if (rightCandy > 0)
                    minCandy = Math.Max(minCandy, rightCandy + 1); //no need to check ratings for the right side because comparer sorts by INDEX
                candies[minIndex] = minCandy;
                minHeap.Remove(minIndex);
            }

            return candies.Sum();
        }

        private struct RatingsComparer : IComparer<int>
        {
            public int[] ratings;

            public int Compare(int idx1, int idx2) => ratings[idx1] != ratings[idx2] ? ratings[idx1].CompareTo(ratings[idx2]) : idx1.CompareTo(idx2);
        }
    }
}