using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace RomanToInteger
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"III", 3},
            new object[] {"LVIII", 58},
            new object[] {"MCMXCIV", 1994},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.RomanToInt(s);

            Assert.That(expected == res);
        }
    }
}