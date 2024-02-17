using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveAllAdjacentDuplicatesInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"abbaca", "ca"},
            new object[] {"azxxzy", "ay"},
            new object[] {"a", "a"},
            new object[] {"abccddeeba", ""},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.RemoveDuplicates(s);

            Assert.That(expected == res);
        }
    }
}