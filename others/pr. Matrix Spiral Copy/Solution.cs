using System;
using System.Collections;
using System.Collections.Generic;

namespace MatrixSpiralCopy
{
    public class Solution
    {
        public static int[] SpiralCopy(int[,] inputMatrix)
        {
            int matrixWidth = inputMatrix.GetLength(1);
            int matrixHeight = inputMatrix.GetLength(0);

            Console.Out.WriteLine($"MatrixWidth = {matrixWidth}");
            Console.Out.WriteLine($"matrixHeight = {matrixHeight}");

            int[] res = new int[matrixWidth * matrixHeight];

            int topRow = 0;
            int bottomRow = matrixHeight - 1;
            int leftCol = 0;
            int rightCol = matrixWidth - 1;

            int idx = 0;
            while (leftCol <= rightCol && topRow <= bottomRow)
            {
                for (int i = leftCol; i <= rightCol; i++)
                    res[idx++] = inputMatrix[topRow, i];
                topRow++;

                for (int i = topRow; i <= bottomRow; i++)
                    res[idx++] = inputMatrix[i, rightCol];
                rightCol--;

                if (topRow <= bottomRow) //test case no. 2
                {
                    for (int i = rightCol; i >= leftCol; i--)
                        res[idx++] = inputMatrix[bottomRow, i];
                    bottomRow--;
                }

                for (int i = bottomRow; i >= topRow; i--)
                    res[idx++] = inputMatrix[i, leftCol];
                leftCol++;
            }

            return res;
        }
    }
}