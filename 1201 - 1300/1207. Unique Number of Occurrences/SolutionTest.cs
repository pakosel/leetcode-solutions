using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace UniqueNumberOfOccurrences
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,2,1,1,3]", true},
            new object[] {"[1,2]", false},
            new object[] {"[-3,0,1,-3,1,1,1,-3,10,0]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, bool expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.UniqueOccurrences(arr);

            Assert.That(expected == res);
        }
    }
}