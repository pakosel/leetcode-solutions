using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DesignHashSet
{
    public class MyHashSet
    {
        private bool[] Arr;

        public MyHashSet()
        {
            Arr = new bool[1_000_001];
        }

        public void Add(int key)
        {
            Arr[key] = true;
        }

        public void Remove(int key)
        {
            Arr[key] = false;
        }

        public bool Contains(int key)
        {
            return Arr[key];
        }
    }
}