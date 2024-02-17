using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
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
            new object[] { 1237321, true },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int x, bool expected)
        {
            var sol = new Solution_NoString();
            var res = sol.IsPalindrome(x);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_toString(int x, bool expected)
        {
            var sol = new Solution_ToString();
            var res = sol.IsPalindrome(x);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}