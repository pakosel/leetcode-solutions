using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Ipo
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {2, 0, "[1,2,3]", "[0,1,1]", 4},
            new object[] {3, 0, "[1,2,3]", "[0,1,2]", 6},
            new object[] {3, 0, "[1,2,3]", "[1,1,2]", 0},
            new object[] {10, 0, "[1,2,3]", "[0,1,2]", 6},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int k, int w, string profitsStr, string capitalStr, int expected)
        {
            var profits = ArrayHelper.ArrayFromString<int>(profitsStr);
            var capital = ArrayHelper.ArrayFromString<int>(capitalStr);

            var sol = new Solution();
            var res = sol.FindMaximizedCapital(k, w, profits, capital);

            Assert.That(expected == res);
        }
    }
}