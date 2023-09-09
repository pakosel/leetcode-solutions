using System.Collections.Generic;
using System.Linq;
using System;

namespace PascalTriangle
{
    public class Solution_2023
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>();
            var len = 0;
            while (numRows-- > 0)
            {
                var row = new int[++len];
                var prev = res.Count > 0 ? res.Last() : null;
                row[0] = row[len - 1] = 1;
                for (int i = 1; i < len - 1; i++)
                    row[i] = prev[i - 1] + prev[i];
                res.Add(row);
            }

            return res;
        }
    }
    
    public class Solution
    {
        public IList<IList<int>> GeneratePascal(int numRows)
        {
            int[][] arr = new int[numRows][];
            if (numRows == 0)
                return arr;

            arr[0] = new int[1] { 1 };

            if (numRows == 1)
                return arr;

            arr[1] = new int[2] { 1, 1 };

            for (int i = 2; i < numRows; i++)
            {
                var arr_i = new int[i + 1];
                arr_i[0] = arr_i[i] = 1;
                for (int j = 1; j < i; j++)
                    arr_i[j] = arr[i - 1][j] + arr[i - 1][j - 1];

                arr[i] = arr_i;
            }

            return arr;
        }
        public IList<IList<int>> GeneratePascal_GenList(int numRows)
        {
            IList<IList<int>> arr = new List<IList<int>>();
            if (numRows == 0)
                return arr;

            arr.Add(new List<int>() { 1 });

            if (numRows == 1)
                return arr;

            arr.Add(new List<int>() { 1, 1 });

            for (int i = 2; i < numRows; i++)
            {
                var arr_i = new List<int>();
                arr_i.Add(1);

                for (int j = 1; j < i; j++)
                    arr_i.Add(arr[i - 1][j] + arr[i - 1][j - 1]);

                arr_i.Add(1);

                arr.Add(arr_i);
            }

            return arr;
        }
    }
}