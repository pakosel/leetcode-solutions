using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FlippingImage
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int cols = A[0].Length;
            bool oddCols = (cols % 2 == 1);

            foreach (var row in A)
            {
                for (int j = 0; j < cols / 2; j++)
                {
                    int temp = row[cols - 1 - j];
                    row[cols - 1 - j] = Invert(row[j]);
                    row[j] = Invert(temp);
                }
                if (oddCols)
                    row[cols / 2] = Invert(row[cols / 2]);
            }

            return A;
        }

        private int Invert(int b) => b == 0 ? 1 : 0;
    }
}