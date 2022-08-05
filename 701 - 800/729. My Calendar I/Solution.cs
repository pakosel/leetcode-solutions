using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MyCalendarI
{
    public class MyCalendar
    {
        Dictionary<int, int> bookings;
        List<int> startDates;

        public MyCalendar()
        {
            bookings = new();
            startDates = new();
        }

        public bool Book(int start, int end)
        {
            var idx = startDates.BinarySearch(start);
            if (idx >= 0)   //there is an event with the same start time
                return false;
            idx = ~idx;
            
            var prev = (idx - 1 >= 0 && idx - 1 < startDates.Count ? startDates[idx - 1] : -1);
            var canAdd = (prev == -1 || bookings[prev] <= start);
            var next = (idx < startDates.Count ? startDates[idx] : -1);
            canAdd = canAdd && (next == -1 || end <= next);

            if (canAdd)
                Add(start, end, idx);
            else
                return false;

            return true;
        }

        private void Add(int start, int end, int index)
        {
            if (index >= startDates.Count)
                startDates.Add(start);  //better performance than Insert
            else
                startDates.Insert(index, start);
            bookings.Add(start, end);
        }
    }

}