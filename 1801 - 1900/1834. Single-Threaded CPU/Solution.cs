using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SingleThreadedCPU
{
    public class Solution
    {
        public int[] GetOrder(int[][] tasks)
        {
            var pq = new PriorityQueue<int, int>();
            for (int i = 0; i < tasks.Length; i++)
                pq.Enqueue(i, tasks[i][0]);
            var qTime = new PriorityQueue<int, int>();
            var qIndex = new PriorityQueue<int, int>();

            var time = 1;
            var res = new List<int>();
            while (pq.Count > 0 || qTime.Count > 0)
            {
                //enqueue all tasks that can be executed for current time, order them by tasks length
                while (pq.Count > 0 && tasks[pq.Peek()][0] <= time)
                    qTime.Enqueue(pq.Peek(), tasks[pq.Dequeue()][1]);

                if (qTime.Count > 0)
                {
                    //there can be two or mor tasks with the min exec time - order them by idndex
                    while (qTime.Count > 0 && (qIndex.Count == 0 || tasks[qIndex.Peek()][1] == tasks[qTime.Peek()][1]))
                        qIndex.Enqueue(qTime.Peek(), qTime.Dequeue());

                    var curr = qIndex.Dequeue();
                    res.Add(curr);
                    time += tasks[curr][1];

                    //non-processed tasks that were considered need to time-queue 
                    //(there can be shorter tasks after increasing time)
                    while (qIndex.Count > 0)
                        qTime.Enqueue(qIndex.Peek(), tasks[qIndex.Dequeue()][1]);
                }
                else    //no tasks to run now - skip idle time
                    time = tasks[pq.Peek()][0];
            }
            return res.ToArray();
        }
    }
}