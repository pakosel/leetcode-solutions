using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindTheDistanceValueBetweenTwoArrays
{
    public class Solution
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            return arr1.Count(e => arr2.All(x => Math.Abs(e - x) > d));
        }
    }
}