using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DesignFrontMiddleBackQueue
{
    public class FrontMiddleBackQueue
    {
        List<int> list = new List<int>();
        private int count => list.Count;

        public FrontMiddleBackQueue()
        {
        }

        public void PushFront(int val)
        {
            list.Insert(0, val);
        }

        public void PushMiddle(int val)
        {
            var mid = count / 2;
            list.Insert(mid, val);
        }

        public void PushBack(int val)
        {
            list.Add(val);
        }

        public int PopFront()
        {
            if (count == 0)
                return -1;
            int res = list[0];
            list.RemoveAt(0);

            return res;
        }

        public int PopMiddle()
        {
            if (count == 0)
                return -1;
            var mid = count % 2 == 0 ? count / 2 - 1 : count / 2;
            int res = list[mid];
            list.RemoveAt(mid);

            return res;
        }

        public int PopBack()
        {
            if (count == 0)
                return -1;

            int res = list[count - 1];
            list.RemoveAt(count - 1);

            return res;
        }
    }
}