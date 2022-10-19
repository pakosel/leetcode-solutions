using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountAndSay
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, "1"},
            new object[] {2, "11"},
            new object[] {3, "21"},
            new object[] {4, "1211"},
            new object[] {5, "111221"},
            new object[] {11, "11131221133112132113212221"},
            new object[] {16, "132113213221133112132113311211131221121321131211132221123113112221131112311332111213211322211312113211"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, string expected)
        {
            var sol = new Solution();
            var res = sol.CountAndSay(n);

            Assert.AreEqual(expected, res);
        }
    }
}