using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RangeSumQuery2DImmutable
{
    //cumulative sum for sqared regions
    public class NumMatrix : INumMatrix
    {
        int[][] dp;
        public NumMatrix(int[][] matrix)
        {
            var m = matrix.Length + 1;
            var n = matrix[0].Length + 1;
            dp = new int[m][];
            dp[0] = new int[n];

            for (int i = 1; i < m; i++)
            {
                dp[i] = new int[n];
                for (int j = 1; j < n; j++)
                    dp[i][j] = matrix[i-1][j-1] + dp[i-1][j] + dp[i][j-1] - dp[i-1][j-1];
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            return dp[row2+1][col2+1]  - dp[row1][col2+1] - dp[row2+1][col1] + dp[row1][col1];
        }
    }

    //keep cumulative sum for each row of matrix - Accepted
    public class NumMatrix_RowsSum : INumMatrix
    {
        int[][] sumMatrix;
        public NumMatrix_RowsSum(int[][] matrix)
        {
            var n = matrix[0].Length;
            sumMatrix = new int[matrix.Length][];

            for (int i = 0; i < matrix.Length; i++)
            {
                sumMatrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                    sumMatrix[i][j] = (j == 0 ? matrix[i][j] : matrix[i][j] + sumMatrix[i][j - 1]);
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            var res = 0;
            for (int i = row1; i <= row2; i++)
            {
                res += sumMatrix[i][col2];
                if (col1 > 0)
                    res -= sumMatrix[i][col1 - 1];
            }
            return res;
        }
    }

    //Naive approach - TLE on Leetcode
    public class NumMatrix_TLE : INumMatrix
    {
        int[][] matrix;
        public NumMatrix_TLE(int[][] matrix)
        {
            this.matrix = matrix;
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            var res = 0;
            for (int i = row1; i <= row2; i++)
                for (int j = col1; j <= col2; j++)
                    res += matrix[i][j];

            return res;
        }
    }

    public interface INumMatrix
    {
        public int SumRegion(int row1, int col1, int row2, int col2);
    }
}