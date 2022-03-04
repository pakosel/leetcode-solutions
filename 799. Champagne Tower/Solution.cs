using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ChampagneTower
{
    public class Solution
    {
        public double ChampagneTower(int poured, int query_row, int query_glass)
        {
            var tower = FillTower(query_row, poured);
            var res = tower[query_row][query_glass];

            if (res < 0)
                res = 0;
            if (res > 1)
                res = 1;
            return res;
        }

        private List<List<double>> FillTower(int maxRow, int p)
        {
            var res = new List<List<double>>();
            res.Add(new List<double>() { p });
            for (int i = 1; i <= maxRow; i++)
            {
                var curr = new List<double>() { (res[i - 1].First() - 1) / 2 };
                for (int j = 1; j < i; j++)
                {
                    var left = res[i - 1][j - 1] > 1 ? (res[i - 1][j - 1] - 1) / 2 : 0;
                    var right = res[i - 1][j] > 1 ? (res[i - 1][j] - 1) / 2 : 0;
                    curr.Add(left + right);
                }
                curr.Add((res[i - 1].Last() - 1) / 2);
                res.Add(curr);
            }
            return res;
        }
    }
}