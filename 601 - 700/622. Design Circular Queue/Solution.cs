using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DesignCircularQueue
{
    public class MyCircularQueue
    {
        List<int> list;
        int max;
        public MyCircularQueue(int k)
        {
            max = k;
            list = new List<int>(k);
        }

        public bool EnQueue(int value)
        {
            if (list.Count < max)
            {
                list.Add(value);
                return true;
            }
            return false;
        }

        public bool DeQueue()
        {
            if (list.Count > 0)
            {
                list.RemoveAt(0);
                return true;
            }
            return false;
        }

        public int Front()
        {
            if (list.Count > 0)
                return list.First();
            return -1;
        }

        public int Rear()
        {
            if (list.Count > 0)
                return list.Last();
            return -1;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public bool IsFull()
        {
            return list.Count == max;
        }
    }
}