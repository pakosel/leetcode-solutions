using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SeatReservationManager
{
    public class SeatManager
    {
        PriorityQueue<int, int> heap;
        public SeatManager(int n)
        {
            heap = new PriorityQueue<int, int>();
            for (int i = 1; i <= n; i++)
                heap.Enqueue(i, i);
        }

        public int Reserve()
        {
            var min = heap.Dequeue();
            return min;
        }

        public void Unreserve(int seatNumber)
        {
            heap.Enqueue(seatNumber, seatNumber);
        }
    }
}