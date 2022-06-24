using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ImageOverlap
{
    public class Solution
    {
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            var res = 0;
            var n = img1.Length;
            var dest = Enumerable.Range(0, n).Select(_ => new int[n]).ToArray();

            for(int i=-1*n; i<n; i++)
                for(int j=-1*n; j<n; j++)
                    res = Math.Max(res, Overlap(Translate(img1, i, j), img2));
            return res;

            int Overlap(int[][] img1, int[][] img2)
            {
                var res = 0;
                for(int i=0; i<n; i++)
                    for(int j=0; j<n; j++)
                        if(img1[i][j] == 1 && img1[i][j] == img2[i][j])
                            res++;
                return res;
            }

            int[][] Translate(int[][] img, int x, int y)
            {
                for(int i=0; i<n; i++)
                    for(int j=0; j<n; j++)
                        if(i+x >=0 && i+x < n && j+y >= 0 && j+y < n)
                            dest[i][j] = img[i+x][j+y];
                        else
                            dest[i][j] = 0;
                return dest;
            }
        }
    }
}