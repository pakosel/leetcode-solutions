using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public class ArrayHelper
    {
        public static int?[] ParseArrayForTreeNode(string arrStr)
        {
            var arrS = arrStr.TrimStart('[').TrimEnd(']').Split(",");
            if(arrS[0] == "")
                return new int?[0];

            int?[] arr = new int?[arrS.Length];

            for(int i=0; i<arrS.Length; i++)
                if(arrS[i] == "null")
                    arr[i] = null;
                else
                    arr[i] = int.Parse(arrS[i]);

            return arr;
        }

        public static int[] ArrayFromString(string arrString)
        {
            var arr = arrString.TrimStart('[').TrimEnd(']').Split(',');
            if(arr[0] == "")
                return new int[0];

            var res = new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
                res[i] = int.Parse(arr[i]);

            return res;
        }

        public static int[][] MatrixFromString(string matrixStr)
        {
            int[][] matrix;
            var arr = matrixStr.TrimStart('[').TrimEnd(']').Split("],[");
            if(arr[0] == "")
                return new int[0][];
            matrix = new int[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                matrix[i] = new int[innerArr.Length];
                for(int j=0; j<innerArr.Length; j++)
                    matrix[i][j] = int.Parse(innerArr[j]);
            }

            return matrix;
        }

        public static string MatrixToString(int[][] matrix)
        {
            if(matrix.Length == 0)
                return "[]";

            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            sb.Append(string.Join(',', matrix.Select(it => "[" + string.Join(',', it) + "]")));
            sb.Append(']');

            return sb.ToString();
        }
    }
}