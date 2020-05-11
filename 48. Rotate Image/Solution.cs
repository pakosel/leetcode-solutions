using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RotateImage
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int width = matrix.Length;
            if(width < 2)
                return;

            for(int row=0; row < width / 2; row++)
                for(int col=row; col < width - row - 1; col++)
                    RotatePoint(row, col, matrix);
        }

        private void RotatePoint(int x, int y, int[][] matrix)
        {
            var last = matrix.Length - 1;

            var tmp = matrix[y][last-x];
            matrix[y][last-x] = matrix[x][y];
            matrix[x][y] = matrix[last-y][x];
            matrix[last-y][x] = matrix[last-x][last-y];
            matrix[last-x][last-y] = tmp;
        }

        public void PrintMatrix(int[][] matrix)
        {
            for(int row=0; row < matrix.Length; row++)
                Console.Out.WriteLine(string.Join(',', matrix[row]));
        }
    }
}