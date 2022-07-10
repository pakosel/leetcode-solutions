using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Candy
{
    public class Solution
    {
        public int Candy(int[] ratings)
        {
            int len = ratings.Length;
            var arr = new int[len];
            var res = 0;
            var pq = new PriorityQueue<int, int>();
            var pq2 = new PriorityQueue<int, int>();    //all indexes with the same rating
            
            for(int i=0; i<len; i++)
                pq.Enqueue(i, ratings[i]);      //process with increasing ratings

            while(pq.Count > 0)
            {
                var peekRating = ratings[pq.Peek()];
                while(pq.Count > 0 && ratings[pq.Peek()] == peekRating)
                {
                    var idx = pq.Dequeue();
                    pq2.Enqueue(idx, Math.Max(idx > 0 ? arr[idx-1] : 0, idx < len - 1 ? arr[idx+1] : 0));
                }

                while(pq2.Count > 0)
                {
                    var idx = pq2.Dequeue();
                    var left = idx > 0 ? (ratings[idx-1] < ratings[idx] ? arr[idx-1] + 1 : arr[idx-1]) : 0;
                    var right = idx < len-1 ? (ratings[idx+1] < ratings[idx] ? arr[idx+1] + 1 : arr[idx+1]) : 0;
                    arr[idx] = Math.Max(left, right);
                    if(arr[idx] == 0)
                        arr[idx] = 1;   //at least one candy for everyone
                    res += arr[idx];
                }
            }
            return res;
        }
    }
}