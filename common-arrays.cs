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
            int?[] arr = new int?[arrS.Length];

            for(int i=0; i<arrS.Length; i++)
                if(arrS[i] == "null")
                    arr[i] = null;
                else
                    arr[i] = int.Parse(arrS[i]);

            return arr;
        }
    }
}