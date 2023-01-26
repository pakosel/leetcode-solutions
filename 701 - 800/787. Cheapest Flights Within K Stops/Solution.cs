using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CheapestFlightsWithinKStops
{
    public class Solution
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            var graph = flights.GroupBy(f => f[0]).ToDictionary(grp => grp.Key, grp => grp);
            var minPrice = new int[n];
            Array.Fill(minPrice, int.MaxValue);

            var q = new Queue<(int node, int price, int stops)>();
            q.Enqueue((src, 0, k + 1));
            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                if (minPrice[curr.node] <= curr.price)
                    continue;
                minPrice[curr.node] = curr.price;
                if (--curr.stops >= 0 && graph.ContainsKey(curr.node))
                    foreach (var f in graph[curr.node])
                        q.Enqueue((f[1], curr.price + f[2], curr.stops));
            }

            return minPrice[dst] != int.MaxValue ? minPrice[dst] : -1;
        }
    }
}