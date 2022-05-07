using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DailyTemperatures
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[73,74,75,71,69,72,76,73]", "[1,1,4,2,1,1,0,0]" },
            new object[] { "[30,40,50,60]", "[1,1,1,0]" },
            new object[] { "[30,60,90]", "[1,1,0]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string inputStr, string expectedStr)
        {
            var temperatures = ArrayHelper.ArrayFromString(inputStr);
            var sol = new Solution();
            var res = sol.DailyTemperatures(temperatures);
            var expected = ArrayHelper.ArrayFromString(expectedStr);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}