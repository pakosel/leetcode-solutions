using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace GuessNumberHigherOrLower
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {10, 6},
            new object[] {1, 1},
            new object[] {2, 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(int n, int picked)
        {
            var sol = new Solution();
            sol.Pick(picked);
            var res = sol.GuessNumber(n);

            Assert.That(picked == res);
        }
    }
}