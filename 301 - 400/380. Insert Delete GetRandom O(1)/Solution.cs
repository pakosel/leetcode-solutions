using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace InsertDeleteGetRandom
{
    public class RandomizedSet
    {
        Dictionary<int, int> dict;
        List<int> elements;
        private Random random;

        public RandomizedSet()
        {
            dict = new Dictionary<int, int>();
            elements = new List<int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            if (dict.ContainsKey(val))
                return false;

            var newIdx = elements.Count();
            elements.Add(val);
            dict.Add(val, newIdx);

            return true;
        }

        public bool Remove(int val)
        {
            if (dict.ContainsKey(val))
            {
                var elementIdx = dict[val];
                dict.Remove(val);

                RemoveElementAtIdx(elementIdx);
            }
            else
                return false;

            return true;
        }

        private void RemoveElementAtIdx(int idx)
        {
            var countElements = elements.Count();
            if (idx == countElements - 1)
                elements.RemoveAt(idx);
            else
            {
                var lastElem = elements[countElements - 1];
                elements[idx] = lastElem;
                elements.RemoveAt(countElements - 1);
                dict[lastElem] = idx;
            }
        }

        public int GetRandom()
        {
            var rnd = random.Next(0, elements.Count);
            return elements[rnd];
        }
    }
}