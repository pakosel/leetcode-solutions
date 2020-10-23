using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace PalindromeNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { 1, true },
            new object[] { 12, false },
            new object[] { 121, true },
            new object[] { -121, false },
            new object[] { 10, false },
            new object[] { -101, false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int x, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsPalindrome(x);

            Assert.AreEqual(res, expected);
        }
    }
}