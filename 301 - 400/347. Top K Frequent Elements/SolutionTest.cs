using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TopKFrequentElements
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,1,1,2,2,3]", 2, "[1,2]"},
            new object[] {"[1]", 1, "[1]"},
            new object[] {"[1,1,1,2,2,3,4,4,1,1,5,6,7,1,2,7,8,3,3]", 3, "[1,2,3]"},

        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string arrStr, int k, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var solutionBoring = new SolutionBoring();
            var res = sol.TopKFrequent(arr, k);
            var resBoring = solutionBoring.TopKFrequent(arr, k);

            CollectionAssert.AreEqual(res, expected);
            CollectionAssert.AreEqual(resBoring, expected);
        }
    }
}