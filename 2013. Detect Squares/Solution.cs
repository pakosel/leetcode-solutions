using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DetectSquares
{
    public class DetectSquares
    {
        Dictionary<int, int>[] rows;
        Dictionary<int, int>[] cols;

        public DetectSquares()
        {
            rows = new Dictionary<int, int>[1001];
            cols = new Dictionary<int, int>[1001];
        }

        public void Add(int[] point)
        {
            int x = point[0];
            int y = point[1];
            if (rows[y] == null)
                rows[y] = new Dictionary<int, int>();
            if (cols[x] == null)
                cols[x] = new Dictionary<int, int>();
            if (!rows[y].ContainsKey(x))
                rows[y].Add(x, 0);
            if (!cols[x].ContainsKey(y))
                cols[x].Add(y, 0);

            rows[y][x]++;
            cols[x][y]++;
        }

        public int Count(int[] point)
        {
            int x = point[0];
            int y = point[1];
            int res = 0;

            if (rows[y] != null)
                foreach (var kvp in rows[y])    //all added points on the same Y-axis level
                {
                    var xprim = kvp.Key;
                    var quantity = kvp.Value;

                    if (xprim == x)
                        continue;
                    var d = Math.Abs(x - xprim);
                    //count all squares alligned LEFT from the query point (x,y)
                    if (y - d >= 0 && cols[xprim]?.ContainsKey(y - d) == true && cols[x]?.ContainsKey(y - d) == true)
                        res += quantity * cols[xprim][y - d] * cols[x][y - d];
                    //count all squares alligned RIGHT from the query point (x,y)
                    if (y + d <= 1000 && cols[xprim]?.ContainsKey(y + d) == true && cols[x]?.ContainsKey(y + d) == true)
                        res += quantity * cols[xprim][y + d] * cols[x][y + d];
                }

            return res;
        }
    }
}