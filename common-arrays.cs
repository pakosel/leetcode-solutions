using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace Common
{
    public class ArrayHelper
    {
        //TODO: replace reflection with IParseable<T> definition after migration to .net 7
        private static MethodInfo ParseMethod<T>()
        {
            //for int? long? etc. we need to call "Parse" on an underlying type, i.e.: int, long, etc.
            var baseType = (Nullable.GetUnderlyingType(typeof(T)) != null ? Nullable.GetUnderlyingType(typeof(T)) : typeof(T));
            return baseType.GetMethod("Parse", BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string) }, null);
        }
        
        public static T[] ArrayFromString<T>(string arrString)
        {
            var arr = arrString.TrimStart('[').TrimEnd(']').Split(',');
            if(arr[0] == "")
                return new T[0];

            var res = new T[arr.Length];
            for(int i=0; i<arr.Length; i++)
                if(arr[i] != "null")
                    res[i] = (T)ParseMethod<T>().Invoke(null, new[] {arr[i]});
                else
                    res[i] = default(T);

            return res;
        }

        public static T[][] MatrixFromString<T>(string matrixStr, bool skipContentParsing = false)
        {
            matrixStr = matrixStr.Replace(" ", "");
            if(typeof(T) == typeof(char))
                matrixStr = matrixStr.Replace("'", "");
            if(typeof(T) == typeof(string))
                skipContentParsing = true;

            T[][] matrix;
            var arr = matrixStr.TrimStart('[').TrimEnd(']').Split("],[");

            if(arr[0] == "" && arr.Length < 2)
                return new T[0][];
            matrix = new T[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                if(innerArr[0] == "")
                    matrix[i] = new T[0];
                else
                {
                    matrix[i] = new T[innerArr.Length];
                    for(int j=0; j<innerArr.Length; j++)
                        if(skipContentParsing)
                            matrix[i][j] = (T)(object)innerArr[j];
                        else
                            if(innerArr[j] != "null")
                                matrix[i][j] = (T)ParseMethod<T>().Invoke(null, new[] {innerArr[j]});
                            else
                                matrix[i][j] = default(T);
                }
            }

            return matrix;
        }

        public static string MatrixToString<T>(T[][] matrix)
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