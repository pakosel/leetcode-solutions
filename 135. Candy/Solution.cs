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
            var minHeap = new SortedSet<ElementWithIndex>(new ComparerOrdinary());

            var i=0;
            foreach (var el in ratings)
                minHeap.Add(new ElementWithIndex(el, i++));


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

            int sum = 0;
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
    }
}