using System.Collections.Generic;
using System.Linq;
using System;

namespace SpiralMatrix
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int matrixHeight = matrix.Length;
            if (matrixHeight == 0)
                return new int[0];
            int matrixWidth = matrix[0].Length;


            int[] res = new int[matrixWidth * matrixHeight];

            int topRow = 0;
            int bottomRow = matrixHeight - 1;
            int leftCol = 0;
            int rightCol = matrixWidth - 1;

            int idx = 0;
            while (leftCol <= rightCol && topRow <= bottomRow)
            {
                for (int i = leftCol; i <= rightCol; i++)
                    res[idx++] = matrix[topRow][i];
                topRow++;

                for (int i = topRow; i <= bottomRow; i++)
                    res[idx++] = matrix[i][rightCol];
                rightCol--;

                if (topRow <= bottomRow) //test case no. 2
                {
                    for (int i = rightCol; i >= leftCol; i--)
                        res[idx++] = matrix[bottomRow][i];
                    bottomRow--;
                }

                if (leftCol <= rightCol) //test case no 4
                {
                    for (int i = bottomRow; i >= topRow; i--)
                        res[idx++] = matrix[i][leftCol];
                    leftCol++;
                }
            }

            return res;
        }
    }
}