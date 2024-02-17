using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfProvinces
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1,1,0],[1,1,0],[0,0,1]]", 2},
            new object[] {"[[1,0,0],[0,1,0],[0,0,1]]", 3},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArr, int expected)
        {
            var isConnected = ArrayHelper.MatrixFromString<int>(strArr);

            var sol = new Solution();
            var res = sol.FindCircleNum(isConnected);

            Assert.That(expected == res);
        }
    }
}