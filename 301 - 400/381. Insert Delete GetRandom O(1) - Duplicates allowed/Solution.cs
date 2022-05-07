using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace InsertDeleteGetRandomWithDuplicates
{
    public class RandomizedCollection
    {

        Dictionary<int, List<int>> dict;
        List<int> elements;
        Random random;

        public RandomizedCollection()
        {
            dict = new Dictionary<int, List<int>>();
            elements = new List<int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            var newIdx = elements.Count();
            elements.Add(val);

            if (dict.ContainsKey(val))
            {
                dict[val].Add(newIdx);
                return false;
            }
            else
                dict.Add(val, new List<int>() { newIdx });

            return true;
        }

        public bool Remove(int val)
        {
            if (dict.ContainsKey(val))
            {
                var countElements = dict[val].Count();
                var elementIdx = dict[val][countElements - 1];
                if (countElements > 1)
                    dict[val].RemoveAt(countElements - 1);
                else
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
                dict[lastElem].Remove(countElements - 1);
                dict[lastElem].Add(idx);
            }
        }

        public int GetRandom()
        {
            var rnd = random.Next(0, elements.Count);
            return elements[rnd];
        }
    }
}