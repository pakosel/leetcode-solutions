using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PartitionArrayForMaximumSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,15,7,9,2,5,10]", 3, 84},
            new object[] {"[1,4,1,5,7,3,6,1,9,9,3]", 4, 83},
            new object[] {"[1]", 1, 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int k, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.MaxSumAfterPartitioning(arr, k);
            
            Assert.That(expected == res);
        }
    }
}