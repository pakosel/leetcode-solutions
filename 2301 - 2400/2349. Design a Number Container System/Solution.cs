using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DesignNumberContainerSystem
{
    public class NumberContainers
    {
        Dictionary<int, int> dictIdx;
        Dictionary<int, SortedSet<int>> dictNum;

        public NumberContainers()
        {
            dictIdx = new();
            dictNum = new();
        }

        public void Change(int index, int number)
        {
            Remove(index, number);
            Add(index, number);
        }

        public int Find(int number)
        {
            if (!dictNum.ContainsKey(number) || dictNum[number].Count == 0)
                return -1;
            return dictNum[number].Min;
        }

        private void Add(int index, int number)
        {
            if (!dictIdx.ContainsKey(index))
                dictIdx.Add(index, number);
            else
                dictIdx[index] = number;
            if (!dictNum.ContainsKey(number))
                dictNum.Add(number, new SortedSet<int>());
            dictNum[number].Add(index);
        }

        private void Remove(int index, int number)
        {
            if (!dictIdx.ContainsKey(index))
                return;
            var curr = dictIdx[index];
            dictNum[curr].Remove(index);
        }
    }
}