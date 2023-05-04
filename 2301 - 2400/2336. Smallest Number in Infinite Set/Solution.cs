using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SmallestNumberInInfiniteSet
{
    public class SmallestInfiniteSet
    {
        SortedSet<int> heap;
        int MAX = 1000;

        public SmallestInfiniteSet()
        {
            heap = new SortedSet<int>();
            for (int i = 1; i <= MAX; i++)
                heap.Add(i);
        }

        public int PopSmallest()
        {
            var min = heap.Min;
            heap.Remove(min);
            return min;
        }

        public void AddBack(int num)
        {
            heap.Add(num);
        }
    }
}