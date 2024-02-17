using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReorderedPowerOf2
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, true},
            new object[] {10, false},
            new object[] {2, true},
            new object[] {3, false},
            new object[] {64, true},
            new object[] {46, true},
            new object[] {218, true},
            new object[] {526, true},
            new object[] {652, true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, bool expected)
        {
            var sol = new Solution();
            var res = sol.ReorderedPowerOf2(n);

            Assert.That(expected == res);
        }
    }
}