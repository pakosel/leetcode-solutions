using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LruCache
{
    public class LRUCache
    {
        Dictionary<int, (int val, int cnt)> dict;
        PriorityQueue<(int key, int cnt), int> pq;
        int capacity;
        int cnt;

        public LRUCache(int capacity)
        {
            dict = new();
            pq = new();
            this.capacity = capacity;
            this.cnt = 0;
        }

        public int Get(int key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = (dict[key].val, cnt++);
                return dict[key].val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (pq.Count == capacity && !dict.ContainsKey(key))
                Trim();
            var thisCnt = cnt++;
            if (!dict.ContainsKey(key))
                pq.Enqueue((key, thisCnt), thisCnt);
            dict[key] = (value, thisCnt);
        }

        private void Trim()
        {
            while (pq.Peek().cnt != dict[pq.Peek().key].cnt)
            {
                var curr = pq.Dequeue();
                pq.Enqueue((curr.key, dict[curr.key].cnt), dict[curr.key].cnt);
            }
            var toDel = pq.Dequeue();
            dict.Remove(toDel.key);
        }
    }
}