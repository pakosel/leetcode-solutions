using System.Collections.Generic;
using System.Linq;
using System;

namespace PascalTriangle
{
    public class Solution
    {
        public IList<IList<int>> GeneratePascal(int numRows)
        {
            int [][] arr = new int [numRows][];
            if(numRows == 0)
                return arr;
                
            arr[0] = new int[1] {1};
            
            if(numRows == 1)
                return arr;

            arr[1] = new int[2] {1, 1};

            for(int i=2; i < numRows; i++)
            {
                var arr_i = new int[i+1];
                arr_i[0] = arr_i[i] = 1;
                for(int j=1; j<i; j++)
                    arr_i[j] = arr[i-1][j] + arr[i-1][j-1];

                arr[i] = arr_i;
            }

            return arr;
        }
    }
}