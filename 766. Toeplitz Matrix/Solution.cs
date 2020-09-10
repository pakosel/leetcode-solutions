using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ToeplitzMatrix
{
    public class Solution
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int width = matrix[0].Length;
            int height = matrix.Length;

            for(int i=0; i<width; i++)
                if(!CheckDiagonal(matrix, width, height, i, 0))
                    return false;

            for(int i=0; i<height; i++)
                if(!CheckDiagonal(matrix, width, height, 0, i))
                    return false;

            return true;
        }

        private bool CheckDiagonal(int[][] matrix, int width, int height, int startX, int startY)
        {
            int val = matrix[startY][startX];
            while(++startX < width && ++startY < height)
                if(matrix[startY][startX] != val)
                    return false;
            return true;
        }
    }
}