using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CourseScheduleIII
{
    public class Solution
    {
        public int ScheduleCourse(int[][] courses)
        {
            Array.Sort(courses, (c1, c2) => c1[1] != c2[1] ? c1[1].CompareTo(c2[1]) : c1[0].CompareTo(c2[0]));
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var pos = 0;
            foreach (var c in courses)
                if (pos + c[0] <= c[1])
                {
                    pos += c[0];
                    pq.Enqueue(c[0], c[0]);
                }
                else if (pq.Count > 0 && pq.Peek() > c[0] && pos - pq.Peek() + c[0] <= c[1])
                //we are able to swap current course with other (taken) having longer duration
                {
                    pos -= pq.Dequeue();
                    pos += c[0];
                    pq.Enqueue(c[0], c[0]);
                }

            return pq.Count;
        }
    }
}