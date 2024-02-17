using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PowerOfThree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, false },
            new object[] {1, true },
            new object[] {3, true },
            new object[] {9, true },
            new object[] {27, true },
            new object[] {81, true },
            new object[] {-1, false },
            new object[] {-3, false },
            new object[] {-9, false },
            new object[] {6, false },
            new object[] {12, false },
            new object[] {13, false },
            new object[] {15, false },
            new object[] {18, false },
            new object[] {21, false },
            new object[] {198, false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(int n, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsPowerOfThree(n);

            Assert.That(expected == res);
        }
    }
}