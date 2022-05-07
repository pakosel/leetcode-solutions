using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DesignHashMap
{
    public class MyHashMap
    {
        int[] Arr;

        public MyHashMap()
        {
            Arr = new int[1_000_001];
            Array.Fill(Arr, -1);
        }

        public void Put(int key, int val)
        {
            Arr[key] = val;
        }

        public int Get(int key) => Arr[key];

        public void Remove(int key) => Put(key, -1);
    }
}