using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FirstBadVersion
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { 5, 4 },
            new object[] { 1, 1 },
            new object[] { 2, 1 },
            new object[] { 2, 2 },
            new object[] { 3, 2 },
            new object[] { 1578654, 98796 },
            new object[] { 1979554, 831 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int bad)
        {
            var sol = new Solution();
            sol.SetBadVersion(bad);
            var res = sol.FirstBadVersion(n);

            Assert.AreEqual(res, bad);
        }
    }
}