using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PathWithMaximumGold
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0,6,0],[5,8,7],[0,9,0]]", 24},
            new object[] {"[[1,0,7],[2,0,6],[3,4,5],[0,3,0],[9,0,20]]", 28},
            new object[] {"[[77,0,75,81,41],[37,54,12,3,32],[46,99,0,73,57],[49,89,85,100,25],[12,54,3,87,64]]", 1255},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.GetMaximumGold(grid);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}