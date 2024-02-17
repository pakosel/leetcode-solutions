using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CheckIfAllAsAppearsBeforeAllBs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"aaabbb", true},
            new object[] {"abab", false},
            new object[] {"bbb", true},
            new object[] {"a", true},
            new object[] {"b", true},
            new object[] {"bbb", true},
            new object[] {"ba", false},
            new object[] {"ab", true},
            new object[] {"aba", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, bool expected)
        {
            var sol = new Solution();
            var res = sol.CheckString(s);

            Assert.That(expected == res);
        }
    }
}