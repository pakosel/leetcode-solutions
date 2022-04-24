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
        public static char[] CharArrayFromString(string arrString)
        {
            var arr = arrString.TrimStart('[').TrimEnd(']').Split(',');
            if(arr[0] == "")
                return new char[0];

            var res = new char[arr.Length];
            for(int i=0; i<arr.Length; i++)
                res[i] = char.Parse(arr[i]);

            return res;
        }
        
        public static int[][] MatrixFromString(string matrixStr)
        {
            matrixStr = matrixStr.Replace(" ", "");
            int[][] matrix;
            var arr = matrixStr.TrimStart('[').TrimEnd(']').Split("],[");

            if(arr[0] == "" && arr.Length < 2)
                return new int[0][];
            matrix = new int[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                if(innerArr[0] == "")
                    matrix[i] = new int[0];
                else
                {
                    matrix[i] = new int[innerArr.Length];
                    for(int j=0; j<innerArr.Length; j++)
                        matrix[i][j] = int.Parse(innerArr[j]);
                }
            }

            return matrix;
        }

        public static char[][] CharMatrixFromString(string matrixStr)
        {
            matrixStr = matrixStr.Replace(" ", "");
            matrixStr = matrixStr.Replace("'", "");
            char[][] matrix;
            var arr = matrixStr.TrimStart('[').TrimEnd(']').Split("],[");

            if(arr[0] == "" && arr.Length < 2)
                return new char[0][];
            matrix = new char[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                if(innerArr[0] == "")
                    matrix[i] = new char[0];
                else
                {
                    matrix[i] = new char[innerArr.Length];
                    for(int j=0; j<innerArr.Length; j++)
                        matrix[i][j] = char.Parse(innerArr[j]);
                }
            }

            return matrix;
        }

        public static int?[][] NullableMatrixFromString(string matrixStr)
        {
            matrixStr = matrixStr.Replace(" ", "");
            int?[][] matrix;
            var arr = matrixStr.TrimStart('[').TrimEnd(']').Split("],[");

            if(arr[0] == "" && arr.Length < 2)
                return new int?[0][];
            matrix = new int?[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                if(innerArr[0] == "")
                    matrix[i] = new int?[0];
                else
                {
                    matrix[i] = new int?[innerArr.Length];
                    for(int j=0; j<innerArr.Length; j++)
                        if(innerArr[j] == "null")
                            matrix[i][j] = null;
                        else
                            matrix[i][j] = int.Parse(innerArr[j]);
                }
            }

            return matrix;
        }
        public static string[][] StringMatrixFromString(string matrixStr)
        {
            matrixStr = matrixStr.Replace(" ", "");
            matrixStr = matrixStr.Replace("\"", "");
            string[][] matrix;
            var arr = matrixStr.TrimStart('[').TrimEnd(']').Split("],[");

            if(arr[0] == "" && arr.Length < 2)
                return new string[0][];
            matrix = new string[arr.Length][];
            for(int i=0; i<arr.Length; i++)
                matrix[i] = arr[i].TrimStart('[').TrimEnd(']').Split(',');

            return matrix;
        }

        public static int?[] NullableArrayFromString(string arrString)
        {
            var arr = arrString.TrimStart('[').TrimEnd(']').Split(',');
            if(arr[0] == "")
                return new int?[0];

            var res = new int?[arr.Length];
            for(int i=0; i<arr.Length; i++)
                if(arr[i] != "null")
                    res[i] = int.Parse(arr[i]);
                else
                    res[i] = null;

            return res;
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