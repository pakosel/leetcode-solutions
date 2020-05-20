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
            int[] res = new int[len];

            var elements = new ElementWithIndex[len];
            for (int i = 0; i < len; i++)
                elements[i] = new ElementWithIndex(ratings[i], i);

            var minHeap = new SortedSet<ElementWithIndex>(new ComparerOrdinary());
            foreach (var el in elements)
                minHeap.Add(el);

            var sumOrdinary = FindMinCandies(ratings, minHeap);

            minHeap = new SortedSet<ElementWithIndex>(new ComparerReversed());
            foreach (var el in elements)
                minHeap.Add(el);

            var sumReversed = FindMinCandies(ratings, minHeap);

            return Math.Min(sumOrdinary, sumReversed);
        }

        private int FindMinCandies(int[] ratings, SortedSet<ElementWithIndex> minHeap)
        {
            int len = ratings.Length;
            int[] res = new int[len];
            int sum = 0;

            while (minHeap.Count > 0)
            {
                var min = minHeap.Min;
                var leftCandy = min.Index > 0 ? res[min.Index - 1] : 0;
                var rightCandy = min.Index < len - 1 ? res[min.Index + 1] : 0;
                var minCandy = 1;
                if (leftCandy > 0)
                {
                    if (ratings[min.Index - 1] < ratings[min.Index])
                        minCandy = leftCandy + 1;
                }
                if (rightCandy > 0)
                {
                    if (ratings[min.Index + 1] < ratings[min.Index])
                        minCandy = Math.Max(minCandy, rightCandy + 1);
                }
                res[min.Index] = minCandy;
                minHeap.Remove(min);
            }

            foreach (var r in res)
                sum += r;

            return sum;
        }

        private struct ElementWithIndex
        {
            public int Rating;
            public int Index;
            public ElementWithIndex(int rating, int index)
            {
                Rating = rating;
                Index = index;
            }
        }

        private struct ComparerOrdinary : IComparer<ElementWithIndex>
        {
            public int Compare(ElementWithIndex e1, ElementWithIndex e2) => e1.Rating != e2.Rating ? e1.Rating.CompareTo(e2.Rating) : e1.Index.CompareTo(e2.Index);
        }

        private struct ComparerReversed : IComparer<ElementWithIndex>
        {
            public int Compare(ElementWithIndex e1, ElementWithIndex e2) => e1.Rating != e2.Rating ? e1.Rating.CompareTo(e2.Rating) : e2.Index.CompareTo(e1.Index);
        }
    }
}